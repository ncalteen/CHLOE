using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Defines the core properties of an AWS service.
/// </summary>
[CreateAssetMenu(fileName = "Service", menuName = "AWS/Service")]
[System.Serializable]
public class ServiceSO : ScriptableObject
{
    #region Variables
    /// <summary>
    /// The ID as used in the SDK.
    /// I.E. 'S3' for S3, or 'APIGateway' for API Gateway.
    /// Ref: https://docs.aws.amazon.com/sdkfornet/v3/apidocs/
    /// </summary>
    public string ID;

    public string ShortName;
    
    public string LongName;

    // Select from list here: https://aws.amazon.com/products/?aws-products-all
    public ServiceCategoryTypes Category;

    [TextArea(10, 100)]
    public string Description;

    public List<ResourceSO> ResourceInstances;
    #endregion
}
