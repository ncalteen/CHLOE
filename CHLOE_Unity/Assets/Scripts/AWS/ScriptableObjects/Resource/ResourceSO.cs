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

    public string ShortName;
    
    public string LongName;

    [TextArea(10, 100)]
    public string Description;

    public ServiceSO ServiceInstance;

    public List<PropertySO> PropertyInstances;
    #endregion
}
