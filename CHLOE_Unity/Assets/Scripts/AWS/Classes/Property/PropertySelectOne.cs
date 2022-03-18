using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class PropertySelectOne<T> : IPropertyValue
{
    #region Variables
    /// <summary>
    /// The property ScriptableObject this refers to.
    /// </summary>
    private PropertySO propertySO;

    /// <summary>
    /// The value of this property.
    /// </summary>
    private T value;

    /// <summary>
    /// The index of the selected value in the dropdown list.
    /// </summary>
    private int index = -1;

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

    public T Value
    {
        get { return this.value; }
        set {
            this.value = value;
            this.index = ((IListProperty<T>)propertySO.GetListSource()).Options().IndexOf(this.value.ToString());
        }
    }

    public GameObject UIGO
    {
        get { return this.uiGO; }
        set { this.uiGO = value; }
    }
    #endregion

    #region Constructors
    /// <summary>
    /// Initializes the property with a default value.
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

        // Set the value to default.
        this.value = ((IListProperty<T>)propertySO.GetListSource()).Default();
        this.index = ((IListProperty<T>)propertySO.GetListSource()).Options().IndexOf(this.value.ToString());

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
        if (this.value != null)
        {
            return this.value.ToString();
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// Configures the UI prefab instance with placeholder text, values, etc.
    /// </summary>
    public void SetupUIGO()
    {
        // Get the drop down menu.
        TMP_Dropdown dropdown = this.uiGO.GetComponent<TMP_Dropdown>();

        // Clear any previous options.
        dropdown.ClearOptions();

        // Create list of available options.
        List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();
        foreach (string item in ((IListProperty<T>)propertySO.GetListSource()).Options())
        {
            // Add the items to the drop down list.
            options.Add(new TMP_Dropdown.OptionData(text: item));
        }

        // Update UI control.
        dropdown.AddOptions(options: options);

        if (this.value != null)
        {
            dropdown.value = this.index;
        }
        else
        {
            // Set placeholder.
            dropdown.placeholder.GetComponent<TMP_Text>().text = this.propertySO.ShortName;
        }

        if (this.propertySO.UpdateType == UpdateTypes.REPLACE && this.resourceInstance.IsLaunched)
        {
            // Disable inputs for properties that cannot be changed (already launched resources).
            dropdown.enabled = false;
        }
    }

    /// <summary>
    /// Clears the value of the property.
    /// </summary>
    public void Clear()
    {
        this.value = ((IListProperty<T>)propertySO.GetListSource()).Default();
    }
    #endregion
}
