using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Master controller for player and UI input.
/// Receives and routes input events as needed.
/// </summary>
public class InputManager : Singleton<InputManager>
{
	#region Event Handling
	/// <summary>
	///	Calculates movement.
	/// </summary>
	/// <param name="context">
	///	Input context.
	/// </param>
	public void OnMoveEvent(InputAction.CallbackContext context)
    {
		InputBroker.Call_Input_OnMoveEvent(context);
	}

	/// <summary>
	///	Calculates flight movement.
	/// </summary>
	/// <param name="context">
	///	Input context.
	/// </param>
	public void OnFlyEvent(InputAction.CallbackContext context)
	{
		InputBroker.Call_Input_OnFlyEvent(context);
	}

	/// <summary>
	///	Calculates camera/player rotation.
	/// </summary>
	/// <param name="context">
	///	Input context.
	/// </param>
	public void OnLookEvent(InputAction.CallbackContext context)
	{
		InputBroker.Call_Input_OnLookEvent(context);
	}
	#endregion
}