using UnityEngine;
using System;

/// <summary>
/// Dummy class used for upclass/downclass operations.
/// </summary>
public abstract class ListSource : ScriptableObject
{
    /// <summary>
    /// Get the type of the list items.
    /// </summary>
    /// <returns>
    /// The type of the list items.
    /// </returns>
    public abstract Type ItemType();
}
