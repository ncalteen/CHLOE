using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Master controller for player.
/// </summary>
public class PlayerController : Singleton<PlayerController>
{
    #region Variables
    /// <summary>
    /// Controller attached to the player.
    /// </summary>
    [SerializeField] private CharacterController characterController;

    /// <summary>
    /// The main player camera.
    /// </summary>
    [SerializeField] private Camera mainCamera;

    /// <summary>
    /// The camera used for view filters.
    /// </summary>
    [SerializeField] private Camera filterCamera;

	/// <summary>
	/// Controls if flight is enabled in-game.
	/// </summary>
	[SerializeField] private bool isFlightEnabled = true;

	/// <summary>
	/// Controls if movement is enabled in-game.
	/// </summary>
	[SerializeField] private bool isMovementEnabled = true;

    /// <summary>
	/// Anchor for camera pivot point.
	/// </summary>
	[SerializeField] private Transform cameraPivotTransform;

	/// <summary>
	/// Anchor for a resource held by the player.
	/// </summary>
	[SerializeField] private Transform resourceAnchorTransform;

	/// <summary>
	/// Parent GameObject of resources in the scene.
	/// </summary>
	[SerializeField] private Transform resourceCollectionTransform;

	/// <summary>
	/// CHLOE GameObject transform.
	/// </summary>
	[SerializeField] private Transform chloeTransform;

	/// <summary>
	/// Stores movement for calculation.
	/// </summary>
	private Vector3 moveDirection = Vector3.zero;

	/// <summary>
	/// Stores current movement inputs. Fixes camera preventing player from turning.
	/// </summary>
	private Vector3 currentMoveInputs = Vector3.zero;

	/// <summary>
	/// The amount to clamp camera movement.
	/// </summary>
	private Vector2 cameraClampInDegrees = new Vector2(360, 180);

	/// <summary>
	/// Smoothing value.
	/// </summary>
	private Vector2 smoothing = new Vector2(3, 3);

	/// <summary>
	/// Temp variable to smooth player rotation.
	/// </summary>
	private float playerSmoothingY = 0f;

	/// <summary>
	/// Temp variable to smooth camera rotation.
	/// </summary>
	private float cameraSmoothingX = 0f;

	/// <summary>
	/// Temp variable to store absolute position change for camera.
	/// </summary>
	private Vector2 cameraAbsolute = Vector2.zero;

	/// <summary>
	/// Temp variable to store absolute position change for player.
	/// </summary>
	private Vector2 playerAbsolute = Vector2.zero;
	#endregion

	#region Properties
	public Transform HeldResource
	{
		get
		{
			if (this.resourceAnchorTransform.childCount != 0)
				return this.resourceAnchorTransform.GetChild(0);
			else
				return null;
		}
	}

	public bool IsHoldingResource
	{
		get { return this.resourceAnchorTransform.childCount != 0; }
	}

	public Camera MainCamera
	{
		get { return this.mainCamera; }
	}

	public Camera FilterCamera
	{
		get { return this.filterCamera; }
	}

	public Transform ResourceCollectionTransform
	{
		get { return this.resourceCollectionTransform; }
	}

	public bool IsFlightEnabled
	{
		get { return this.isFlightEnabled; }
		set { this.isFlightEnabled = value; }
	}

	public bool IsMovementEnabled
	{
		get { return this.isMovementEnabled; }
		set { this.isMovementEnabled = value; }
	}
	#endregion

	#region Unity
	/// <summary>
	/// Sets up the player controller.
	/// </summary>
	private void Start()
    {
		// Register with InputBroker.
		InputBroker.Input_OnFlyEvent += OnFlyEvent;
		InputBroker.Input_OnLookEvent += OnLookEvent;
		InputBroker.Input_OnMoveEvent += OnMoveEvent;
    }

	private void OnDisable()
    {
		// Deregister with InputBroker.
		InputBroker.Input_OnFlyEvent -= OnFlyEvent;
		InputBroker.Input_OnLookEvent -= OnLookEvent;
		InputBroker.Input_OnMoveEvent -= OnMoveEvent;
	}

	/// <summary>
	/// Called every fixed frame-rate frame.
	/// Mainly for physics-related updates.
	/// </summary>
	private void FixedUpdate()
	{
		if (this.IsMovementEnabled)
		{
			MovePlayer();
		}
	}

	/// <summary>
	/// Called after all other Update functions.
	/// </summary>
	private void LateUpdate()
    {
		MoveCamera();
    }
	#endregion

	#region InputSystem
	/// <summary>
	///	Calculates movement.
	/// </summary>
	/// <param name="context">
	///	Input context.
	/// </param>
	public void OnMoveEvent(InputAction.CallbackContext context)
    {
		Vector2 input = context.ReadValue<Vector2>();

		// Store new movement values
		// input.y = local.z
		// input.x = local.x
		this.currentMoveInputs.z = input.y;
		this.currentMoveInputs.x = input.x;
	}

	/// <summary>
	///	Calculates flight movement.
	/// </summary>
	/// <param name="context">
	///	Input context.
	/// </param>
	public void OnFlyEvent(InputAction.CallbackContext context)
	{
		if (this.isFlightEnabled)
        {
			float input = context.ReadValue<float>();
			this.currentMoveInputs.y = input;
			this.moveDirection.y = input;
        }
	}

	/// <summary>
	///	Calculates camera/player rotation.
	/// </summary>
	/// <param name="context">
	///	Input context.
	/// </param>
	public void OnLookEvent(InputAction.CallbackContext context)
	{
		Vector2 mouseDelta = Vector2.Scale(context.ReadValue<Vector2>(), new Vector2(PlayerSettings.Instance.CameraSensitivity, PlayerSettings.Instance.CameraSensitivity));

		// Interpolate mouse movement over time to apply smoothing delta.
		this.playerSmoothingY = Mathf.Lerp(this.playerSmoothingY, mouseDelta.x, 1f / smoothing.x);
		this.cameraSmoothingX = Mathf.Lerp(this.cameraSmoothingX, mouseDelta.y, 1f / smoothing.y);

		// Find the absolute mouse movement value from point zero.
		this.cameraAbsolute.x += this.cameraSmoothingX;
		this.playerAbsolute.y += this.playerSmoothingY;

		// Clamp and apply the local x value first, so as not to be affected by world transforms.
		if (this.cameraClampInDegrees.y < 360)
			this.cameraAbsolute.x = Mathf.Clamp(this.cameraAbsolute.x, -1 * this.cameraClampInDegrees.y * 0.5f, this.cameraClampInDegrees.y * 0.5f);
	}
	#endregion

	#region Player Movement
	/// <summary>
	///	Moves player transform based on this.moveDirection.
	/// </summary>
	private void MovePlayer()
	{
		this.moveDirection = mainCamera.transform.forward * this.currentMoveInputs.z + mainCamera.transform.right * this.currentMoveInputs.x + mainCamera.transform.up * this.currentMoveInputs.y;

		if (!this.isFlightEnabled)
        {
			this.moveDirection.z = 0f;
        }

		this.characterController.Move(this.moveDirection * PlayerSettings.Instance.MoveSpeed * Time.deltaTime);
	}

	/// <summary>
	/// Rotates the camera and player.
	/// </summary>
	private void MoveCamera()
    {
		this.cameraPivotTransform.localRotation = Quaternion.AngleAxis(-1 * this.cameraAbsolute.x, Vector3.right);

		Quaternion yRotation = Quaternion.AngleAxis(this.playerAbsolute.y, Vector3.up);
		this.transform.localRotation = yRotation;
	}
	#endregion
}