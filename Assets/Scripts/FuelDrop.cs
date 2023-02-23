using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelDrop : MonoBehaviour
{

  public GameObject fuelPrefab;
  float screenW = Screen.width/2;
  float screenH = Screen.height/2;


  void Start() {
    DropFuel();
  }

  void Update() {

  }

  void DropFuel() {
    StartCoroutine(DropFuelRoutine());
    IEnumerator DropFuelRoutine() {
      float wait = Random.Range(3,5);

      while(true){
        Vector3 dropOff = new Vector3(Random.Range(-12f,12f),7.5f,0);
        yield return new WaitForSeconds(0);
        Instantiate(fuelPrefab, dropOff, Quaternion.identity);
      }
    }
  }
}
