using UnityEngine;

/// <summary>
/// Ensures that any class inheriting this class can only have one running instance.
/// </summary>
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    #region Variables
    /// <summary>
    /// Instance of the singleton for accessing non-static methods/properties.
    /// </summary>
    private static T instance;
    #endregion

    #region Properties
    public static T Instance
    {
        get { return instance; }
        set { instance = value; }
    }
    #endregion

    #region Unity
    /// <summary>
    /// Creates a new instance if none exists.
    /// </summary>
    protected virtual void Awake()
    {
        if (instance != null)
            Debug.LogError("[Singleton] Trying to instantiate second instance of singleton class!");
        else
            instance = (T)this;
    }

    /// <summary>
    /// Removes reference to instance if it exists.
    /// </summary>
    protected virtual void OnDestroy()
    {
        if (instance == this)
            instance = null;
    }
    #endregion
}