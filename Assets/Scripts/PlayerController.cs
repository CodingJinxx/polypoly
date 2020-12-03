using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput controls;

    [SerializeField] private float RotationTime = 10.0f;
    [SerializeField] private float MovementTime = 10.0f;
    
    private Vector3 inputVector;
    private Vector3 desiredMove;
    private Vector3 navigation;
    private Quaternion rotation;

    public float cameraSpeed = 10f;
    public float cameraRotationSpeed = 5.0f;
    
    public Transform cameraTransform;
    public Vector3 zoomAmount;
    private Vector3 newZoom;
    void Awake()
    {
        controls = new PlayerInput();
        newZoom = cameraTransform.localPosition;
    }
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    void FixedUpdate()
    {
        Move();
        Rotate();
        Zoom();
    }

    void Move()
    {
        inputVector = controls.Camera.Move.ReadValue<Vector2>() * cameraSpeed;
        desiredMove = (transform.forward * inputVector.y) + (transform.right * inputVector.x);
        navigation.Set(desiredMove.x, 0f, desiredMove.z);
        transform.position = Vector3.Lerp(transform.position,  transform.position + navigation, Time.deltaTime * MovementTime);
    }

    void Rotate()
    {
        inputVector = controls.Camera.Rotate.ReadValue<Vector2>() * cameraRotationSpeed;
        rotation = Quaternion.Euler(0f, inputVector.x, 0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation * rotation, Time.deltaTime * RotationTime);
    }

    void Zoom()
    {
        inputVector = controls.Camera.Zoom.ReadValue<Vector2>() / 120;
        newZoom += zoomAmount * inputVector.y;
        cameraTransform.localPosition = Vector3.Lerp(cameraTransform.localPosition, newZoom, Time.deltaTime * MovementTime);

    }
}
