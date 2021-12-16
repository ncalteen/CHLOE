using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class SimulationMenuManager : Singleton<SimulationMenuManager>
{
    #region Variables
    /// <summary>
    /// Track status of the menu.
    /// </summary>
    private bool isMenuOpen = false;

    /// <summary>
    /// The background pane to darken the game environment during pause/menu open.
    /// </summary>
    [SerializeField] private GameObject backgroundPane;

    /// <summary>
    /// The container for the pause menu UI.
    /// </summary>
    [SerializeField] private GameObject pauseMenuContainer;

    /// <summary>
    /// The container for the service menu UI.
    /// </summary>
    [SerializeField] private GameObject serviceMenuContainer;

    /// <summary>
    /// The container for the resource menu UI.
    /// </summary>
    [SerializeField] private GameObject resourceMenuContainer;

    /// <summary>
    /// The container for the mail menu UI.
    /// </summary>
    [SerializeField] private GameObject mailMenuContainer;
    #endregion

    #region Properties
    public bool IsMenuOpen
    {
        get { return this.isMenuOpen; }
        set { this.isMenuOpen = value; }
    }
    #endregion

    #region Unity
    private void Start()
    {
        // Hide the menu container GameObjects.
        this.backgroundPane.SetActive(false);
        this.pauseMenuContainer.SetActive(false);
        this.serviceMenuContainer.SetActive(false);
        this.resourceMenuContainer.SetActive(false);
        this.mailMenuContainer.SetActive(false);

        // Subscribe to event notifications.
        InputBroker.Input_OnOpenServiceMenuEvent += OnOpenServiceMenuEvent;
    }

    private void OnDisable()
    {
        // Unsubscribe to event notifications.
        InputBroker.Input_OnOpenServiceMenuEvent -= OnOpenServiceMenuEvent;
    }
    #endregion

    #region UI Event Handlers
    /// <summary>
    /// User opens/closes the service menu.
    /// </summary>
    public void OnOpenServiceMenuEvent(InputAction.CallbackContext context)
    {
        // Switch menu open state.
        this.isMenuOpen = !this.isMenuOpen;

        // Toggle service menu.
        ToggleServiceMenu();

        // Change player control mode.
        if (this.isMenuOpen)
            InputManager.Instance.TogglePlayerInputActionMap("UI");
        else
            InputManager.Instance.TogglePlayerInputActionMap("Player");
    }
    #endregion

    #region Service Menu Helper Methods
    /// <summary>
    /// Shows the service menu in its initial state.
    /// </summary>
    private void ToggleServiceMenu()
    {
        // Show the canvas background.
        this.backgroundPane.SetActive(this.isMenuOpen);

        // Show the service menu.
        this.serviceMenuContainer.SetActive(this.isMenuOpen);
    }
    #endregion
}
