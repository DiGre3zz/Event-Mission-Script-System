using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Mission System/Mission")]
public class Mission : ScriptableObject
{
    public List<MissionStep> Steps = new();
}
