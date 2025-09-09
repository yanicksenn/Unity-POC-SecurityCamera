using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour, InputSystem_Actions.IPlayerActions
{
    private InputSystem_Actions actions;
    
    [SerializeField] private SecurityScreen securityScreen;

    private void Awake() {
        actions = new InputSystem_Actions();
        actions.Player.SetCallbacks(this);
    }

    private void OnEnable() {
        actions.Player.Enable();
    }

    private void OnDisable() {
        actions.Player.Disable();
    }

    public void OnSelectNextCamera(InputAction.CallbackContext context) {
        if (securityScreen == null) return;
        if (context.phase != InputActionPhase.Started) return;
        securityScreen.SelectNextSecurityCamera();
    }

    public void OnSelectPreviousCamera(InputAction.CallbackContext context) {
        if (securityScreen == null) return;
        if (context.phase != InputActionPhase.Started) return;
        securityScreen.SelectPreviousSecurityCamera();
    }
}