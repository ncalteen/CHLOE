using UnityEngine;
using UnityEngine.EventSystems;

public class CreateResourceButtonHandler : MonoBehaviour
{
    #region Event Handlers
    /// <summary>
    /// User selects the back button from the services list.
    /// </summary>
    public void OnCreateResourceSelected(BaseEventData eventData)
    {
        // Call SimulationMenuManager to revert the menus.
        SimulationMenuManager.Instance.OnCreateResourceEvent();
    }
    #endregion
}
