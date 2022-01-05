using UnityEngine;
using UnityEngine.EventSystems;

public class CategoryBackButtonHandler : MonoBehaviour
{
    #region Event Handlers
    /// <summary>
    /// User selects the back button from the services list.
    /// </summary>
    public void OnCategoryBackSelected(BaseEventData eventData)
    {
        // Call SimulationMenuManager to revert the menus.
        SimulationMenuManager.Instance.OnCategoryBackEvent();
    }
    #endregion
}
