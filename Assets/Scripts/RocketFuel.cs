using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFuel : MonoBehaviour
{
  void OnBecameInvisible() {
    Destroy(gameObject);
  }
}
