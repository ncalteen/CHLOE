using System.Collections.Generic;

/// <summary>
/// Defines the contract that must be implemented for sources of AWS resource properties that are list types.
/// </summary>
public interface IListProperty<T>
{
    #region Methods
    /// <summary>
    /// Returns the list in their normal type.
    /// </summary>
    /// <returns></returns>
    public List<T> Items();

    /// <summary>
    /// Returns the default value as its normal type.
    /// </summary>
    public T Default();

    /// <summary>
    /// Returns the list of values as strings.
    /// </summary>
    public List<string> Options();
    #endregion
}
