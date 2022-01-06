using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Game/Level")]
public class LevelSO : ScriptableObject
{
    #region Variables
    /// <summary>
    /// Level number/ID.
    /// </summary>
    [SerializeField] private int levelID;

    /// <summary>
    /// Level name.
    /// </summary>
    [SerializeField] private string levelName;

    /// <summary>
    /// Scene name to load.
    /// </summary>
    [SerializeField] private string sceneName;

    /// <summary>
    /// Level description.
    /// </summary>
    [TextArea(10, 100)]
    [SerializeField] private string description;

    /// <summary>
    /// Supported AWS services in this level.
    /// </summary>
    [SerializeField] private List<ServiceSO> awsServices;
    #endregion

    #region Properties
    public int ID
    {
        get { return this.levelID; }
    }

    public string Name
    {
        get { return this.levelName; }
    }

    public string SceneName
    {
        get { return this.sceneName; }
    }

    public string Description
    {
        get { return this.description; }
    }

    public List<ServiceSO> AWSServices
    {
        get { return this.awsServices; }
    }
    #endregion
}
