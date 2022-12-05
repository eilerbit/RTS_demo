//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Settings/CameraControlActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CameraControlActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CameraControlActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CameraControlActions"",
    ""maps"": [
        {
            ""name"": ""CameraActionMap"",
            ""id"": ""5af0bf08-4381-4240-b801-3344fb28ca79"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b3f96658-2f00-4903-bfdd-2a58b5338345"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""bcd02066-53e0-4308-b4eb-a581c19f99ce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""20d14c40-5c56-4095-9e06-b87bd69a7388"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5fcb3650-b3b7-4cbb-9e8f-984ea6a2f824"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0463a2fa-3108-460e-8932-fbf1024b9302"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""be0a082c-e4e5-4798-9d45-bb5274d980ff"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""046e8b6b-2405-423b-8ccc-cb71d8020386"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b1acd961-1803-4012-95e6-0ac734f4d326"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a21e8745-0c53-4ced-bf7a-b9a1b3624d0b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""52c076b0-722f-4976-a951-ee364a74f1cf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""de8f48b5-fa30-4d9d-a531-1c5f53da66da"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a119262b-7a73-476f-a7d7-129df093d103"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c0709925-31bd-43c6-a1f5-81bb6e94495c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""302d141f-61de-4275-b7b7-8df5f602a22f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""367dabbf-0f4f-4b34-bc38-ca73b920d22c"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraActionMap
        m_CameraActionMap = asset.FindActionMap("CameraActionMap", throwIfNotFound: true);
        m_CameraActionMap_Movement = m_CameraActionMap.FindAction("Movement", throwIfNotFound: true);
        m_CameraActionMap_Rotation = m_CameraActionMap.FindAction("Rotation", throwIfNotFound: true);
        m_CameraActionMap_Zoom = m_CameraActionMap.FindAction("Zoom", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // CameraActionMap
    private readonly InputActionMap m_CameraActionMap;
    private ICameraActionMapActions m_CameraActionMapActionsCallbackInterface;
    private readonly InputAction m_CameraActionMap_Movement;
    private readonly InputAction m_CameraActionMap_Rotation;
    private readonly InputAction m_CameraActionMap_Zoom;
    public struct CameraActionMapActions
    {
        private @CameraControlActions m_Wrapper;
        public CameraActionMapActions(@CameraControlActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CameraActionMap_Movement;
        public InputAction @Rotation => m_Wrapper.m_CameraActionMap_Rotation;
        public InputAction @Zoom => m_Wrapper.m_CameraActionMap_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_CameraActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActionMapActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActionMapActions instance)
        {
            if (m_Wrapper.m_CameraActionMapActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnMovement;
                @Rotation.started -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnRotation;
                @Zoom.started -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_CameraActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public CameraActionMapActions @CameraActionMap => new CameraActionMapActions(this);
    public interface ICameraActionMapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}