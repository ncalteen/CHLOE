using System.Collections.Generic;
using UnityEngine;
using Amazon.S3;
using System;

/// <summary>
/// S3 grant complex data type.
/// https://docs.aws.amazon.com/sdkfornet/v3/apidocs/items/S3/TS3Grant.html
/// </summary>
[CreateAssetMenu(fileName = "S3Grant", menuName = "AWS/Nested Source/S3/S3Grant")]
[System.Serializable]
public class S3Grant : NestedSource, INestedProperty
{
    public PropertySO Grantee;
    public PropertySO GranteeType;
    public PropertySO Permissions;

    public override Type ItemType()
    {
        return typeof(List<PropertySO>);
    }

    public List<PropertySO> Properties()
    {
        List<PropertySO> properties = new List<PropertySO>()
        {
            Grantee,
            GranteeType,
            Permissions
        };

        return properties;
    }
}
