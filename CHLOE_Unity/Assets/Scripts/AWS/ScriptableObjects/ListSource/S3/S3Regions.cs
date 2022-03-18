using System.Collections.Generic;
using UnityEngine;
using Amazon.S3;
using System;

/// <summary>
/// S3 Bucket region data type.
/// https://docs.aws.amazon.com/sdkfornet/v3/apidocs/items/S3/TS3Region.html
/// </summary>
[CreateAssetMenu(fileName = "S3Regions", menuName = "AWS/List Source/S3/S3Regions")]
[System.Serializable]
public class S3Regions : ListSource, IListProperty<S3Region>
{
    public override Type ItemType()
    {
        return typeof(S3Region);
    }

    public List<S3Region> Items()
    {
        return new List<S3Region>()
        {
            S3Region.AFSouth1,
            S3Region.APEast1,
            S3Region.APNortheast1,
            S3Region.APNortheast2,
            S3Region.APNortheast3,
            S3Region.APSouth1,
            S3Region.APSoutheast1,
            S3Region.APSoutheast2,
            S3Region.CACentral1,
            S3Region.CNNorth1,
            S3Region.CNNorthWest1,
            S3Region.EUCentral1,
            S3Region.EUNorth1,
            S3Region.EUSouth1,
            S3Region.EUWest1,
            S3Region.EUWest2,
            S3Region.EUWest3,
            S3Region.MESouth1,
            S3Region.SAEast1,
            S3Region.USEast1,
            S3Region.USEast2,
            //S3Region.USGovCloudEast1, // Not supporting initially
            //S3Region.USGovCloudWest1, // Not supporting initially
            //S3Region.USIsobEast1, // Not supporting initially
            //S3Region.USIsoEast1, // Not supporting initially
            //S3Region.USIsoWest1, // Not supporting initially
            S3Region.USWest1,
            S3Region.USWest2
        };
    }

    public S3Region Default()
    {
        return S3Region.USEast1;
    }

    public List<string> Options()
    {
        return new List<string>()
        {
            S3Region.AFSouth1,
            S3Region.APEast1,
            S3Region.APNortheast1,
            S3Region.APNortheast2,
            S3Region.APNortheast3,
            S3Region.APSouth1,
            S3Region.APSoutheast1,
            S3Region.APSoutheast2,
            S3Region.CACentral1,
            S3Region.CNNorth1,
            S3Region.CNNorthWest1,
            S3Region.EUCentral1,
            S3Region.EUNorth1,
            S3Region.EUSouth1,
            S3Region.EUWest1,
            S3Region.EUWest2,
            S3Region.EUWest3,
            S3Region.MESouth1,
            S3Region.SAEast1,
            S3Region.USEast1,
            S3Region.USEast2,
            //S3Region.USGovCloudEast1, // Not supporting initially
            //S3Region.USGovCloudWest1, // Not supporting initially
            //S3Region.USIsobEast1, // Not supporting initially
            //S3Region.USIsoEast1, // Not supporting initially
            //S3Region.USIsoWest1, // Not supporting initially
            S3Region.USWest1,
            S3Region.USWest2
        };
    }
}
