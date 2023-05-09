using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public void QuitToMainMenu() {
      SceneManager.LoadScene("MainMenu");
    }

    public void SaveProgress() {
      PlayerPrefs.SetInt("Level",Character.instance.level);
      PlayerPrefs.SetInt("Score",Character.instance.points);
    }
}
