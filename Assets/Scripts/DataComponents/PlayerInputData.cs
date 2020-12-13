using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputData : MonoBehaviour 
{
    public Vector2 Look;
    public Vector2 Movement;
    public event Action OnFire;
    public event Action OnJump;
    public void RaiseFireEvent() => OnFire?.Invoke();
    public void RaiseJumpEvent() => OnJump?.Invoke();
}
