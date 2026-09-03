
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private bool inRange;
    [SerializeField] private bool isInteractable = true;
    [SerializeField] InteractionType interactionType;

    private void OnEnable()
    {
        InputHandler.Interact += OnInteractPressed;
    }

    private void OnInteractPressed()
    {
        if (inRange && isInteractable) InteractWithObject();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) inRange = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) inRange = false;
    }

    private void InteractWithObject()
    {
        interactionType.InteractWithObject();
    }

    private void OnDisable()
    {
        InputHandler.Interact -= OnInteractPressed;
    }

    public void SetInteractionType(InteractionType newInteractionType)
    {
        interactionType = newInteractionType;
    }
}
