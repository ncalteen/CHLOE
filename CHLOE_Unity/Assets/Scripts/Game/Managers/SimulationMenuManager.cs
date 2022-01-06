using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using TMPro;

public class SimulationMenuManager : Singleton<SimulationMenuManager>
{
    #region Variables
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

    /// <summary>
    /// The container for the service category list UI.
    /// </summary>
    [SerializeField] private GameObject categoryContainer;

    /// <summary>
    /// The initial GameObject to focus on when opening the service category menu.
    /// </summary>
    [SerializeField] private GameObject categoryDefaultGameObject;

    /// <summary>
    /// The container for the service list UI.
    /// </summary>
    [SerializeField] private GameObject serviceContainer;

    /// <summary>
    /// Parent content GameObject for service list ScrollRect.
    /// </summary>
    [SerializeField] private GameObject serviceItemParent;

    /// <summary>
    /// Prefab for the service list item buttons.
    /// </summary>
    [SerializeField] private GameObject serviceItemPrefab;

    /// <summary>
    /// The back button to return to the category list.
    /// </summary>
    [SerializeField] private GameObject categoryBackButton;

    /// <summary>
    /// The text for the back button on the service list.
    /// </summary>
    [SerializeField] private TMP_Text categoryBackButtonText;

    /// <summary>
    /// The back button to return to the service list.
    /// </summary>
    [SerializeField] private GameObject serviceBackButton;

    /// <summary>
    /// The text for the back button on the resource list.
    /// </summary>
    [SerializeField] private TMP_Text serviceBackButtonText;

    /// <summary>
    /// The container for the resource item UI.
    /// </summary>
    [SerializeField] private GameObject resourceContainer;

    /// <summary>
    /// Details for the selected resource.
    /// </summary>
    [SerializeField] private GameObject resourceDetailContainer;

    /// <summary>
    /// Parent content GameObject for resource list ScrollRect.
    /// </summary>
    [SerializeField] private GameObject resourceItemParent;

    /// <summary>
    /// Prefab for the resource list item buttons.
    /// </summary>
    [SerializeField] private GameObject resourceItemPrefab;

    /// <summary>
    /// The container that holds a spinning model of the selected resource.
    /// </summary>
    [SerializeField] private GameObject resourceModelContainer;

    /// <summary>
    /// The description text box for the selected resource.
    /// </summary>
    [SerializeField] private TMP_Text resourceDescription;

    /// <summary>
    /// The currently selected service category button.
    /// </summary>
    private GameObject selectedCategoryButton;

    /// <summary>
    /// The currently selected service button.
    /// </summary>
    private GameObject selectedServiceButton;
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

        // Service menu objects.
        this.categoryBackButton.SetActive(false);
        this.serviceBackButton.SetActive(false);
        this.categoryContainer.SetActive(true);
        this.serviceContainer.SetActive(false);
        this.resourceContainer.SetActive(false);
        this.resourceDetailContainer.SetActive(false);

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
        // Show mouse cursor.
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        // Show the canvas background.
        this.backgroundPane.SetActive(true);

        // Show the service menu.
        this.serviceMenuContainer.SetActive(true);

        // Change player control mode.
        InputManager.Instance.TogglePlayerInputActionMap("UI");

