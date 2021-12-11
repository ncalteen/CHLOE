using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class MainMenuManager : Singleton<MainMenuManager>
{
    #region Variables
    /// <summary>
    /// Container for main menu UI parts.
    /// </summary>
    [SerializeField] private GameObject mainMenuContainer;

    /// <summary>
    /// Container for settings menu UI parts.
    /// </summary>
    [SerializeField] private GameObject settingsMenuContainer;

    /// <summary>
    /// Container for level menu UI parts.
    /// </summary>
    [SerializeField] private GameObject levelMenuContainer;

    /// <summary>
    /// Container for AWS settings UI.
    /// </summary>
    [SerializeField] private GameObject awsSettingsContainer;

    /// <summary>
    /// Container for controls settings UI.
    /// </summary>
    [SerializeField] private GameObject controlsSettingsContainer;

    /// <summary>
    /// Container for sound settings UI.
    /// </summary>
    [SerializeField] private GameObject soundSettingsContainer;

    /// <summary>
    /// Container for gameplay settings UI.
    /// </summary>
    [SerializeField] private GameObject gameplaySettingsContainer;

    /// <summary>
    /// Drop down of AWS profiles.
    /// </summary>
    [SerializeField] private TMP_Dropdown profileDropDown;
    #endregion

    #region Unity
    private void Start()
    {
        // Make sure the right menus are enabled/disabled.
        this.mainMenuContainer.SetActive(true);
        this.settingsMenuContainer.SetActive(false);
        this.levelMenuContainer.SetActive(false);

        // Load the list of AWS profiles for this account.
        LoadAWSProfileDropDown();
    }
    #endregion

    #region Button Handlers
    /// <summary>
    /// Player selects demo mode.
    /// </summary>
    public void OnDemoModeOpened(BaseEventData eventData)
    {
        // This scene will be unloaded...hand control off to GameManager.
        GameManager.Instance.OnDemoModeOpened();
    }

    /// <summary>
    /// Settings button on main menu clicked.
    /// </summary>
    public void OnSettingsOpened(BaseEventData eventData)
    {
        // Hide main menu container.
        this.mainMenuContainer.SetActive(false);

        // Hide all settings menus except AWS.
        this.awsSettingsContainer.SetActive(true);
        this.controlsSettingsContainer.SetActive(false);
        this.soundSettingsContainer.SetActive(false);
        this.gameplaySettingsContainer.SetActive(false);

        // Show settings menu container.
        this.settingsMenuContainer.SetActive(true);
    }

    /// <summary>
    /// Player selects back from the settings menu.
    /// </summary>
    public void OnSettingsClosed(BaseEventData eventData)
    {
        // Hide the settings menu container.
        this.settingsMenuContainer.SetActive(false);

        // Show main menu container.
        this.mainMenuContainer.SetActive(true);
    }

    /// <summary>
    /// AWS config menu opened.
    /// </summary>
    public void OnAWSConfigOpened(BaseEventData eventData)
    {
        this.awsSettingsContainer.SetActive(true);
        this.controlsSettingsContainer.SetActive(false);
        this.soundSettingsContainer.SetActive(false);
        this.gameplaySettingsContainer.SetActive(false);
    }

    /// <summary>
    /// Controls config menu opened.
    /// </summary>
    public void OnControlsConfigOpened(BaseEventData eventData)
    {
        this.awsSettingsContainer.SetActive(false);
        this.controlsSettingsContainer.SetActive(true);
        this.soundSettingsContainer.SetActive(false);
        this.gameplaySettingsContainer.SetActive(false);
    }

    /// <summary>
    /// Sound config menu opened.
    /// </summary>
    public void OnSoundConfigOpened(BaseEventData eventData)
    {
        this.awsSettingsContainer.SetActive(false);
        this.controlsSettingsContainer.SetActive(false);
        this.soundSettingsContainer.SetActive(true);
        this.gameplaySettingsContainer.SetActive(false);
    }

    /// <summary>
    /// Gameplay config menu opened.
    /// </summary>
    public void OnGameplayConfigOpened(BaseEventData eventData)
    {
        this.awsSettingsContainer.SetActive(false);
        this.controlsSettingsContainer.SetActive(false);
        this.soundSettingsContainer.SetActive(false);
        this.gameplaySettingsContainer.SetActive(true);
    }
    #endregion

    #region Helper Methods
    private void LoadAWSProfileDropDown()
    {
        // Clear list of options.
        this.profileDropDown.options.Clear();

        foreach (string profile in AWSManager.Profiles)
        {
            this.profileDropDown.options.Add(new TMP_Dropdown.OptionData(profile));
        }

        // Add one for disabling the AWS integration.
        this.profileDropDown.options.Insert(0, new TMP_Dropdown.OptionData("Disabled"));

        if (AWSManager.Profile != null)
        {
            // If a profile is selected, set it now.
            this.profileDropDown.value = AWSManager.Profiles.IndexOf(AWSManager.Profile);
        }
    }
    #endregion
}