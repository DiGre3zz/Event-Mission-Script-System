using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Mission System/Steps/Debug Log Step")]
public class DebugLogStep : MissionStep
{
    [SerializeField] private string message;

    public override IEnumerator Execute(MissionContext context)
    { 
     Debug.Log(message);
        yield return null;
    }
}
