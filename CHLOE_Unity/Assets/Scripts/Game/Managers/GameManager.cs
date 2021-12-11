using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    #region Variables
    /// <summary>
    /// Current mode the application is in.
    /// </summary>
    [SerializeField] private static GameMode currentMode = GameMode.MAIN_MENU;

    /// <summary>
    /// Demo mode scene.
    /// </summary>
    [SerializeField] private LevelSO demoLevel;

    /// <summary>
    /// Simulation mode scene.
    /// </summary>
    [SerializeField] private LevelSO simulationLevel;

    /// <summary>
    /// Available game levels.
    /// </summary>
    [SerializeField] private List<LevelSO> gameLevels;
    #endregion

    #region Properties
    public static GameMode CurrentMode
    {
        get { return currentMode; }
    }
    #endregion

    #region Unity
    private void Start()
    {
        if (currentMode == GameMode.MAIN_MENU)
        {
            if (!SceneManager.GetSceneByName("MainMenu").isLoaded)
            {
                // Load the main menu if it is not already.
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
            }
        }
    }

    private new void OnDestroy()
    {
        PlayerSettings.Instance.Save();
    }
    #endregion

    #region Scene Management
    /// <summary>
    /// Player is starting demo mode. Unload any other scenes except this one and the demo.
    /// </summary>
    public void OnDemoModeOpened()
    {
        // Load the demo scene.
        SceneManager.LoadScene(this.demoLevel.SceneName, LoadSceneMode.Additive);

        // Unload the main menu scene if it is active.
        if (SceneManager.GetSceneByName("MainMenu").isLoaded)
        {
            SceneManager.UnloadSceneAsync("MainMenu");
        }

        // Change the current game mode after everything is loaded/unloaded.
        currentMode = GameMode.DEMO;
    }
    #endregion
}
