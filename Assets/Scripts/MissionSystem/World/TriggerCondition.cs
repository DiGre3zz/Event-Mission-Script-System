using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Mission System/Conditions/Trigger")]

public class TriggerCondition : MissionCondition
{
    [SerializeField] private MissionFlagSO flag;

    public override bool IsMet(MissionContext context)
    { 
     return context.HasFlag(flag); 
    }
}
