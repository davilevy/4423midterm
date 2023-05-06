using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Brick : MonoBehaviour
{
  public static event Action onCrash;

  public void Crash() 
  {
    onCrash.Invoke();
  }
  void OnBecameInvisible() {
    Destroy(gameObject);
  }
}