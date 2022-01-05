using UnityEngine;

public class SimulationManager : Singleton<SimulationManager>
{
    #region Variables
    /// <summary>
    /// The ScriptableObject instance with the level data.
    /// </summary>
    [SerializeField] private LevelSO level;
    #endregion

    #region Properties
    public LevelSO Level
    {
        get { return this.level; }
    }
    #endregion
}
