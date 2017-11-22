using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    GameObject[] enemies;

	// Use this for initialization
	void Start () {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButton(0))
        {
            foreach(GameObject g in enemies)
            {
                Debug.Log("enemy hit");
                //SpriteRenderer sprender = g.GetComponent<SpriteRenderer>();

                //sprender.color = new Color(100,0,0);
            }
        }
		
	}
}
