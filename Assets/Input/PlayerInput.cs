// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Camera"",
            ""id"": ""b1b20ee8-f9a0-49af-baf5-29fcc93df2aa"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e498c525-b7d5-4b63-8c52-94bc5de196b2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""8d13588c-273f-4cc2-998d-4d88b56faf9b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""3e616fdc-09dc-4293-8d72-6658a66b1e50"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f058632b-3129-4eb2-b926-cc7a4f23ba15"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""aaf717af-2c09-4059-9a27-edf1fb960572"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ec3c19cc-0d4d-45b8-b0fc-86656c0c61c1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""16860cea-5dfa-48ce-b68c-2febd2a27900"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""047a1a90-6b09-4e42-b105-22281e1db654"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9d728662-d0d1-4da2-9ccb-3c8a62bbab66"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7b4a4356-d07f-4253-b839-d6be42709311"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c6a0c6b7-65b9-48e0-b7e5-16b229a2631f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b005c6ee-5765-4a74-99d5-76b635094fe6"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GridInteraction"",
            ""id"": ""0a111a09-d00e-4cf2-94db-ea00e64ff8c7"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""dc4d2950-cd81-4835-bb62-058a5117a799"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""CursorPosition"",
                    ""type"": ""Value"",
                    ""id"": ""0baa9b4b-7486-4ead-ba67-6eecd0d216d2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""795d13d9-09fd-45a7-b79c-9d1282f8f442"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75e8958b-afb5-48a7-8c81-5c385f62e5c5"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Move = m_Camera.FindAction("Move", throwIfNotFound: true);
        m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
        m_Camera_Rotate = m_Camera.FindAction("Rotate", throwIfNotFound: true);
        // GridInteraction
        m_GridInteraction = asset.FindActionMap("GridInteraction", throwIfNotFound: true);
        m_GridInteraction_Click = m_GridInteraction.FindAction("Click", throwIfNotFound: true);
        m_GridInteraction_CursorPosition = m_GridInteraction.FindAction("CursorPosition", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Move;
    private readonly InputAction m_Camera_Zoom;
    private readonly InputAction m_Camera_Rotate;
    public struct CameraActions
    {
        private @PlayerInput m_Wrapper;
        public CameraActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Camera_Move;
        public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
        public InputAction @Rotate => m_Wrapper.m_Camera_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMove;
                @Zoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Rotate.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // GridInteraction
    private readonly InputActionMap m_GridInteraction;
    private IGridInteractionActions m_GridInteractionActionsCallbackInterface;
    private readonly InputAction m_GridInteraction_Click;
    private readonly InputAction m_GridInteraction_CursorPosition;
    public struct GridInteractionActions
    {
        private @PlayerInput m_Wrapper;
        public GridInteractionActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_GridInteraction_Click;
        public InputAction @CursorPosition => m_Wrapper.m_GridInteraction_CursorPosition;
        public InputActionMap Get() { return m_Wrapper.m_GridInteraction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GridInteractionActions set) { return set.Get(); }
        public void SetCallbacks(IGridInteractionActions instance)
        {
            if (m_Wrapper.m_GridInteractionActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_GridInteractionActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_GridInteractionActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_GridInteractionActionsCallbackInterface.OnClick;
                @CursorPosition.started -= m_Wrapper.m_GridInteractionActionsCallbackInterface.OnCursorPosition;
                @CursorPosition.performed -= m_Wrapper.m_GridInteractionActionsCallbackInterface.OnCursorPosition;
                @CursorPosition.canceled -= m_Wrapper.m_GridInteractionActionsCallbackInterface.OnCursorPosition;
            }
            m_Wrapper.m_GridInteractionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @CursorPosition.started += instance.OnCursorPosition;
                @CursorPosition.performed += instance.OnCursorPosition;
                @CursorPosition.canceled += instance.OnCursorPosition;
            }
        }
    }
    public GridInteractionActions @GridInteraction => new GridInteractionActions(this);
    public interface ICameraActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
    public interface IGridInteractionActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnCursorPosition(InputAction.CallbackContext context);
    }
}
