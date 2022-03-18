using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AWSResourceManager : Singleton<AWSResourceManager>
{
    #region Variables
    /// <summary>
    /// Player resource anchor point.
    /// </summary>
    [SerializeField] private Transform playerResourceAnchor;
    #endregion

    #region Unity
    /// <summary>
    /// Sets up the scene for resource management.
    /// </summary>
    void Start()
    {
        // Subscribe to events.
        AWSBroker.AWS_OnCreateResourceEvent += CreateResourceEvent;
    }

    private void OnDisable()
    {
        // Unsubscribe from events.
        AWSBroker.AWS_OnCreateResourceEvent -= CreateResourceEvent;
    }
    #endregion

    #region Event Handling
    /// <summary>
    /// Creates a GameObject for the resource the player selected from the service menu.
    /// </summary>
    /// <param name="resource">
    /// ResourceSO ScriptableObject instance for the resource.
    /// </param>
    public void CreateResourceEvent(ResourceSO resource)
    {
        // Destroy any resource(s) the player is currently holding.
        for (int i = this.playerResourceAnchor.childCount; i > 0; i--)
        {
            Destroy(this.playerResourceAnchor.GetChild(i - 1).gameObject);
        }

        // Create a resource GameObject, with player holding it.
        GameObject resourceObj = Instantiate(original: resource.ResourcePrefab, parent: this.playerResourceAnchor);

        // Add resource information to the GameObject.
        ResourceInstance resourceInstance = resourceObj.AddComponent<ResourceInstance>();
        resourceInstance.Initialize(resource);
    }
    #endregion
}
