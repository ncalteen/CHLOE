using System.Collections.Generic;
using UnityEngine;
using Amazon.S3;
using System;

/// <summary>
/// S3 Bucket canned ACL data type.
/// https://docs.aws.amazon.com/sdkfornet/v3/apidocs/items/S3/TS3CannedACL.html
/// </summary>
[CreateAssetMenu(fileName = "S3CannedACLs", menuName = "AWS/List Source/S3/S3CannedACLs")]
[System.Serializable]
public class S3CannedACLs : ListSource, IListProperty<S3CannedACL>
{
    public override Type ItemType()
    {
        return typeof(S3CannedACL);
    }

    public List<S3CannedACL> Items()
    {
        return new List<S3CannedACL>()
        {
            S3CannedACL.AuthenticatedRead,
            S3CannedACL.AWSExecRead,
            S3CannedACL.BucketOwnerFullControl,
            S3CannedACL.BucketOwnerRead,
            S3CannedACL.LogDeliveryWrite,
            S3CannedACL.NoACL,
            S3CannedACL.Private,
            S3CannedACL.PublicRead,
            S3CannedACL.PublicReadWrite
        };
    }

    public S3CannedACL Default()
    {
        return S3CannedACL.Private;
    }

    public List<string> Options()
    {
        return new List<string>()
        {
            S3CannedACL.AuthenticatedRead,
            S3CannedACL.AWSExecRead,
            S3CannedACL.BucketOwnerFullControl,
            S3CannedACL.BucketOwnerRead,
            S3CannedACL.LogDeliveryWrite,
            S3CannedACL.NoACL,
            S3CannedACL.Private,
            S3CannedACL.PublicRead,
            S3CannedACL.PublicReadWrite
        };
    }
}
