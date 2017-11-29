﻿//using Assets.Classes;
using Assets.Classes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{

    GameObject mainUi;
    public Stage stage;

    // Use this for initialization
    void Start()
    {
        mainUi = GameObject.FindGameObjectWithTag("mainui");
        stage = new Stage(mainUi);
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
