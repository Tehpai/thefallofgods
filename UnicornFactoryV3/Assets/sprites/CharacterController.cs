using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    Rigidbody2D character;
    float speed = 0f; //velocidade da personagem
    //float speedfct = 0.2f;
    Animator anim;
    Vector3 scale;
    bool facingRight = false;

    // Use this for initialization
    void Start()
    {


        anim = GetComponent<Animator>();
        character = GetComponent<Rigidbody2D>();
        scale = new Vector3(-1, 0);
       

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    IncreaseSpeed();
        //}

        KeyCode key = new KeyCode();
        Input.GetKey(key);

        if (key == KeyCode.D)
        {
            speed = 5f;
            anim.SetFloat("speed", speed);
            
           

        }
        else
        if (Input.GetKeyUp(KeyCode.D))
        {
            speed = 0f;
            anim.SetFloat("speed", speed);



        }
        else
        if (Input.GetKeyDown(KeyCode.A))
        {

            
            speed = 5f;
            anim.SetFloat("speed", speed);
           

        }
        else
        if (Input.GetKeyUp(KeyCode.A))
        {
            speed = 0f;
          


        }
        else
            if(Input.GetKeyUp(KeyCode.E))
            {
            HabilityScript hab = GetComponent<HabilityScript>();
            hab.BoltOfOlympus();
            Debug.Log("Bolt Of Olympus Activated");


            }


        float move = Input.GetAxis("Horizontal");

        if (move > 0 && facingRight)
            Flip();
        else
        if (move < 0 && !facingRight)
            Flip();

        character.velocity = new Vector2(move * speed, character.velocity.y);

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void FixedUpdate()
    {
        

    }

    public void IncreaseSpeed()
    {
        for(float t = 0;character.velocity.x < 5f; t+=0.2f)
        {
            character.velocity = new Vector2(1*t, character.velocity.y);
        }
    }
}
