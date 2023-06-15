using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// using UnityEngine.SceneManager;

public class GameManager : MonoBehaviour
{
    private bool isGameStarted = false;
    public GameObject missionPanel;
    public TimerManager timerManager;
    private MissionManager missionManager;
    // private Scene currScene;

    private void Start()
    {
        // currScene = SceneManager.GetActiveScene();
        // missionManager = get mission manager and check if mission is all completed, aka level complete
        // Update the mission panel text initially
        // UpdateMissionPanelText();
    }

    public void RestartScene() {

    }

    private void Update()
    {
        // Reference MissionManager.cs
    }

}
