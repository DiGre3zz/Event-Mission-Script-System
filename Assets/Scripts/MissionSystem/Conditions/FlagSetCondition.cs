using UnityEngine;

[CreateAssetMenu(fileName = "FlagSetCondition", menuName = "Mission System/Conditions/Flag Set Condition")]
public class FlagSetCondition : MissionCondition
{
    [SerializeField] private MissionFlagSO flag;

    public override bool IsMet(MissionContext context)
    {
        return context.HasFlag(flag);
    }
}
