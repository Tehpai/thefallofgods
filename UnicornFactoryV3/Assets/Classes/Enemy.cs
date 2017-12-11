using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy {

    //o gameobject do inimigo
    private GameObject enemy;
    public GameObject EnemyP
    {
        get { return enemy; }
        set { enemy = value; }
    }
    //a sua vida
    private Health health;
    public Health Health
    {
        get { return health; }
        set { health = value; }
    }
    //um indicador de se está vivo ou nao
    private bool alive;
    public bool Alive
    {
        get { return alive; }
        set { alive = value; }
    }


    public Enemy(string enemyPath)
    {
        //inicialização de variáveis e instanciação do inimigo
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
       
       
        
    }

    public void Kill()//funcao que destroi o objeto do inimigo
    {
        MonoBehaviour.Destroy(enemy);
        Alive = false;
    }
}
