using System.Collections;
using UnityEngine;

public abstract class MissionStep : ScriptableObject
{
    public abstract IEnumerator Execute(MissionContext context);
}
