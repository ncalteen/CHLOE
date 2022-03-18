using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PropertyEditableList<T> : IPropertyValue
{
    #region Variables
    /// <summary>
    /// The property ScriptableObject this refers to.
    /// </summary>
    private PropertySO propertySO;

    /// <summary>
    /// The value of this property.
    /// </summary>
    private List<T> value;

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

    public List<T> Value
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
        this.value = new List<T>();

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
        return $"{this.propertySO.ShortName} [List ({this.value.Count})]";
    }

    /// <summary>
    /// Configures the UI prefab instance with placeholder text, values, etc.
    /// </summary>
    public void SetupUIGO()
    {
        this.uiGO.GetComponentInChildren<TMP_Text>().text = this.ToString();

        if (this.PropertySO.UpdateType == UpdateTypes.REPLACE && this.resourceInstance.IsLaunched)
        {
            // Disable inputs for properties that cannot be changed (already launched resources only).
            this.uiGO.GetComponent<Button>().interactable = false;
        }
    }

    /// <summary>
    /// Clears the value of the property.
    /// </summary>
    public void Clear()
    {
        this.value = new List<T>();
    }
    #endregion
}
