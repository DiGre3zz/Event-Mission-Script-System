using System;
using UnityEngine.InputSystem;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static event Action Interact;

    private void OnInteract(InputValue value)
    {
       Interact?.Invoke();
    }
}
