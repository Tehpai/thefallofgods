using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    GameObject player;
    Transform playerTrans;

    // Use this for initialization
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {


        player = GameObject.Find("Character");
        playerTrans = player.GetComponent<Transform>();
        transform.position = new Vector3(playerTrans.position.x, playerTrans.position.y, transform.position.z);



    }
}
