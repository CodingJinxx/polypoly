using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput controls;
    private Vector3 inputVector;
    private Vector3 zoom;
    private Vector3 navigation;
    public float cameraSpeed;
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
        inputVector = controls.Camera.Move.ReadValue<Vector2>() * cameraSpeed;
        zoom = controls.Camera.Zoom.ReadValue<Vector2>();
        navigation.Set(inputVector.x, zoom.y, inputVector.y);
        transform.position += navigation * Time.deltaTime;
    }
}
