using UnityEngine;
using UnityEngine.EventSystems;

public class ServiceCategoryButtonHandler : MonoBehaviour
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
    public void OnServiceCategorySelected(BaseEventData eventData)
    {
        Debug.Log(category);
    }
    #endregion
}
