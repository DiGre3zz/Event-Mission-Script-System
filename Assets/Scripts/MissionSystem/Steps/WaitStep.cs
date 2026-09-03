using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Mission System/Steps/WaitStep")]
public class WaitStep : MissionStep
{
    [SerializeField] MissionCondition condition;

    public override IEnumerator Execute(MissionContext context)
    {
        Debug.Log($"Waiting for condition to be met...");
        while (!condition.IsMet(context))
        {
            yield return null;
        }
        Debug.Log($"Condition met.");
    }
}
