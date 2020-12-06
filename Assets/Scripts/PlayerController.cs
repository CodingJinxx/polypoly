using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, PlayerInput.ICameraActions
{
    // Unity Objects
    [SerializeField] private Camera camera;
    [SerializeField] private GameObject rig;
    private PlayerInput controls;
    
    // Initials
    [SerializeField, Range(0, 1)] private float InitialZoom = 0.25f;
    
    // Sensitivities and Speeds
    [SerializeField] private float ZoomSensitivity = 1.0f;
    [SerializeField] private float RotationSpeed = 1.0f;
    [SerializeField] private float MovementSpeed = 0.5f;
    [SerializeField] private float OrbitSpeed = 0.5f;
    
    // Limits
    [SerializeField] private float MaxZoomDistance = 100.0f;
    [SerializeField] private float MinZoomDistance = 0.1f;
    [SerializeField] private float MaxTilt = 80.0f;
    [SerializeField] private float MinTilt = 10.0f;
    
    // Lerp Time
    [SerializeField] private float ZoomTime = 10.0f;
    [SerializeField] private float RotationTime = 10.0f;
    [SerializeField] private float MovementTime = 10.0f;

    // Calculation Variables
    private Vector2 velocity { get => b_moveInput * MovementSpeed; }
    private float interpolatedZoom { get => Mathf.Clamp01((rawZoom - MinZoomDistance) * 1 / (MaxZoomDistance - MinZoomDistance)); }
    private float rawZoom;

    // Buffer Input Variables
    private Vector2 b_moveInput;
    private float b_rotationInput;
    private float b_zoomInput;
    private Vector2 b_lookInput;
    private bool b_doOrbitInput;

    // Future Camera Position and Rotation
    private Vector3 f_cam_pos;
    private Quaternion f_cam_rot;

    // Future Rig Position and Rotation
    private Vector3 f_rig_pos;
    private Quaternion f_rig_rot;
    
    private void OnEnable()
    {
        if (controls is null)
        {
            controls = new PlayerInput();
        }
        controls.Enable();
        controls.Camera.SetCallbacks(this);
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Start()
    {
        rawZoom = (MaxZoomDistance - MinZoomDistance) * InitialZoom;
        
        f_cam_pos = camera.transform.localPosition;
        f_cam_rot = camera.transform.localRotation;

        f_rig_pos = rig.transform.localPosition;
        f_rig_rot = rig.transform.localRotation;
    }

    private void Update()
    {
        futuresUpdate();
        
        rig.transform.localPosition = Vector3.Lerp(rig.transform.localPosition, f_rig_pos, Time.deltaTime * MovementTime);
        rig.transform.localRotation = Quaternion.Lerp(rig.transform.localRotation, f_rig_rot, Time.deltaTime * RotationTime);
        camera.transform.localPosition = Vector3.Lerp(camera.transform.localPosition, f_cam_pos, Time.deltaTime * ZoomTime);
    }

    private void futuresUpdate()
    {
        if (!b_doOrbitInput)
        {
            // Rotation Input around Y axis
            Vector3 Rotation = new Vector3(0, b_rotationInput * RotationSpeed, 0);
            Rotation = Quaternion.Euler(-f_rig_rot.eulerAngles.x, 0.0f, 0.0f) * Rotation;
            f_rig_rot *= Quaternion.Euler(Rotation);
        }
        else
        {
            // Orbit
            Vector3 XRotation = new Vector3(b_lookInput.y * OrbitSpeed, 0.0f, 0.0f);
            f_rig_rot *= Quaternion.Euler(XRotation);
            Vector3 ClampedRigRotation = f_rig_rot.eulerAngles;
            ClampedRigRotation.x = Mathf.Clamp(ClampedRigRotation.x, MinTilt, MaxTilt);
            f_rig_rot = Quaternion.Euler(ClampedRigRotation);
            
            Vector3 YRotation = new Vector3(0, b_lookInput.x * OrbitSpeed, 0.0f);
            YRotation = Quaternion.Euler(-f_rig_rot.eulerAngles.x, 0.0f, 0.0f) * YRotation;
            f_rig_rot *= Quaternion.Euler(YRotation);
            
            // Hack to keep z rotation 0.0f
            Vector3 ZAxisLockHack = f_rig_rot.eulerAngles;
            ZAxisLockHack.z = 0.0f;
            f_rig_rot = Quaternion.Euler(ZAxisLockHack);
        }
        
        
        // Forward Movement
        Vector3 leveledRotationAngles = f_rig_rot.eulerAngles;
        leveledRotationAngles.x = 0.0f;
        Quaternion leveledRotation = Quaternion.Euler(leveledRotationAngles);
        Vector3 Forward = (leveledRotation * Vector3.forward);
        Vector3 Right = (leveledRotation * Vector3.right);
        Vector2 distanceAdjustedVelocity = velocity * (interpolatedZoom + 0.5f);
        f_rig_pos += distanceAdjustedVelocity.x * Right + distanceAdjustedVelocity.y * Forward;

        // Zoom
        f_cam_pos.z = rawZoom * -1;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        b_moveInput = controls.Camera.Move.ReadValue<Vector2>();
    }

    public void OnZoom(InputAction.CallbackContext context)
    {
        b_zoomInput = controls.Camera.Zoom.ReadValue<float>();

        var zoomAddition = (-b_zoomInput / (120.0f * 1/ZoomSensitivity)) * interpolatedZoom;
        rawZoom = Mathf.Clamp(rawZoom + zoomAddition, MinZoomDistance, MaxZoomDistance);
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        b_rotationInput = controls.Camera.Rotate.ReadValue<float>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        b_lookInput = context.ReadValue<Vector2>();
    }

    public void OnDoOrbit(InputAction.CallbackContext context)
    {
        b_doOrbitInput = context.ReadValueAsButton();
    }
}
