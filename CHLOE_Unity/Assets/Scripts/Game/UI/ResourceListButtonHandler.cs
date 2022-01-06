using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ResourceListButtonHandler : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// The resource this button controls.
    /// </summary>
    private ResourceSO resource;

    /// <summary>
    /// The text label for this button.
    /// </summary>
    [SerializeField] private TMP_Text label;
    #endregion

    #region Properties
    public ResourceSO Resource
    {
        get { return this.resource; }
        set { this.resource = value; }
    }

    public TMP_Text Label
    {
        get { return this.label; }
    }
    #endregion

    #region Event Handlers
    /// <summary>
    /// User selects a service.
    /// SimulationMenuManager will populate the resources list.
    /// </summary>
    public void OnResourceListItemSelected(BaseEventData eventData)
    {
        // Call SimulationMenuManager to populate the resource description.
        SimulationMenuManager.Instance.OnResourceSelectedEvent(resource);
    }
    #endregion
}
