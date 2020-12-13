using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DefaultNamespace.Components
{
    [RequireComponent(typeof(PlayerInputData))]
    public class PlayerInputSystem : MonoBehaviour, PlayerInput.IFirstPersonPlayerActions
    {
        private PlayerInputData _playerInputData;
        private PlayerInput _controls;
        private void OnEnable()
        {
            if (_controls == null)
            {
                _controls = new PlayerInput();
            }
            _controls.Enable();
            _controls.FirstPersonPlayer.Enable();
            _controls.FirstPersonPlayer.SetCallbacks(this);
        }

        private void OnDisable()
        {
            _controls.Disable();
            _controls.FirstPersonPlayer.Disable();
        }

        private void Start()
        {
            _playerInputData = GetComponent<PlayerInputData>();
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            _playerInputData.Movement = context.ReadValue<Vector2>();
        }

        public void OnLook(InputAction.CallbackContext context)
        {
            _playerInputData.Look = context.ReadValue<Vector2>();
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            if(context.canceled || context.performed) return;
            if (context.ReadValueAsButton())
            {
                _playerInputData.RaiseJumpEvent();
            }
        }

        public void OnFire(InputAction.CallbackContext context)
        {
            if(context.canceled || context.performed) return;
            if (context.ReadValueAsButton())
            {
                _playerInputData.RaiseFireEvent();
            }
        }
    }
}