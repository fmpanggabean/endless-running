using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum InputState {
    Gameplay, UI
}
[CreateAssetMenu(fileName = "InputHandler", menuName = "Input Handler")]
public class InputHandler : ScriptableObject, CustomInput.IGameplayActions {
    private CustomInput input;

    public event Action<float> onPlayerMovementPressed;
    public event Action onPausePressed;

    private void OnEnable() {
        if (input == null) {
            input = new CustomInput();
        }

        input.Gameplay.SetCallbacks(this);

        EnableInput(InputState.UI);
    }
    private void OnDisable() {
        DisableAllInput();
    }
    private void DisableAllInput() {
        //disable all
        input.Gameplay.Disable();
    }
    public void EnableInput(InputState inputState) {
        DisableAllInput();

        if (inputState == InputState.Gameplay) {
            input.Gameplay.Enable();
        } else if (inputState == InputState.UI) {
            input.UI.Enable();
        }
    }

    public void OnPlayerMovement(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Performed) {
            onPlayerMovementPressed?.Invoke(context.ReadValue<float>());
        }
    }

    public void OnPauseGame(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Performed) {
            onPausePressed?.Invoke();
        }
    }
}
