using UnityEngine;

public abstract class MissionCondition : ScriptableObject
{
    public abstract bool IsMet(MissionContext context);
}
