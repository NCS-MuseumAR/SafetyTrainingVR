using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameManager : MonoBehaviour
{
    public GameObject[] flames;
    public bool isAtLeastOneLit = false;


    void Update() {
        if (isAllFlamesPutOut()) {
            FindObjectOfType<MissionManager>().SetFlamePutOut();
        }
    }

    private bool isAllFlamesPutOut() {
        isAtLeastOneLit = false;

        foreach(GameObject flame in flames) {
            checkIfLit(isAtLeastOneLit, flame.GetComponent<Flame>().isLit);
        }
        
        return !isAtLeastOneLit;
    }

    private void checkIfLit(bool cumulativeIsLit, bool currIsLit) {
        isAtLeastOneLit = cumulativeIsLit || currIsLit;
    }
}
