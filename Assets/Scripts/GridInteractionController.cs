using System;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DefaultNamespace
{
    public class GridInteractionController : MonoBehaviour, PlayerInput.IGridInteractionActions
    {
        public event Action BuildModeChanged;
        
        [SerializeField]
        private Collider GridCollider;
        [SerializeField] 
        private GridSystem m_GridSystem;
        [SerializeField] 
        public GridTile CurrentTile;
        public bool IsBuildMode = false;
        private Vector2 CursorPosition;
        private PlayerInput input;

        private void OnEnable()
        {
            if (input is null)
            {
                input = new PlayerInput();
                input.GridInteraction.SetCallbacks(this);
            }
            input.Enable();
            input.GridInteraction.Enable();
        }

        private void OnDisable()
        {
            input.Disable();
            input.GridInteraction.Disable();
        }


        public void OnClick(InputAction.CallbackContext context)
        {
            if (context.canceled || context.started || !IsBuildMode) return;
            
            var ray = Camera.main.ScreenPointToRay(CursorPosition);
            RaycastHit info;
            if (GridCollider.Raycast(ray, out info, 100f))
            {
                Vector3 hitpoint = info.point;
                
                hitpoint.y = 0.0f;
                hitpoint.x = (int) hitpoint.x + Mathf.Sign(hitpoint.x) * 0.5f;
                hitpoint.z = (int) hitpoint.z + Mathf.Sign(hitpoint.z) * 0.5f;

                if (m_GridSystem.IsTileTaken(hitpoint))
                {
                    m_GridSystem.RemoveTile(hitpoint);
                }
                else
                {
                    m_GridSystem.AddTile(hitpoint, CurrentTile);
                }
            }
            
        }

        public void OnCursorPosition(InputAction.CallbackContext context)
        {
            this.CursorPosition = context.ReadValue<Vector2>();
        }

        public void OnToggleBuildMode(InputAction.CallbackContext context)
        {
            if (context.canceled || context.started) return;
            IsBuildMode = !IsBuildMode;
            BuildModeChanged?.Invoke();
        }
    }
}