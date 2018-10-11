using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject effect;
    public GameObject gameOver;
    public GameObject popSound;
    // public Animator camAnim;
    public Text healthDisplay;


    private Vector2 targetPos;
    public float Yincrement;
    public float speed;

    public float maxHeight;
    public float minHeight;

    public int health = 3;



	void Update () {
        healthDisplay.text = health.ToString();
         
        if(health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

	    if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(popSound, transform.position, Quaternion.identity);
          // camAnim.SetTrigger("shake");
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(popSound, transform.position, Quaternion.identity);
            // camAnim.SetTrigger("shake");
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }
	}
}

