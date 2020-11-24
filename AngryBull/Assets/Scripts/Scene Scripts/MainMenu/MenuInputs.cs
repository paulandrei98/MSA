// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Scene Scripts/MenuInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MenuInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MenuInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MenuInputs"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""3f57aa05-7af2-43db-a7e8-783228f2b65b"",
            ""actions"": [
                {
                    ""name"": ""Play"",
                    ""type"": ""Button"",
                    ""id"": ""a3a3f5e1-06b6-41e7-89b8-95287e096264"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Settings"",
                    ""type"": ""Button"",
                    ""id"": ""62c7ae34-f9cb-4392-b717-bedf9b21bf6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""1477922f-41d7-408b-808a-ee180747f34e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""af19d972-4500-403a-9608-5bf95d87db11"",
                    ""path"": ""<Touchscreen>/touch0/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6827a61-0a26-46e5-bdee-d9a145676014"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbbd58f7-010c-4a11-be1f-605877252247"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Settings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe5412ab-eb8f-4e2a-8a90-4da7bc91e0cf"",
                    ""path"": ""<Touchscreen>/touch0/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Settings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""772229e4-cf58-409c-aeb6-1aa92f5b1fa9"",
                    ""path"": ""<Touchscreen>/touch0/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33e26d08-11e6-4e81-9b12-5360a65373f4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""TouchScreen"",
            ""bindingGroup"": ""TouchScreen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Play = m_Menu.FindAction("Play", throwIfNotFound: true);
        m_Menu_Settings = m_Menu.FindAction("Settings", throwIfNotFound: true);
        m_Menu_Quit = m_Menu.FindAction("Quit", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Play;
    private readonly InputAction m_Menu_Settings;
    private readonly InputAction m_Menu_Quit;
    public struct MenuActions
    {
        private @MenuInputs m_Wrapper;
        public MenuActions(@MenuInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Play => m_Wrapper.m_Menu_Play;
        public InputAction @Settings => m_Wrapper.m_Menu_Settings;
        public InputAction @Quit => m_Wrapper.m_Menu_Quit;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Play.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay;
                @Play.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay;
                @Play.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay;
                @Settings.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSettings;
                @Settings.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSettings;
                @Settings.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSettings;
                @Quit.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuit;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Play.started += instance.OnPlay;
                @Play.performed += instance.OnPlay;
                @Play.canceled += instance.OnPlay;
                @Settings.started += instance.OnSettings;
                @Settings.performed += instance.OnSettings;
                @Settings.canceled += instance.OnSettings;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    private int m_TouchScreenSchemeIndex = -1;
    public InputControlScheme TouchScreenScheme
    {
        get
        {
            if (m_TouchScreenSchemeIndex == -1) m_TouchScreenSchemeIndex = asset.FindControlSchemeIndex("TouchScreen");
            return asset.controlSchemes[m_TouchScreenSchemeIndex];
        }
    }
    public interface IMenuActions
    {
        void OnPlay(InputAction.CallbackContext context);
        void OnSettings(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
    }
}
