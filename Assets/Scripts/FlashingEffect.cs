
using UnityEngine;
using UnityEngine.UI;

public class FlashingEffect : MonoBehaviour
{
  public Camera background ;
  public Text LevelText;

  public Color red => Color.red;
  public Color black => Color.black;
  public Color white => Color.white;

  void Start() {
  }

  public void Update() {
    background.backgroundColor = Lerp(Color.gray, white);
    LevelText.color = Lerp(white, red);
  }

  public Color Lerp(Color firstColor, Color secondColor) {
    return Color.Lerp(firstColor, secondColor, Mathf.Sin(Time.time));
  }
}
