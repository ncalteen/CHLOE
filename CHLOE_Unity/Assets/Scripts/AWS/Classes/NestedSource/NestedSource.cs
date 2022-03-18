using UnityEngine;
using System;

/// <summary>
/// Dummy class used for upclass/downclass operations.
/// </summary>
public abstract class NestedSource : ScriptableObject
{
    /// <summary>
    /// Get the type of the nested items.
    /// </summary>
    /// <returns>
    /// The type of the nested items.
    /// </returns>
    public abstract Type ItemType();
}
