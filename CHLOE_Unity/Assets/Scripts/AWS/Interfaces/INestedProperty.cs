using System.Collections.Generic;

/// <summary>
/// Defines the contract that must be implemented for sources of AWS resource properties that are nested types.
/// </summary>
public interface INestedProperty
{
    #region Methods
    /// <summary>
    /// Returns the list of properties that make up a single object.
    /// </summary>
    public List<PropertySO> Properties();
    #endregion
}
