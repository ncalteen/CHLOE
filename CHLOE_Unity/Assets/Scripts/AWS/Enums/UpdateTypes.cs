/// <summary>
/// The type of action that will occur on the resource if this property is updated.
/// </summary>
public enum UpdateTypes
{
    /// <summary>
    /// Update without interruption.
    /// Physical ID won't change.
    /// </summary>
    NO_INTERRUPT,

    /// <summary>
    /// Update with interruption.
    /// Physical ID won't change.
    /// </summary>
    INTERRUPT,

    /// <summary>
    /// Update with interruption.
    /// Physical ID will change.
    /// </summary>
    REPLACE
}
