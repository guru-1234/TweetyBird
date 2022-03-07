using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird : MonoBehaviour
{

    public Gamemanager gameManager;
    

    //UPWARD THRUST FORCE


    public Rigidbody2D TweetyBirdBody;

    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
    
        //GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //ONLY WHEN SPECIFIC KEY IS PRESSED THRUST WORKS

        foreach(Touch touch in Input.touches)
        {
            if(touch.fingerId == 0)
            {
               TweetyBirdBody.velocity = Vector2.up*velocity; 
            }
        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
             //GetComponent<Rigidbody2D>().AddForce(Vector2.up * (thrust)*2);
             TweetyBirdBody.velocity = Vector2.up*velocity;
        }*/
           
        
    }

    private void OnCollisionEnter2D(Collision2D coll) 
    {
        gameManager.GameOver();
    }
    
}
