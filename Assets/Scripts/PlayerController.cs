using System;
using System.Collections;
using System.Collections.Generic;
using Noesis;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput controls;

    [SerializeField] private float RotationTime = 10.0f;
    [SerializeField] private float MovementTime = 10.0f;
    
    private Vector3 inputVector;
    private Vector3 desiredMove;
    private float zoom;
    private Vector3 navigation;

    private Quaternion rotation;

    public float cameraSpeed;
    public float cameraRotationSpeed = 5.0f;
    void Awake()
    {
        controls = new PlayerInput();
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
    }

    void Move()
    {
        inputVector = controls.Camera.Move.ReadValue<Vector2>() * cameraSpeed;
        zoom = controls.Camera.Zoom.ReadValue<float>();
        desiredMove = (transform.forward * inputVector.y) + (transform.right * inputVector.x);

        navigation.Set(desiredMove.x,  zoom / 100.0f, desiredMove.z);

        transform.position = Vector3.Lerp(transform.position,  transform.position + navigation, Time.deltaTime * MovementTime);
    }

    void Rotate()
    {
        inputVector = controls.Camera.Rotate.ReadValue<Vector2>() * cameraRotationSpeed;
        rotation = Quaternion.Euler(0f, inputVector.x, 0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation * rotation, Time.deltaTime * RotationTime);
    }
}
