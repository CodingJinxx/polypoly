using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput controls;
    
    private Vector3 inputVector;
    private Vector3 desiredMove;
    private Vector3 zoom;
    private Vector3 navigation;

    private Quaternion rotation;
    public float rotationAmount;

    public float cameraSpeed;
    void Awake()
    {
        controls = new PlayerInput();
    }

    private void Start()
    {
        rotationAmount = 5f;
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
        zoom = controls.Camera.Zoom.ReadValue<Vector2>();
        desiredMove = (transform.forward * inputVector.y) + (transform.right * inputVector.x);

        navigation.Set(desiredMove.x, zoom.y, desiredMove.z);

        transform.position += navigation * Time.deltaTime;
    }

    void Rotate()
    {
        inputVector = controls.Camera.Rotate.ReadValue<Vector2>();
        rotation = Quaternion.Euler(0f, inputVector.x, 0f);
        transform.rotation *= rotation;
    }
}
