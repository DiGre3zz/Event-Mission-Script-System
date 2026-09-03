using UnityEngine;

[CreateAssetMenu(menuName = "Mission System/Conditions/Variable Equals")]
public class VariableEqualsCondition : MissionCondition
{
    [SerializeField] private string key;
    [SerializeField] private int targetValue;

    public override bool IsMet(MissionContext context)
    {
        return
               context.GetValue<int>(key) == targetValue;
    }

}
