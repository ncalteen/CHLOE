using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ServiceListButtonHandler : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// The service this button controls.
    /// </summary>
    private ServiceSO service;

    /// <summary>
    /// The text label for this button.
    /// </summary>
    [SerializeField] private TMP_Text label;
    #endregion

    #region Properties
    public ServiceSO Service
    {
        get { return this.service; }
        set { this.service = value; }
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
    public void OnServiceListItemSelected(BaseEventData eventData)
    {
        // Call SimulationMenuManager to populate the services list.
        SimulationMenuManager.Instance.OnServiceSelectedEvent(this.service);
    }
    #endregion
}
