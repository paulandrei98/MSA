using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[Serializable]

public class MoveInputEvent : UnityEvent<float, float> { }

public class InputController : MonoBehaviour
{
    Player controls;
    public MoveInputEvent moveInputEvent;

    private void Awake()
    {
        controls = new Player();

    }

    private void OnEnable()
    {
        controls.PlayerMain.Enable();
        controls.PlayerMain.Move.performed += OnMovePerformed;
        controls.PlayerMain.Move.canceled += OnMovePerformed;
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        moveInputEvent.Invoke(moveInput.x, moveInput.y);
        Debug.Log($"Move Input: {moveInput}");
    }
}
