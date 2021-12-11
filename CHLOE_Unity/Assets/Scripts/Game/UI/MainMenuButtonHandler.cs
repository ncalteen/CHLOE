using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class MainMenuButtonHandler : MonoBehaviour, IScrollHandler
{
    #region Variables
    /// <summary>
    /// The text attached to this gameobject's child.
    /// </summary>
    private TMP_Text textObject;

    /// <summary>
    /// Parent ScrollRect for objects in scroll view.
    /// </summary>
    [SerializeField] private ScrollRect scrollRect;
    #endregion

    #region Unity
    private void Start()
    {
        textObject = this.GetComponentInChildren<TMP_Text>();

        if (textObject == null)
        {
            Debug.LogError($"{this.gameObject} does not have a TMP_Text component.");
        }
    }
    #endregion

    #region Event Handlers
    /// <summary>
    /// Player enters hover on a button.
    /// </summary>
    public void OnButtonPointerEnter(BaseEventData eventData)
    {
        // Update current selection in event system.
        EventSystem.current.SetSelectedGameObject(this.gameObject);

        // Change the text color.
        this.textObject.color = Color.green;
    }

    /// <summary>
    /// Player selects the button.
    /// </summary>
    public void OnButtonSelect(BaseEventData eventData)
    {
        // Change the text color.
        this.textObject.color = Color.green;
    }

    /// <summary>
    /// Player deselects the button.
    /// </summary>
    public void OnButtonDeselect(BaseEventData eventData)
    {
        // Change the text color.
        this.textObject.color = Color.white;
    }

    /// <summary>
    /// Player exits hover on a button.
    /// </summary>
    public void OnButtonPointerExit(BaseEventData eventData)
    {
        // Change the text color.
        this.textObject.color = Color.white;
    }
    #endregion

    #region Scroll Handlers
    public void OnScroll(PointerEventData eventData)
    {
        if (this.scrollRect != null)
        {
            this.scrollRect.OnScroll(eventData);
        }
    }
    #endregion
}
