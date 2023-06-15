using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/**
    Mission manager for level 1 only, where all mission managers are managed by Game manager.
*/
public class MissionManager : MonoBehaviour
{
    public GameObject missionPanel;
    public TMP_Text missionDesc;
    
    public bool isFireExtinguisherPickedUp = false;
    public bool isFlamePutOut = false;

    private List<Mission> missions = new List<Mission>();
    private string[] missionNames = {"Find and grab the fire extinguisher", "Put out the fire"};
    

    void Start() {
        foreach (string missionName in missionNames) {
            missions.Add(new Mission(missionName));
        }

        // Start the timer
        // timerManager.StartTimer();
    }

    void Update() {
        UpdateMissionPanel();
        
        if (isFireExtinguisherPickedUp && isFlamePutOut) {
            print("level complete");
        }
    }

    // Mission 1
    public void SetFireExtinguisherPickedUp()
    {
        isFireExtinguisherPickedUp = true;
        Debug.Log("Mission 1 Complete: " + isMissionCompletedById(0));

    }

    // Mission 2
    public void SetFlamePutOut()
    {
        isFlamePutOut = true;
        Debug.Log("Mission 2 Complete: " + isMissionCompletedById(1));
    }
    
    private void UpdateMissionPanel() {
        missionDesc.text = "";
        /* Missions to be dealt with in sequence, to update later */
        foreach (Mission mission in missions)
        {
            if (mission.isCompleted) {
                missionDesc.text += $"<s>{mission.missionName}</s>\n";
                // mission.completionTimeText = timerManager.CalculateCompletionTime();
            }
            else {
                missionDesc.text += $"{mission.missionName}\n";
            }
        }
    }

    public bool isMissionCompletedById(int Id) {
        Mission mission = missions.Find(m => m.Id == Id);
        if (mission != null) {
            mission.CompleteMission();
            UpdateMissionPanel();
            // timerManager.StartTimer();
            return true;
        }
        return false;
    }

    public class Mission
    {
        public static int missionId = 0;
        public int Id;
        public string missionName;
        public bool isCompleted;

        public Mission(string name)
        {
            Id = Mission.missionId++;
            missionName = name;
            isCompleted = false;
        }

        public void CompleteMission()
        {
            isCompleted = true;
        }
    }
}
