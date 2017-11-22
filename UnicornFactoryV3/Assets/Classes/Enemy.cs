using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy {

    private GameObject enemy;
    public GameObject EnemyP
    {
        get { return enemy; }
        set { enemy = value; }
    }
    private Health health;
    public Health Health
    {
        get { return health; }
        set { health = value; }
    }
    private bool alive;
    public bool Alive
    {
        get { return alive; }
        set { alive = value; }
    }


    public Enemy(string enemyPath)
    {
        Alive = true;
        GameObject enemytmp = (GameObject)Resources.Load(enemyPath);
        

            foreach(Transform child in enemytmp.GetComponentInChildren<Transform>())
            {
                if (child != null)
                {
                    //EditorUtility.DisplayDialog("healthbarAssociated", "healthbarAssociated", "ok");
                    this.health = new Health(child);
                   
                }
            }
        enemy = MonoBehaviour.Instantiate(enemytmp);

       
    }

	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void HitEnemy()
    {
        //Transform newHealthTrans = Health.OnHit();
        //foreach (Transform child in enemy.GetComponentInChildren<Transform>())
        //{
        //    if (child != null)
        //    {
        //        child.transform.localScale = newHealthTrans.localScale;

        //    }
        //}
       
        
    }

    public void Kill()
    {
        MonoBehaviour.Destroy(enemy);
        Alive = false;
    }
}
