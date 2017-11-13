using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    GameObject enemy;
    private Health health;
    public Health Health
    {
        get { return health; }
        set { health = value; }
    }

    public Enemy(string enemyPath)
    {
        enemy = (GameObject)Instantiate(Resources.Load(enemyPath));
        health = new Health(enemy.GetComponentInChildren<Transform>());
    }

	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //void onKilled()
    //{
    //    Object.Destroy(enemy);
    //}
}
