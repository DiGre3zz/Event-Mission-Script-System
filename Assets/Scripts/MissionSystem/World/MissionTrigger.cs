
using UnityEngine;

public class MissionTrigger : MonoBehaviour
{
    [SerializeField] private MissionFlagSO flag;
    [SerializeField] private MissionRunner missionRunner;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;
        missionRunner.Context.SetFlag(flag);
    }
}
