using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Mission System/Steps/Context Set Step")]
public class ContextSetStep : MissionStep
{
    [SerializeField] private string key;
    [SerializeField] private int value;

    public override IEnumerator Execute(MissionContext context)
    {
        context.SetValue(key, value);
        Debug.Log($"Set {key} = {value}");
            yield return null;
    }
}
