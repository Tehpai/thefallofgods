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
        
        

        //mainCam.rect = new Rect(m_ViewPositionX,m_ViewPositionY,m_ViewWidth,m_ViewHeight);
        //mainCam.rect = new Rect(m_ViewPositionX, m_ViewPositionY, m_ViewWidth, m_ViewHeight);
        
        
        m_ViewPositionX = -119.68f;
        m_ViewPositionY = -197.1f;
        m_ViewWidth = 458.74f;
        m_ViewHeight = 484.13f;
        mainCam.rect = new Rect(m_ViewPositionX, m_ViewPositionY, m_ViewWidth, m_ViewHeight);






    }

    // Update is called once per frame
    void Update()
    {


        player = GameObject.Find("sampleHero");
        playerTrans = player.GetComponent<Transform>();
        transform.position = new Vector3(playerTrans.position.x + difHeroCamera.x, playerTrans.position.y + difHeroCamera.y, transform.position.z + difHeroCamera.z);
        
        mainUi.transform.position = new Vector3(transform.position.x, transform.position.y, mainUi.transform.position.z); 
        //transform.position = new Vector3(playerTrans.position.x, playerTrans.position.y, -20);




    }
}
