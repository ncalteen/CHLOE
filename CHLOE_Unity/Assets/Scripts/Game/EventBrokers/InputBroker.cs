using System;
using UnityEngine.InputSystem;

public class InputBroker : Singleton<InputBroker>
{
    #region Player Movement
    /// <summary>
    /// Handles movement inputs (WASD)
    /// </summary>
    public static event Action<InputAction.CallbackContext> Input_OnMoveEvent;
    public static void Call_Input_OnMoveEvent(InputAction.CallbackContext context)
    {
        Input_OnMoveEvent?.Invoke(context);
    }

    /// <summary>
    /// Handles flight inputs (QE)
    /// </summary>
    public static event Action<InputAction.CallbackContext> Input_OnFlyEvent;
    public static void Call_Input_OnFlyEvent(InputAction.CallbackContext context)
    {
        Input_OnFlyEvent?.Invoke(context);
    }

    /// <summary>
    /// Handles camera movement (MouseXY)
    /// </summary>
    public static event Action<InputAction.CallbackContext> Input_OnLookEvent;
    public static void Call_Input_OnLookEvent(InputAction.CallbackContext context)
    {
        Input_OnLookEvent?.Invoke(context);
    }
    #endregion
}
