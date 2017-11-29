using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIScript : MonoBehaviour {

    GameObject player;
    float speed = 0f; //velocidade do inimigo
    Rigidbody2D enemyRigid;
    //bool facingRight;
                     
    void Start () {

        player = GameObject.Find("Character");
        enemyRigid = GetComponent<Rigidbody2D>();



    }
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x > player.transform.position.x)
        {
            
            speed = 2f;

        }

        

        enemyRigid.velocity = new Vector3(-1 * speed, enemyRigid.velocity.y);



    }


}
