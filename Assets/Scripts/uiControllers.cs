using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControllers : MonoBehaviour
{
    public GameObject controlsPanel;
    public GameObject trainingStartInterface;
    public GameObject flameEnvironment;

    private void Start() {
        controlsPanel.SetActive(false);
        flameEnvironment.SetActive(false);
    }

    public void StartGame() {
        trainingStartInterface.SetActive(false);
        flameEnvironment.SetActive(true);
    }

    public void QuitTraining() {
        Application.Quit();
    }
        
    public void ShowInstructions() {
        controlsPanel.SetActive(!controlsPanel.activeSelf);
    }

    public void CloseInstructions(){
        controlsPanel.SetActive(false);
    }


    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMainMenu() {
        SceneManager.LoadScene("MainVRScene");
    }

}
