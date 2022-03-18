using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Defines the core properties of an AWS resource.
/// </summary>
[CreateAssetMenu(fileName = "Resource", menuName = "AWS/Resource")]
[System.Serializable]
public class ResourceSO : ScriptableObject
{
    #region Variables
    /// <summary>
    /// The ID as used in the SDK.
    /// I.E. 'Bucket' for S3 Bucket.
    /// Ref: https://docs.aws.amazon.com/sdkfornet/v3/apidocs/
    /// </summary>
    public string ID;

    /// <summary>
    /// The subsequent use name.
    /// </summary>
    public string ShortName;
    
    /// <summary>
    /// The first use name.
    /// </summary>
    public string LongName;

    /// <summary>
    /// The description of the resource.
    /// </summary>
    [TextArea(10, 100)]
    public string Description;

    /// <summary>
    /// The service this resource belongs to.
    /// </summary>
    public ServiceSO Service;

    /// <summary>
    /// The properties that define this resource.
    /// </summary>
    public List<PropertySO> Properties;

    /// <summary>
    /// The prefab to instantiate.
    /// </summary>
    public GameObject ResourcePrefab;
    #endregion
}
