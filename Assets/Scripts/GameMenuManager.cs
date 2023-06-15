using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject menu;
    public void LookAt(Transform target){}  
   
    void Update()
    {
        menu.transform.position = head.position + new Vector3(head.forward.x,0, head.forward.z).normalized * spawnDistance;

        //to update menu to face its front at user
        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));

        menu.transform.forward *= -1;
    }
}
