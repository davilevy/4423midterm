using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDrop : MonoBehaviour
{
  public GameObject brickPrefab;
    // Start is called before the first frame update
    void Start()
    {
        DropBrick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropBrick() {
      StartCoroutine(DropBrickRoutine());
      IEnumerator DropBrickRoutine() {
        float wait = Random.Range(3,5);

        while(true){
          Vector3 headBonk = new Vector3(Random.Range(-12f,12f),7.5f,0);
          yield return new WaitForSeconds(Random.Range(1,5));
          Instantiate(brickPrefab, headBonk, Quaternion.identity);
        }
      }
    }
}
