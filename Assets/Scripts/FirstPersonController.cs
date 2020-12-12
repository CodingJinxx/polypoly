using System;
using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonController : NetworkBehaviour, PlayerInput.IFirstPersonPlayerActions
{
    // Unity Game Object References
    [SerializeField]
    private Rigidbody PlayerRigidbody;
    [SerializeField]
    private Camera PlayerCamera;
    [SerializeField]
    private Collider PlayerCollider;
    public GameObject CameraMountPoint;

    private PlayerInput controls;

    // Sensitivites and Speeds
    [SerializeField]
    public float MovementSpeed = 0.5f;
    [SerializeField]
    public float LookSpeed = 0.5f;
    [SerializeField]
    public float JumpStrength = 0.5f;

    // Timespeeds
    [SerializeField]
    private float MovementTime = 5.0f;
    [SerializeField]
    private float LookTime = 5.0f;

    // Differential positions and rotations
    private Vector3 d_player_pos;
    private Quaternion d_player_rot;
    // Future positions and rotations
    private Vector3 f_camera_pos;
    private Quaternion f_camera_rot;

    // Buffer Input Variables
    private Vector2 b_look;
    private Vector2 b_movement;
    private event Action b_fire;
    private event Action b_jump;

    private void OnEnable()
    {
        if (controls is null)
        {
            controls = new PlayerInput();
        }
        controls.Enable();
        controls.FirstPersonPlayer.Enable();
        controls.FirstPersonPlayer.SetCallbacks(this);
    }

    private void OnDisable()
    {
        controls.Disable();
        controls.FirstPersonPlayer.Disable();
    }

    private void Start()
    {
        PlayerCamera = Camera.main;
        if (isLocalPlayer)
        {
            Transform cameraTransform = Camera.main.gameObject.transform;
            cameraTransform.parent = CameraMountPoint.transform;
            cameraTransform.position = CameraMountPoint.transform.position;
            cameraTransform.rotation = CameraMountPoint.transform.rotation;
        }

        this.d_player_pos = PlayerRigidbody.transform.localPosition;
        this.d_player_rot = PlayerRigidbody.transform.localRotation;
        this.f_camera_pos = PlayerCamera.transform.localPosition;
        this.f_camera_rot = PlayerCamera.transform.localRotation;
        this.b_jump += Jump;

        // Hide Cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        if (isLocalPlayer)
        {
            FutureUpdate();
            
            //PlayerCamera.transform.localPosition = Vector3.Lerp(PlayerCamera.transform.position, this.f_player_pos, Time.deltaTime * this.MovementTime);
            PlayerCamera.transform.localRotation = Quaternion.Lerp(PlayerCamera.transform.localRotation,
                this.f_camera_rot, Time.deltaTime * this.LookTime);

            PlayerRigidbody.MovePosition(Vector3.Lerp(PlayerRigidbody.transform.localPosition,
                PlayerRigidbody.transform.localPosition + d_player_pos, Time.deltaTime * this.MovementTime));
            PlayerRigidbody.MoveRotation(Quaternion.Lerp(PlayerRigidbody.transform.localRotation,
                PlayerRigidbody.transform.localRotation * d_player_rot, Time.deltaTime * this.LookTime));
        }
    }

    private void FutureUpdate()
    {
        // Look
            Vector3 YRotation = new Vector3(0, b_look.x * LookSpeed, 0);
            d_player_rot = Quaternion.Euler(YRotation);

            Vector3 XRotation = new Vector3(-b_look.y * LookSpeed, 0, 0);
            f_camera_rot *= Quaternion.Euler(XRotation);
            f_camera_rot = clampRotationAroundXAxis(f_camera_rot, -90.0f, 90.0f);

            // Movement
            Vector3 Forward = (PlayerRigidbody.rotation * Vector3.forward);
            Vector3 Right = (PlayerRigidbody.rotation * Vector3.right);
            Vector2 Velocity = b_movement * MovementSpeed;
            d_player_pos = Velocity.x * Right + Velocity.y * Forward;
    }

    private void Jump(){
        if (isLocalPlayer)
        {
            if (IsGrounded())
                PlayerRigidbody.AddForce(Vector3.up * JumpStrength, ForceMode.Impulse);
        }
    }
    
    private bool IsGrounded(){
        return Physics.Raycast(PlayerRigidbody.transform.position, Vector3.down, PlayerCollider.bounds.extents.y + 0.1f);
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        b_movement = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        b_look = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started || context.canceled) return;
        if (context.ReadValueAsButton())
        {
            b_jump?.Invoke();
        }
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started || context.canceled) return;
        if (context.ReadValueAsButton())
        {
            b_fire?.Invoke();
        }
    }


    private Quaternion clampRotationAroundXAxis(Quaternion q, float MinimumX, float MaximumX)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angleX = Mathf.Clamp(angleX, MinimumX, MaximumX);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

        return q;
    }
}
