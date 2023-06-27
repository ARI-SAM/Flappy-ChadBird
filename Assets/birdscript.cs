using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour

{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public AudioSource audio;
    public AudioClip jumpClip;

    public AudioClip failClip;
    //public AudioClip scoreClip;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }


    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            audio.clip = jumpClip;
            audio.Play();

            myRigidbody.velocity = Vector2.up * flapstrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.clip = failClip;
        audio.Play();

        logic.gameOver();
        birdIsAlive= false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            audio.clip = failClip;
            audio.Play();

            logic.gameOver();
            birdIsAlive = false;
        }

    }

}
