using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
  private float characterHeight;
  private float characterWidth;

  [Header("Movement")]
  public float speed = 20f;
  public float forceMultiplier = 10f;

  [Header("Outside Objects")]
  Rigidbody2D _rb2d;

  [Header("Text Elements")]
  public int points = 0;
  public int level = 1;
  public Text levelText;
  public Text pointText;
  
  [SerializeField]
  public AudioClip crash;
  public AudioSource audioPlayer;

  public static Character instance; 
  private void Awake() => instance = this;
  private LevelUp levelup;
    // Start is called before the first frame update
  void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        // characterHeight = GetComponent<SpriteRenderer>.bounds.size.y / 2;
        // characterWidth = GetComponent<SpriteRenderer>.bounds.size.x / 2;
    }

    // Update is called once per frame
  void Update()
    {

    }

    void FixedUpdate() 
    {
        _rb2d.MovePosition(transform.position + (new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0) * speed * Time.fixedDeltaTime));
        // This is the spacy movement:
        //rb2d.AddForce(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * forceMultiplier * Time.fixedDeltaTime );
        // This is the exact movement:
        //rb2d.velocity = (new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0)) * speed;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
      if(other.tag == "Fuel"){
        Destroy(other.gameObject);
        points+=1;
        if (points % 3 == 0) {
          level += 1;
          levelup.onNewLevel();
        }
        other.GetComponent<RocketFuel>().Catch();
        pointText.text = "Level: " + level.ToString();
      }
      if(other.tag == "Brick"){
        Debug.Log("Game Over");
        other.GetComponent<Brick>().Crash();
        SceneManager.LoadScene("MainMenu");
      }
    }

    private void OnTriggerExit2D(Collider2D other) {

    }
}