        // Change focus to the first item in the category list.
        EventSystem.current.SetSelectedGameObject(this.categoryDefaultGameObject);
        this.selectedCategoryButton = this.categoryDefaultGameObject;
    }

    /// <summary>
    /// User closes the service menu.
    /// </summary>
    public void OnCloseServiceMenuEvent(InputAction.CallbackContext context)
    {
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
    /// <param name="button">
    /// The GameObject selected by the user.
    /// </param>
    public void OnCategorySelectedEvent(ServiceCategoryTypes category, GameObject button)
    {
        // Get the AWS services in this category that are supported for this level/mode.
        if (GameManager.CurrentMode != GameMode.SIMULATION)
        {
            Debug.LogError("Trying to load service list outside of Simulation mode.");
            return;
        }

        // Clear anything in the service list currently.
        foreach (Transform child in this.serviceItemParent.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        // Populate the service list for this category.
        bool first = true;
        foreach (ServiceSO awsService in SimulationManager.Instance.Level.AWSServices)
        {
            if (awsService.Category == category)
            {
                // Create a button for each service item.
                GameObject serviceButton = Instantiate(this.serviceItemPrefab, this.serviceItemParent.transform);

                // Update the service this button represents, and the label.
                ServiceListButtonHandler buttonHandler = serviceButton.GetComponent<ServiceListButtonHandler>();
                buttonHandler.Service = awsService;
                buttonHandler.Label.text = awsService.ShortName;

                if (first)
                {
                    // Set the first item in the list as selected.
                    EventSystem.current.SetSelectedGameObject(serviceButton);

                    // Set current selection.
                    this.selectedServiceButton = serviceButton;

                    first = false;
                }
            }
        }

        // Disable the category list.
        this.categoryContainer.SetActive(false);

        // Enable the service list.
        this.serviceContainer.SetActive(true);

        // Set the back button text.
        this.categoryBackButtonText.text = $"< {ServiceCategory.Name(category)}";

        // Enable the back button.
        this.categoryBackButton.SetActive(true);

        // Set current selection.
        this.selectedCategoryButton = button;
    }

    /// <summary>
    /// User selects a service to view.
    /// </summary>
    /// <param name="service">
    /// The service the user wants to view.
    /// </param>
    /// <param name="button">
    /// The GameObject selected by the user.
    /// </param>
    public void OnServiceSelectedEvent(ServiceSO service)
    {
        // Get the AWS resources in this service that are supported for this level/mode.
        if (GameManager.CurrentMode != GameMode.SIMULATION)
        {
            Debug.LogError("Trying to load resource list outside of Simulation mode.");
            return;
        }

        // Clear anything in the service list currently.
        foreach (Transform child in this.resourceItemParent.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        // Populate the service list for this category.
        bool first = true;
        foreach (ResourceSO resource in service.ResourceInstances)
        {
            // Create a button for each service item.
            GameObject resourceButton = Instantiate(this.resourceItemPrefab, this.resourceItemParent.transform);

            // Update the service this button represents, and the label.
            ResourceListButtonHandler buttonHandler = resourceButton.GetComponent<ResourceListButtonHandler>();
            buttonHandler.Resource = resource;
            buttonHandler.Label.text = resource.ShortName;

            if (first)
            {
                // Set the first item in the list as selected.
                EventSystem.current.SetSelectedGameObject(resourceButton);

                first = false;
            }
        }

        // Disable the service list.
        this.serviceContainer.SetActive(false);

        // Set the back button text.
        this.serviceBackButtonText.text = $"< {service.ShortName}";

        // Enable the back button.
        this.serviceBackButton.SetActive(true);

        // Enable the resource list.
        this.resourceContainer.SetActive(true);
    }

    /// <summary>
    /// Player navigates back from the selected service to the category list.
    /// </summary>
    public void OnCategoryBackEvent()
    {
        // Disable the resource list.
        this.resourceContainer.SetActive(false);

        // Disable the service list.
        this.serviceContainer.SetActive(false);

        // Disable back buttons.
        this.categoryBackButton.SetActive(false);
        this.serviceBackButton.SetActive(false);

        // Enable the category list.
        this.categoryContainer.SetActive(true);

        // Change focus to the previously selected item in the category list.
        EventSystem.current.SetSelectedGameObject(this.selectedCategoryButton);
    }

    /// <summary>
    /// Player navigates back from the selected service to the list of services in that category.
    /// </summary>
    public void OnServiceBackEvent()
    {
        // Disable the resource list.
        this.resourceContainer.SetActive(false);
        this.resourceDetailContainer.SetActive(false);

        // Disable the category list.
        this.categoryContainer.SetActive(false);

        // Disable the back button.
        this.serviceBackButton.SetActive(false);

        // Enable the service list.
        this.serviceContainer.SetActive(true);

        // Change focus to the previously selected item in the service list.
        EventSystem.current.SetSelectedGameObject(this.selectedServiceButton);
    }

    /// <summary>
    /// User has selected a resource type from the service UI.
    /// </summary>
    /// <param name="resource">
    /// The resource representation.
    /// </param>
    public void OnResourceSelectedEvent(ResourceSO resource)
    {
        // Remove any previous spinning model.
        foreach (Transform child in this.resourceModelContainer.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        // Instantiate the spinning model for the selected service.
        GameObject model = Instantiate(resource.ResourcePrefab, this.resourceModelContainer.transform);

        // Scale it up to the right size for the UI.
        model.transform.localScale = new Vector3(200f, 200f, 200f);

        // Make sure it is added to the UI layer.
        model.layer = 5;

        // Remove the collider (used in the game world).
        GameObject.Destroy(model.GetComponent<BoxCollider>());

        // Update the transform in SpinningResourceModelHandler.
        SpinningResourceModelHandler.Instance.ResourceTransform = model.transform;

        // Update the text box with the details about the service.
        this.resourceDescription.text = resource.Description;

        // Done setup, show the menu.
        this.resourceDetailContainer.SetActive(true);
    }
    #endregion
}
