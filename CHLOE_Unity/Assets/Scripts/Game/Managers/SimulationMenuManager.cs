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
        InputBroker.Input_OnCloseServiceMenuEvent += OnCloseServiceMenuEvent;
    }

    private void OnDisable()
    {
        // Unsubscribe to event notifications.
        InputBroker.Input_OnOpenServiceMenuEvent -= OnOpenServiceMenuEvent;
        InputBroker.Input_OnCloseServiceMenuEvent -= OnCloseServiceMenuEvent;
    }
    #endregion

    #region Event Handlers
    /// <summary>
    /// User opens the service menu.
    /// </summary>
    public void OnOpenServiceMenuEvent(InputAction.CallbackContext context)
    {
        // Switch menu open state.
        this.isMenuOpen = true;

        // Show mouse cursor.
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        // Show the canvas background.
        this.backgroundPane.SetActive(true);

        // Show the service menu.
        this.serviceMenuContainer.SetActive(true);

        // Change player control mode.
        InputManager.Instance.TogglePlayerInputActionMap("UI");
    }

    /// <summary>
    /// User closes the service menu.
    /// </summary>
    public void OnCloseServiceMenuEvent(InputAction.CallbackContext context)
    {
        // Switch menu open state.
        this.isMenuOpen = false;

        // Hide mouse cursor.
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // Show the canvas background.
        this.backgroundPane.SetActive(false);

        // Show the service menu.
        this.serviceMenuContainer.SetActive(false);

        // Change player control mode.
        InputManager.Instance.TogglePlayerInputActionMap("Player");
    }

    /// <summary>
    /// User selects a category of services to view.
    /// </summary>
    /// <param name="category">
    /// The category the user wants to view.
    /// </param>
    public void OnServiceCategorySelectedEvent(ServiceCategoryTypes category)
    {

    }
    #endregion
}
