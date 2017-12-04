using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    

    GameObject player;
    Transform playerTrans;

    public static Vector3 difHeroCamera;
    public GameObject mainUi;

    float m_ViewPositionX, m_ViewPositionY, m_ViewWidth, m_ViewHeight;
    GameObject bgCanvas; // é usado aqui para definir o viewport retangular da camera


    // Use this for initialization
    void Start()
    {
        bgCanvas = GameObject.Find("bgCanvas");

        Camera mainCam = this.GetComponent<Camera>();
        mainCam.rect = bgCanvas.GetComponent<RectTransform>().rect;

        m_ViewPositionX = 27.43f;
        m_ViewPositionY = 2.022f;
        m_ViewWidth = 239.36f;
        m_ViewHeight = 394.2f;
        
        



    }

    // Update is called once per frame
    void Update()
    {


        player = GameObject.Find("sampleHero");
        playerTrans = player.GetComponent<Transform>();
        //transform.position = new Vector3(playerTrans.position.x + difHeroCamera.x, playerTrans.position.y + difHeroCamera.y, transform.position.z + difHeroCamera.z);
        mainUi.transform.position = new Vector3(transform.position.x, transform.position.y, mainUi.transform.position.z); //é o que quero fazer mas os backgrounds secalhar teem que estar fora do canvas




    }
}
