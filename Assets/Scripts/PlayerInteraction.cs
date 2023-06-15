using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fire Extinguisher"))
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            // gameManager.PickUpFireExtinguisher();
        }
    }
}
