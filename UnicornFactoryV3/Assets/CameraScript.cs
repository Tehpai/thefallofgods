using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    GameObject player;
    Transform playerTrans;

    public static Vector3 difHeroCamera;
    public GameObject mainUi;
    

    // Use this for initialization
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {


        player = GameObject.Find("sampleHero");
        playerTrans = player.GetComponent<Transform>();
        transform.position = new Vector3(playerTrans.position.x + difHeroCamera.x, playerTrans.position.y + difHeroCamera.y, transform.position.z + difHeroCamera.z);
        //mainUi.transform.position = new Vector3(transform.position.x, transform.position.y, mainUi.transform.position.z); //é o que quero fazer mas os backgrounds secalhar teem que estar fora do canvas




    }
}
