using UnityEngine;

public interface IPropertyValue
{
    #region Properties
    /// <summary>
    /// The PropertySO this value refers to.
    /// </summary>
    public PropertySO PropertySO { get; }

    public GameObject UIGO { get; set; }
    #endregion

    #region Methods
    /// <summary>
    /// Returns a string representation of the value.
    /// </summary>
    /// <returns>
    /// A string representation of the value.
    /// </returns>
    public string ToString();

    /// <summary>
    /// Configures the UI prefab instance with placeholder text, values, etc.
    /// </summary>
    public void SetupUIGO();

    /// <summary>
    /// Clears the value of the property.
    /// </summary>
    public void Clear();

    /// <summary>
    /// Initializes the property with a default value.
    /// </summary>
    /// <param name="propertySO">
    /// The property Scriptable object for this value.
    /// </param>
    /// <param name="resourceInstance">
    /// The resource instance for this value.
    /// </param>
    public void Initialize(PropertySO propertySO, ResourceInstance resourceInstance);
    #endregion
}
