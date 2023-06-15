using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingEndUiControllers : MonoBehaviour
{
    public GameObject player;
    public GameObject extinguisher;
    private Vector3 playerStartPosition;
    private Vector3 extinguisherStartPosition;
    public GameObject trainingStartInterface;
    public GameObject flameEnvironment;

    private void Start() {
        playerStartPosition = player.transform.position;
        extinguisherStartPosition = extinguisher.transform.position;
        print("player start position is " + playerStartPosition);
        print("ext start position is " + extinguisherStartPosition);
    }

    public void StartGame() {
        trainingStartInterface.SetActive(false);
        // trainingEndInterface.SetActive(false);

        flameEnvironment.SetActive(true); // need to restart fire intensity, set isLit to true
        // restart fire extuinguisher position

        extinguisher.transform.position = extinguisherStartPosition;
        player.transform.position = playerStartPosition;

        // player.transform.position = new Vector3(1, 1, 1);
        print("player new position is " + player.transform.position);
        print("ext new position is " + extinguisher.transform.position);
    }

    public void RestartGame() {
        // ReturnToMainMenu();
        StartGame();
    }

    public void ReturnToMainMenu() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
        // SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
}
