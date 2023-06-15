using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
{   
    [SerializeField, Range(0f, 1f)] private float currentIntensity = 1.0f;
    private float[] startIntensities = new float[0];

    [SerializeField] private ParticleSystem[] flameParticleSystems = new ParticleSystem[0];

    float timeLastWatered = 0;
    [SerializeField] private float regenDelay = 2.5f;
    [SerializeField] private float regenRate = 0.1f;

    public bool isLit = true;

    private void Start() 
    {
        // Initialise each starting intensity
        print("[Flame.cs] Initialisation");
        startIntensities = new float[flameParticleSystems.Length];
        for (int i = 0; i < flameParticleSystems.Length; i++) {
            startIntensities[i] = flameParticleSystems[i].emission.rateOverTime.constant;
        }
    }

    private void Update()
    {
        // To regenerate flame
        if (isLit && currentIntensity < 1.0f && Time.time - timeLastWatered >= regenDelay) {
            // print("[Flame.cs] isLit is curently: " + isLit);
            currentIntensity += regenRate * Time.deltaTime;
            ChangeIntensity();
        }
    }

    public bool TryExtinguish(float amount) {
        // print("[Flame.cs] Trying to extinguish");
        timeLastWatered = Time.time;
        currentIntensity -= amount;
        ChangeIntensity();
        isLit = currentIntensity > 0f;
        return isLit;
    }

    private void ChangeIntensity()
    {
        for (int i = 0; i < flameParticleSystems.Length; i++) {
            // print("[Flame.cs] Changing intensity");
            var emission = flameParticleSystems[i].emission;
            emission.rateOverTime = currentIntensity * startIntensities[i];
        }
    }
}
