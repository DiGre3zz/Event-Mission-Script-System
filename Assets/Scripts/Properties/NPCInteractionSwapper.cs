using UnityEngine;

[RequireComponent(typeof(Interactable))]
public class NPCInteractionSwapper : MonoBehaviour
{
    [SerializeField] private MissionRunner missionRunner;
    [SerializeField] private MissionFlagSO swaptriggerFlag;
    [SerializeField] private InteractionType secondInteraction;
    private Interactable interactable;
    private bool hasSwapped = false;
    private void Awake()
    {
        interactable = GetComponent<Interactable>();
    }

    private void Update()
{
    if (hasSwapped) return;
    if (missionRunner.Context == null) return;
    if (missionRunner.Context.HasFlag(swaptriggerFlag))
    {
        interactable.SetInteractionType(secondInteraction);
        hasSwapped = true;
    }
}
}
