using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPauseMenu : MonoBehaviour
{
  public void OpenInGameMenu() {
    GetComponent<Canvas>().enabled = true;
  }

  public void CloseInGameMenu() {
    Time.timeScale = 1.0f;
    GetComponent<Canvas>().enabled = false;
  }
}