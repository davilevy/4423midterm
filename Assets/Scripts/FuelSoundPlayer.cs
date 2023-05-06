using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FuelSoundPlayer : MonoBehaviour
{
  AudioSource audioSource;

  void Awake() {
    audioSource = GetComponent<AudioSource>();
  }
    // Start is called before the first frame update
    void OnEnable()
    {
        RocketFuel.onCatch += (PlayFuelSound);
    }

    void onDisable() {
      RocketFuel.onCatch -= (PlayFuelSound);
    }

    // Update is called once per frame
    void PlayFuelSound()
    {
        audioSource.Play();
    }
}
