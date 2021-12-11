using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AWSManager : Singleton<AWSManager>
{
    #region Variables
    /// <summary>
    /// The AWS credential profile. Stored in the user's machine in the ~/.aws directory.
    /// </summary>
    private static CredentialProfile credentialProfile;

    /// <summary>
    /// Credentials object for AWS services.
    /// </summary>
    private static AWSCredentials awsCredentials;

    /// <summary>
    /// The shared credentials file for multiple named profiles.
    /// </summary>
    private static SharedCredentialsFile sharedCredentialsFile = new SharedCredentialsFile();

    /// <summary>
    /// List of AWS CLI profile names.
    /// </summary>
    private static List<string> profiles = new List<string>();

    /// <summary>
    /// Selected AWS CLI profile name.
    /// </summary>
    private static string profile = null;
    #endregion

    #region Properties
    public static CredentialProfile CredentialProfile
    {
        get { return credentialProfile; }
        set { credentialProfile = value; }
    }

    public static AWSCredentials AWSCredentials
    {
        get { return awsCredentials; }
        set { awsCredentials = value; }
    }

    public static SharedCredentialsFile SharedCredentialsFile
    {
        get { return sharedCredentialsFile; }
        set { sharedCredentialsFile = value; }
    }

    public static List<string> Profiles
    {
        get { return profiles; }
    }

    public static string Profile
    {
        get { return profile; }
        set
        {
            if (value == null)
            {
                // Value of null means disabling the AWS APIs.
                profile = null;
                Debug.Log("AWS Integration Disabled");
            }
            else if (!profiles.Contains(value))
            {
                // Value does not exist in the list of profiles.
                profile = null;
                Debug.LogError("Invalid AWS Profile Selected");
            }
            else
            {
                // Set selected profile.
                profile = value;
                Debug.Log($"Profile {value} Selected");
            }
        }
    }
    #endregion

    #region Unity
    /// <summary>
    /// Loads the AWS CLI profiles from disk.
    /// </summary>
    private void Start()
    {
        // Get the list of AWS profiles.
        LoadAWSProfiles();
    }
    #endregion

    #region Helper Methods
    /// <summary>
    /// Depending on OS, reads stored AWS profiles and stores locally.
    /// </summary>
    private void LoadAWSProfiles()
    {
        // https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-profiles.html
        char[] charsToTrim = { '[', ']' };
        string credentialPath;
        string configPath;

        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
        {
            // https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-files.html
            // For Windows, profiles can be stored in:
            //   $HOME/.aws/credentials (higher precedence)
            //   $HOME/.aws/config      (lower precedence)
            // TODO: Check env vars https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-envvars.html

            credentialPath = Environment.GetEnvironmentVariable("UserProfile") + "\\.aws\\credentials";
            configPath = Environment.GetEnvironmentVariable("UserProfile") + "\\.aws\\config";
        }
        else if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer)
        {
            // For macOS, profiles can be stored in:
            //   ~/.aws/credentials (higher precedence)
            //   ~/.aws/config      (lower precedence)
            // TODO: Check env vars https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-envvars.html

            credentialPath = Environment.GetEnvironmentVariable("HOME") + "/.aws/credentials";
            configPath = Environment.GetEnvironmentVariable("HOME") + "/.aws/config";
        }
        else
        {
            // TODO: Support other platforms?
            return;
        }

        // Read credentials file.
        // This file uses "[MyProfile]" as the profile header.
        using (StreamReader reader = new StreamReader(credentialPath))
        {
            string item = reader.ReadLine();
            while (item != null)
            {
                // Check if this line is a profile.
                if (item.StartsWith("[") && item.EndsWith("]"))
                {
                    string newItem = item.Trim(charsToTrim);

                    if (!profiles.Contains(newItem))
                    {
                        profiles.Add(newItem);
                    }
                }

                item = reader.ReadLine();
            }
        }

        // Read config file.
        // This file uses "[profile MyProfile]" as the profile header.
        using (StreamReader reader = new StreamReader(configPath))
        {
            string item = reader.ReadLine();
            while (item != null)
            {
                // Check if this line is a profile.
                if (item.StartsWith("[") && item.EndsWith("]"))
                {
                    // Split "profile Name" by space and grab second item.
                    // The default profile is still [default], not [profile default].
                    string newItem = item.Trim(charsToTrim);
                    if (newItem.Contains(" "))
                    {
                        newItem = newItem.Split(' ')[1];
                    }

                    if (!profiles.Contains(newItem))
                    {
                        profiles.Add(newItem);
                    }
                }

                item = reader.ReadLine();
            }
        }

        // Sort named profile list.
        profiles.Sort();

        if (profiles.Contains("default"))
        {
            // Move to top of list.
            profiles.Remove("default");
            profiles.Insert(0, "default");
        }
    }

    /// <summary>
    /// When the player selects a profile from the menu, this configures the credentials using AWSCredentialsFactory.
    /// </summary>
    /// <param name="index">
    /// The index of the profile in the list.
    /// </param>
    public static void SetProfile(int index)
    {
        if (index == profiles.Count)
        {
            // The "Disabled" option is the last one in the list.
            // Length of profile list + 1.
            Profile = null;
            return;
        }

        if (!sharedCredentialsFile.TryGetProfile(profiles[index], out credentialProfile))
        {
            Profile = null;
            Debug.Log($"Could not get profile {profiles[index]}");
            return;
        }

        if (!AWSCredentialsFactory.TryGetAWSCredentials(credentialProfile, sharedCredentialsFile, out awsCredentials))
        {
            Profile = null;
            Debug.Log($"Could not get credentials from profile {profiles[index]}");
            return;
        }

        Profile = profiles[index];
    }
    #endregion
}