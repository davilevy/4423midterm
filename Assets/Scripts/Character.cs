using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{

  [Header("Movement")]
  public float speed = 10f;
  public float forceMultiplier = 10f;

  [Header("Outside Objects")]
  Rigidbody2D _rb2d;

  [Header("Text Elements")]
  int points = 0;
  public Text pointText;
    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
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
        pointText.text = "Score: " + points.ToString();
      }
      if(other.tag == "Brick"){
        Debug.Log("Game Over");
        SceneManager.LoadScene("MainMenu");
      }
    }

    private void OnTriggerExit2D(Collider2D other) {

    }
}