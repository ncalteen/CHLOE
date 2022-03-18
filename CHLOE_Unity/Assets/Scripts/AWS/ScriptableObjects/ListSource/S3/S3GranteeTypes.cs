using System.Collections.Generic;
using UnityEngine;
using Amazon.S3;
using System;

/// <summary>
/// S3 grant grantee data type.
/// https://docs.aws.amazon.com/sdkfornet/v3/apidocs/items/S3/TGranteeType.html
/// </summary>
[CreateAssetMenu(fileName = "S3GranteeTypes", menuName = "AWS/List Source/S3/S3GranteeTypes")]
[System.Serializable]
public class S3GranteeTypes : ListSource, IListProperty<GranteeType>
{
    public override Type ItemType()
    {
        return typeof(GranteeType);
    }

    public List<GranteeType> Items()
    {
        return new List<GranteeType>()
        {
            GranteeType.CanonicalUser,
            GranteeType.Email,
            GranteeType.Group
        };
    }

    public GranteeType Default()
    {
        return GranteeType.Email;
    }

    public List<string> Options()
    {
        return new List<string>()
        {
            GranteeType.CanonicalUser,
            GranteeType.Email,
            GranteeType.Group
        };
    }
}
