using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

/// <summary>
/// Defines the core properties of an AWS service.
/// </summary>
[CreateAssetMenu(fileName = "Property", menuName = "AWS/Property")]
public class PropertySO : ScriptableObject
{
    #region Variables
    /// <summary>
    /// The ID as used in the SDK.
    /// I.E. 'BucketName' for S3 Bucket name.
    /// Ref: https://docs.aws.amazon.com/sdkfornet/v3/apidocs/
    /// </summary>
    public string ID;

    public string ShortName;

    public string LongName;

    [TextArea(10, 100)]
    public string Description;

    public ResourceSO ResourceInstance;

    public bool Required;

    public PropertyTypes PropertyType;

    public UpdateTypes UpdateType;

    /// <summary>
    /// Only used when the property type is SELECT_ONE, SELECT_MANY
    /// </summary>
    private ListSource ListSource;

    /// <summary>
    /// Only used when the property type is EDITABLE_LIST or NESTED
    /// </summary>
    private NestedSource NestedSource;
    #endregion

    #region Helper Methods
    public ListSource GetListSource()
    {
        return this.ListSource;
    }

    public NestedSource GetNestedSource()
    {
        return this.NestedSource;
    }
    #endregion

    #region Unity Editor
    /// <summary>
    /// Disables the list source input when other input options are selected.
    /// </summary>
    public void OnPropertyTypeChange()
    {
        // Any of the following types support a list of values.
        bool disableListSource = this.PropertyType != PropertyTypes.SELECT_ONE && this.PropertyType != PropertyTypes.SELECT_MANY;

        using (new EditorGUI.DisabledScope(disableListSource))
        {
            ListSource = (ListSource)EditorGUILayout.ObjectField(label: "List Source", obj: this.ListSource, typeof(ListSource), allowSceneObjects: false);
        }

        bool disableNestedSource = this.PropertyType != PropertyTypes.EDITABLE_LIST;

        using (new EditorGUI.DisabledScope(disableNestedSource))
        {
            NestedSource = (NestedSource)EditorGUILayout.ObjectField(label: "Object Source", obj: this.NestedSource, typeof(NestedSource), allowSceneObjects: false);
        }
    }
    #endregion
}

[CustomEditor(typeof(PropertySO))]
public class PropertySOEditor : Editor
{
    SerializedProperty listSource;

    private void OnEnable()
    {
        //listSource = serializedObject.FindProperty("ListSource");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        DrawDefaultInspector();

        PropertySO property = (PropertySO)serializedObject.targetObject;
        property.OnPropertyTypeChange();

        EditorUtility.SetDirty(serializedObject.targetObject);
        serializedObject.ApplyModifiedProperties();
    }
}
