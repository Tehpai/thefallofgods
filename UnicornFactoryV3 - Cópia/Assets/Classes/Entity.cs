using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Entity {

    //o gameobject do inimigo
    private GameObject entity;
    public GameObject EntityP
    {
        get { return entity; }
        set { entity = value; }
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


    public Entity(string entityPath)
    {
        //inicialização de variáveis e instanciação do inimigo
        Alive = true;
        GameObject entitytemp = (GameObject)Resources.Load(entityPath);
        

            foreach(Transform child in entitytemp.GetComponentInChildren<Transform>())
            {
                if (child != null)
                {
                    //EditorUtility.DisplayDialog("healthbarAssociated", "healthbarAssociated", "ok");
                    this.health = new Health(child);
                   
                }
            }
        entity = MonoBehaviour.Instantiate(entitytemp);

       
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
        MonoBehaviour.Destroy(entity);
        Alive = false;
    }
}
