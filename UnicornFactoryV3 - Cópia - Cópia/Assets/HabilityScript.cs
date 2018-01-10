using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabilityScript : MonoBehaviour {

    GameObject playerObject;
    CharacterController charCtrl;


    // Use this for initialization
    public void Start()
    {

        playerObject = GameObject.Find("Character");
        charCtrl = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {





    }

    public void BoltOfOlympus()
    {

    }
}
