/// <summary>
/// The type of input supported by this property.
/// </summary>
public enum PropertyTypes
{
    /// <summary>
    /// Single line text entry.
    /// </summary>
    SINGLE_LINE,

    /// <summary>
    /// Multi-line text entry.
    /// </summary>
    MULTI_LINE,

    /// <summary>
    /// True/false value.
    /// </summary>
    BOOLEAN,

    /// <summary>
    /// Select one item from a list.
    /// </summary>
    SELECT_ONE,

    /// <summary>
    /// Select one or more items from a list.
    /// </summary>
    SELECT_MANY,

    /// <summary>
    /// Object with nested sub-properties.
    /// </summary>
    NESTED,

    /// <summary>
    /// Add, edit, delete items from a list.
    /// List is composed of single or nested items.
    /// </summary>
    EDITABLE_LIST
}
