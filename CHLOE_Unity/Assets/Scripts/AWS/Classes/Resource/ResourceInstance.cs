using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Defines an instance of a resource object.
/// This will contain the resource properties (PropertySO) and their values,
/// as well as any state information when it is launched.
/// </summary>
public class ResourceInstance : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// The ScriptableObject instance for this resource type.
    /// </summary>
    private ResourceSO resourceSO;

    /// <summary>
    /// The list of property values for this resource instance.
    /// </summary>
    private List<IPropertyValue> propertyValues = new List<IPropertyValue>();

    /// <summary>
    /// True if the resource has been created in AWS.
    /// </summary>
    private bool isLaunched = false;
    #endregion

    #region Properties
    public ResourceSO ResourceSO
    {
        get { return this.resourceSO; }
    }

    public List<IPropertyValue> PropertyValues
    {
        get { return this.propertyValues; }
    }

    public bool IsLaunched
    {
        get { return this.isLaunched; }
    }
    #endregion

    #region Constructors
    public void Initialize(ResourceSO resourceSO)
    {
        // Add this component to the resource GameObject
        this.resourceSO = resourceSO;

        // Populate property value list with supported properties for this resource.
        foreach (PropertySO propertySO in resourceSO.Properties)
        {
            IPropertyValue propertyValue;
            Debug.Log($"Prop: {propertySO.ShortName}");

            if (propertySO.PropertyType is PropertyTypes.SINGLE_LINE)
            {
                propertyValue = new PropertySingleLine();
            }
            else if (propertySO.PropertyType is PropertyTypes.MULTI_LINE)
            {
                propertyValue = new PropertyMultiLine();
            }
            else if (propertySO.PropertyType is PropertyTypes.BOOLEAN)
            {
                propertyValue = new PropertyBoolean();
            }
            else if (propertySO.PropertyType is PropertyTypes.SELECT_ONE)
            {
                var propertySelectType = typeof(PropertySelectOne<>);
                var specificType = propertySelectType.MakeGenericType(propertySO.GetListSource().ItemType());
                propertyValue = (IPropertyValue)Activator.CreateInstance(specificType);
            }
            else if (propertySO.PropertyType is PropertyTypes.SELECT_MANY)
            {
                var propertySelectType = typeof(PropertySelectMany<>);
                var specificType = propertySelectType.MakeGenericType(propertySO.GetListSource().ItemType());
                propertyValue = (IPropertyValue)Activator.CreateInstance(specificType);
            }
            else if (propertySO.PropertyType is PropertyTypes.NESTED)
            {
                var propertySelectType = typeof(PropertyNested<>);
                var specificType = propertySelectType.MakeGenericType(propertySO.GetListSource().ItemType());
                propertyValue = (IPropertyValue)Activator.CreateInstance(specificType);
            }
            else if (propertySO.PropertyType is PropertyTypes.EDITABLE_LIST)
            {
                var propertySelectOneType = typeof(PropertyEditableList<>);
                var specificType = propertySelectOneType.MakeGenericType(propertySO.GetNestedSource().ItemType());
                propertyValue = (IPropertyValue)Activator.CreateInstance(specificType);
            }
            else
            {
                Debug.LogError($"Unsupported property value type in resource setup: {propertySO.ShortName}");
                propertyValue = new PropertySingleLine();
            }

            propertyValue.Initialize(propertySO, this);
            this.propertyValues.Add(propertyValue);
        }
    }
    #endregion

    #region Unity
    #endregion
}
