using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RocketFuel : MonoBehaviour
{
  public static event Action onCatch;

  public void Catch() {
    onCatch.Invoke();
  }
  void OnBecameInvisible() {
    Destroy(gameObject);
  }
}
