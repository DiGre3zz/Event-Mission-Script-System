using System.Collections.Generic;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Mission System/Steps/Context Read Step")]
public class ContextReadStep : MissionStep
{
    [SerializeField] private string key;

    public override IEnumerator Execute(MissionContext context)
    {
        int value = context.GetValue<int>(key);
        Debug.Log($"{key} = {value}");
        yield return null;
    }
}
