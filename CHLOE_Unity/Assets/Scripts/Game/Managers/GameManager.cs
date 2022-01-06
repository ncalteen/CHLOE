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
            // Unload the simulation scene if it is loaded (for development).
            if (SceneManager.GetSceneByName(simulationLevel.SceneName).isLoaded)
                SceneManager.UnloadSceneAsync(simulationLevel.SceneName);

            // Load the main menu if it is not already.
            if (!SceneManager.GetSceneByName("MainMenu").isLoaded)
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
        }
    }

    private new void OnDestroy()
    {
        PlayerSettings.Instance.Save();
    }
    #endregion

    #region Scene Management
    /// <summary>
    /// Player is starting simulation mode. Unload any other scenes except this one and the simulation.
    /// </summary>
    public void OnSimulationModeOpened()
    {
        // Unload the main menu scene if it is active.
        if (SceneManager.GetSceneByName("MainMenu").isLoaded)
        {
            SceneManager.UnloadSceneAsync("MainMenu");
        }

        // Load the simulation scene.
        SceneManager.LoadScene(this.simulationLevel.SceneName, LoadSceneMode.Additive);

        // Change the current game mode after everything is loaded/unloaded.
        currentMode = GameMode.SIMULATION;

        // Hide mouse cursor.
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    #endregion
}
