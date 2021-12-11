using System.Collections.Generic;
using UnityEngine;
using Amazon.S3;

/// <summary>
/// S3 grant permissions data type
/// https://docs.aws.amazon.com/sdkfornet/v3/apidocs/items/S3/TS3Permission.html
/// </summary>
[CreateAssetMenu(fileName = "S3Permissions", menuName = "AWS/List Source/S3/S3Permissions")]
[System.Serializable]
public class S3Permissions : ListSource, IListProperty<S3Permission>
{
    public List<S3Permission> Items()
    {
        return new List<S3Permission>()
        {
            S3Permission.FULL_CONTROL,
            S3Permission.READ,
            S3Permission.READ_ACP,
            S3Permission.RESTORE_OBJECT,
            S3Permission.WRITE,
            S3Permission.WRITE_ACP
        };
    }

    public S3Permission Default()
    {
        return S3Permission.FULL_CONTROL;
    }

    public List<string> Options()
    {
        List<string> items = new List<string>();

        foreach (S3Permission item in Items())
        {
            items.Add(item.ToString());
        }

        return items;
    }
}