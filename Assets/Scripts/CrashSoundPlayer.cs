using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CrashSoundPlayer : MonoBehaviour
{
  AudioSource audioSource;
  void Awake() 
  {
    audioSource = GetComponent<AudioSource>();
  }

  void OnEnable() 
  {
    Brick.onCrash += (PlayCrashSound);
  }

  void OnDisable()
  {
    Brick.onCrash -= (PlayCrashSound);
  }

  void PlayCrashSound() 
  {
    audioSource.Play();
  }
}