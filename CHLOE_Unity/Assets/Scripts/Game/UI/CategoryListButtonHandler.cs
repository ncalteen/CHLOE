using UnityEngine;
using UnityEngine.EventSystems;

public class CategoryListButtonHandler : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// The category of services this button controls.
    /// </summary>
    [SerializeField] private ServiceCategoryTypes category;
    #endregion

    #region Properties
    public ServiceCategoryTypes Category
    {
        get { return this.category; }
    }
    #endregion

    #region Event Handlers
    /// <summary>
    /// User selects a service category.
    /// SimulationMenuManager will populate the services list.
    /// </summary>
    public void OnCategorySelected(BaseEventData eventData)
    {
        // Call SimulationMenuManager to populate the services list.
        SimulationMenuManager.Instance.OnCategorySelectedEvent(this.category, this.gameObject);
    }
    #endregion
}
