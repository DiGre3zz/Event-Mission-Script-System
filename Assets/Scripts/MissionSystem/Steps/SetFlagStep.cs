using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Mission System/Steps/Set Flag Step")]
public class SetFlagStep : MissionStep
{
    [SerializeField] private MissionFlagSO flag;
    
    public override IEnumerator Execute(MissionContext context)
    {
        context.SetFlag(flag);
        Debug.Log($"Flag set: {flag.name}");
        yield return null;
    }
}
