// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""HeroController"",
            ""id"": ""024e637f-7169-400b-ae7c-7167dd00eb90"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""384cbd9e-c9fa-404d-ad0b-919f5622539a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""b5ee9f78-7b8f-4b02-8534-db1c1ad105f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackOne"",
                    ""type"": ""Button"",
                    ""id"": ""ab43b6f8-1c97-453c-92c1-4549e2fc2b60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackTwo"",
                    ""type"": ""Button"",
                    ""id"": ""f8376013-1963-478a-800e-5994d194e36a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""25666668-4d46-4ccb-9223-5e902d1f341c"",
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
                    ""id"": ""d59ce486-a218-437f-b463-afc71668431e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""286628d4-a79a-49e0-a367-4ecbe4e40068"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9b4d0080-6008-4ea3-86d2-c085a153e26b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ea1a47bf-8191-4070-851e-dae7144a56bd"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad(dpad)"",
                    ""id"": ""7442d18a-85bf-4103-87e9-3adb5f95064b"",
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
                    ""id"": ""8e19293d-e318-43f6-9782-4e63a133426b"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2ac13e45-3b4b-4587-b62d-c8f3b4587fae"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fe582efd-6bfb-48e1-a46d-efb9c1b732fe"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b7e8be4f-fd48-431f-958e-bf9e34ab635d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""79d29ab8-0468-4d6f-9e44-cc8c6c35dfb6"",
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
                    ""id"": ""59baa4fe-94d2-4336-9d40-0bbc4011a491"",
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
                    ""id"": ""9f5830bb-fbc3-4d18-a663-34f81d7bcaf9"",
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
                    ""id"": ""b22e94f1-2d74-4aa8-89ad-e35c6e9815a5"",
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
                    ""id"": ""d132e39c-0786-4ce1-8e7c-959254a7190c"",
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
                    ""id"": ""cfe518ed-9992-4fa2-9f78-af549e93056e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ada9f542-8764-4038-8a6b-67458ce39df2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33199b3c-c040-42b5-b858-a3cf14d20170"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c64ea5c-7001-4515-9334-e1705cf26e04"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3cf9c04-125e-44d8-b96a-ed0472025d3b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cbb4e16-619e-46d8-b227-ed8b2282ec4b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // HeroController
        m_HeroController = asset.FindActionMap("HeroController", throwIfNotFound: true);
        m_HeroController_Movement = m_HeroController.FindAction("Movement", throwIfNotFound: true);
        m_HeroController_Dash = m_HeroController.FindAction("Dash", throwIfNotFound: true);
        m_HeroController_AttackOne = m_HeroController.FindAction("AttackOne", throwIfNotFound: true);
        m_HeroController_AttackTwo = m_HeroController.FindAction("AttackTwo", throwIfNotFound: true);
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

    // HeroController
    private readonly InputActionMap m_HeroController;
    private IHeroControllerActions m_HeroControllerActionsCallbackInterface;
    private readonly InputAction m_HeroController_Movement;
    private readonly InputAction m_HeroController_Dash;
    private readonly InputAction m_HeroController_AttackOne;
    private readonly InputAction m_HeroController_AttackTwo;
    public struct HeroControllerActions
    {
        private @PlayerControlls m_Wrapper;
        public HeroControllerActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_HeroController_Movement;
        public InputAction @Dash => m_Wrapper.m_HeroController_Dash;
        public InputAction @AttackOne => m_Wrapper.m_HeroController_AttackOne;
        public InputAction @AttackTwo => m_Wrapper.m_HeroController_AttackTwo;
        public InputActionMap Get() { return m_Wrapper.m_HeroController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeroControllerActions set) { return set.Get(); }
        public void SetCallbacks(IHeroControllerActions instance)
        {
            if (m_Wrapper.m_HeroControllerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnMovement;
                @Dash.started -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnDash;
                @AttackOne.started -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnAttackOne;
                @AttackOne.performed -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnAttackOne;
                @AttackOne.canceled -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnAttackOne;
                @AttackTwo.started -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnAttackTwo;
                @AttackTwo.performed -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnAttackTwo;
                @AttackTwo.canceled -= m_Wrapper.m_HeroControllerActionsCallbackInterface.OnAttackTwo;
            }
            m_Wrapper.m_HeroControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @AttackOne.started += instance.OnAttackOne;
                @AttackOne.performed += instance.OnAttackOne;
                @AttackOne.canceled += instance.OnAttackOne;
                @AttackTwo.started += instance.OnAttackTwo;
                @AttackTwo.performed += instance.OnAttackTwo;
                @AttackTwo.canceled += instance.OnAttackTwo;
            }
        }
    }
    public HeroControllerActions @HeroController => new HeroControllerActions(this);
    public interface IHeroControllerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAttackOne(InputAction.CallbackContext context);
        void OnAttackTwo(InputAction.CallbackContext context);
    }
}
