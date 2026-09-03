using UnityEngine;

public class MissionFlagInteraction : InteractionType
{
    [SerializeField] private MissionFlagSO flag;
    [SerializeField] private MissionRunner missionRunner;

    public override void InteractWithObject()
    {
        missionRunner.Context.SetFlag(flag);
    }
}
