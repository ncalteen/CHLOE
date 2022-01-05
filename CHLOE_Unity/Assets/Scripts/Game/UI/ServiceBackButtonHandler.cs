using UnityEngine;
using UnityEngine.EventSystems;

public class ServiceBackButtonHandler : MonoBehaviour
{
    #region Event Handlers
    /// <summary>
    /// User selects the back button from the services list.
    /// </summary>
    public void OnServiceBackSelected(BaseEventData eventData)
    {
        // Call SimulationMenuManager to revert the menus.
        SimulationMenuManager.Instance.OnServiceBackEvent();
    }
    #endregion
}
