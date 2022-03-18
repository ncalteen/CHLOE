using TMPro;
using UnityEngine;

public class PropertyMultiLine : IPropertyValue
{
    #region Variables
    /// <summary>
    /// The property ScriptableObject this refers to.
    /// </summary>
    private PropertySO propertySO;

    /// <summary>
    /// The value of this property.
    /// </summary>
    private string value;

    /// <summary>
    /// The parent resource instance.
    /// </summary>
    private ResourceInstance resourceInstance;

    /// <summary>
    /// The UI GameObject instance.
    /// </summary>
    private GameObject uiGO;
    #endregion

    #region Properties
    public PropertySO PropertySO
    {
        get { return this.propertySO; }
    }

    public string Value
    {
        get { return this.value; }
        set { this.value = value; }
    }

    public GameObject UIGO
    {
        get { return this.uiGO; }
        set { this.uiGO = value; }
    }
    #endregion

    #region Constructors
    /// <summary>
    /// Initialize with a default value.
    /// </summary>
    /// <param name="propertySO">
    /// Corresponding PropertySO ScriptableObject.
    /// </param>
    /// <param name="resourceInstance">
    /// The resource instance this refers to.
    /// </param>
    public void Initialize(PropertySO propertySO, ResourceInstance resourceInstance)
    {
        // Set the resource property this corresponds to.
        this.propertySO = propertySO;

        // Set the value to null.
        this.value = null;

        // Set parent resource.
        this.resourceInstance = resourceInstance;
    }
    #endregion

    #region Helper Functions
    /// <summary>
    /// Create a string representation of this value.
    /// </summary>
    /// <returns>
    /// String of the value.
    /// </returns>
    public override string ToString()
    {
        return this.value;
    }

    /// <summary>
    /// Configures the UI prefab instance with placeholder text, values, etc.
    /// </summary>
    public void SetupUIGO()
    {
        TMP_InputField inputField = this.uiGO.GetComponent<TMP_InputField>();

        if (this.value != null)
        {
            // Set input field to current value.
            inputField.text = this.value;
        }
        else
        {
            // Change placeholder to short name.
            inputField.placeholder.GetComponent<TMP_Text>().text = this.PropertySO.ShortName;
        }

        if (this.PropertySO.UpdateType == UpdateTypes.REPLACE && this.resourceInstance.IsLaunched)
        {
            // Property requires replacement to update.
            // Disable input modification.
            inputField.enabled = false;
        }
    }

    /// <summary>
    /// Clears the value of the property.
    /// </summary>
    public void Clear()
    {
        this.value = null;
    }
    #endregion
}
