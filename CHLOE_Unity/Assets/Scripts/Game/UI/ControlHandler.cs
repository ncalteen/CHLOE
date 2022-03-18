using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class ControlHandler : MonoBehaviour, IScrollHandler
{
    #region Variables
    /// <summary>
    /// The text attached to this gameobject's child.
    /// </summary>
    [SerializeField] private TMP_Text textObject;

    /// <summary>
    /// Parent ScrollRect for objects in scroll view.
    /// </summary>
    [SerializeField] private ScrollRect scrollRect;

    /// <summary>
    /// Dropdown menu to select AWS profile.
    /// </summary>
    [SerializeField] private TMP_Dropdown dropdown;
    #endregion

    #region Unity
    private void Start()
    {
        UIBroker.Button_Selected += OnButtonSelectedEvent;
    }

    private void OnDisable()
    {
        UIBroker.Button_Selected -= OnButtonSelectedEvent;

        // Change the text color.
        this.textObject.color = Color.white;
    }
    #endregion

    #region Event Handlers
    /// <summary>
    /// Player enters hover on a control.
    /// </summary>
    public void OnPointerEnter(BaseEventData eventData)
    {
        // Unselect everything else.
        UIBroker.Call_Button_Selected();

        // Update current selection in event system.
        EventSystem.current.SetSelectedGameObject(this.gameObject);

        // Change the text color.
        this.textObject.color = Color.green;
    }

    /// <summary>
    /// Player selects the control.
    /// </summary>
    public void OnSelect(BaseEventData eventData)
    {
        // Unselect everything else.
        UIBroker.Call_Button_Selected();

        // Change the text color.
        this.textObject.color = Color.green;
    }

    /// <summary>
    /// Player deselects the control.
    /// </summary>
    public void OnDeselect(BaseEventData eventData)
    {
        // Change the text color.
        this.textObject.color = Color.white;
    }

    /// <summary>
    /// Player exits hover on a control.
    /// </summary>
    public void OnPointerExit(BaseEventData eventData)
    {
        // Change the text color.
        this.textObject.color = Color.white;
    }

    /// <summary>
    /// Changes button color when another button is selected.
    /// </summary>
    public void OnButtonSelectedEvent()
    {
        // Change the text color.
        this.textObject.color = Color.white;
    }
    #endregion

    #region ScrollRect Handlers
    /// <summary>
    /// Pass scroll event to parent scrollrect.
    /// </summary>
    public void OnScroll(PointerEventData eventData)
    {
        if (this.scrollRect != null)
        {
            this.scrollRect.OnScroll(eventData);
        }
    }
    #endregion

    #region Dropdown Handlers
    /// <summary>
    /// Open/close the dropdown menu.
    /// </summary>
    public void OnDropdownSubmit(BaseEventData eventData)
    {
        EventSystem.current.SetSelectedGameObject(this.dropdown.gameObject);
        if (this.dropdown.IsExpanded)
        {
            this.dropdown.Hide();
        }
        else
        {
            this.dropdown.Show();
        }
    }
    #endregion
}
