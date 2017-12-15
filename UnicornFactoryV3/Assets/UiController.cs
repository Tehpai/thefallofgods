//using Assets.Classes;
using Assets.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{

    public GameObject mainUi;
    public Canvas bgCanvas;

    public Stage stage;
    public Camera MainCamera;

    String bgPrefab;

    public int stageCount;

    // Use this for initialization
    void Start()
    {
        stageCount = 1;
        stage = new Stage(mainUi,bgCanvas, "backgroundf");

    }

    // Update is called once per frame
    void Update()
    {
       
        if (stage.Finished)
        {
            
            stage.NextRound();
            stage.Finished = false;
        }

    }

    //INVOCADO POR OUTRO SCRIPT
    
    
}
