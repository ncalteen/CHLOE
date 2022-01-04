using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Master controller for player and UI input.
/// Receives and routes input events as needed.
/// </summary>
[RequireComponent(typeof(PlayerInput))]
public class InputManager : Singleton<InputManager>
{
	#region Variables
	/// <summary>
	/// Player input component attached to Input Manager.
	/// </summary>
	[SerializeField] private PlayerInput playerInput;
    #endregion

    #region Properties
	public PlayerInput PlayerInput
    {
		get { return this.playerInput; }
    }
    #endregion

    #region Movement
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

	#region Interaction
	/// <summary>
	/// Player opens the services menu in game/simulation mode.
	/// </summary>
	/// <param name="context">
	///	Input context.
	/// </param>
	public void OnOpenServiceMenuEvent(InputAction.CallbackContext context)
    {
		// Only open when action is initiated.
		if (context.phase == InputActionPhase.Started)
        {
			InputBroker.Call_Input_OnOpenServiceMenuEvent(context);
		}
	}

	/// <summary>
	/// Player closes the services menu in game/simulation mode.
	/// </summary>
	/// <param name="context">
	///	Input context.
	/// </param>
	public void OnCloseServiceMenuEvent(InputAction.CallbackContext context)
	{
		// Only open when action is initiated.
		if (context.phase == InputActionPhase.Started)
		{
			InputBroker.Call_Input_OnCloseServiceMenuEvent(context);
		}
	}
	#endregion

	#region Input System Management
	public void TogglePlayerInputActionMap(string mapName)
    {
		this.playerInput.SwitchCurrentActionMap(mapName);
    }
    #endregion
}