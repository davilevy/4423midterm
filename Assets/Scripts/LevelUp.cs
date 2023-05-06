using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{

  public LevelSlowDown slowDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void onNewLevel()
    {
        slowDown.LevelTime();
     
    }
}
