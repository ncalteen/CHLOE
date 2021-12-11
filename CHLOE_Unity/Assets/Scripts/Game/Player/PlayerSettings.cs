using UnityEngine;

public class PlayerSettings : Singleton<PlayerSettings>
{
    #region Variables
    /// <summary>
    /// Player's run speed.
    /// </summary>
    [SerializeField] private float moveSpeed = 6f;

    /// <summary>
    /// Camera look sensitivity.
    /// </summary>
    [SerializeField] private float cameraSensitivity = 0.1f;

    /// <summary>
	/// Invert camera controls flag.
	/// </summary>
	[SerializeField] private bool invertCamera = true;
    #endregion

    #region Properties
    public float MoveSpeed
    {
        get { return this.moveSpeed; }
    }

    public float CameraSensitivity
    {
        get { return this.cameraSensitivity; }
    }

    public bool InvertCamera
    {
        get { return this.invertCamera; }
    }
    #endregion

    #region Constructors
    public PlayerSettings()
    {
        /*
        // Check player prefs for settings to update.
        if (PlayerPrefs.HasKey("MoveSpeed"))
            this.moveSpeed = PlayerPrefs.GetFloat("MoveSpeed");
        if (PlayerPrefs.HasKey("CameraSensitivity"))
            this.cameraSensitivity = PlayerPrefs.GetFloat("CameraSensitivity");
        if (PlayerPrefs.HasKey("InvertCamera"))
            this.invertCamera = PlayerPrefs.GetInt("InvertCamera") == 1;
        */
    }
    #endregion

    #region Helper Methods
    /// <summary>
    /// Save current player settings.
    /// </summary>
    public void Save()
    {
        PlayerPrefs.SetFloat("MoveSpeed", this.moveSpeed);
        PlayerPrefs.SetFloat("CameraSensitivity", this.cameraSensitivity);
        PlayerPrefs.SetInt("InvertCamera", this.invertCamera == true ? 1 : 0);
        PlayerPrefs.Save();
    }
    #endregion
}
