using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int playerScore = 0;

    public static void UpdateScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
    }
    // Example usage
    //ScoreManager.UpdateScore(10); // Adds 10 points to the player's score
}
