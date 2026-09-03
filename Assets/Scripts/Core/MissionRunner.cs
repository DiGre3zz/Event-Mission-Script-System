using UnityEngine;
using System.Collections;

// Script that runs mission steps agnostic to what the steps are and how many of them added later

public class MissionRunner : MonoBehaviour
{
    [SerializeField] private Mission mission;

    public MissionContext Context { get; private set; }

    void Start()
    {
        StartCoroutine(RunMission(mission));
    }
    private IEnumerator RunMission(Mission mission)
    {
        Debug.Log("Mission Started");
        Context = new MissionContext();
        foreach (MissionStep step in mission.Steps)
        {
         yield return StartCoroutine(step.Execute(Context));
        }

        Debug.Log("Mission Finished");
    }
    
    
  
}
