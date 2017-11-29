using Assets.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject hero; // debugging variable
    Vector3 newHeroPosition; // debugging variable
    bool heroBeingMoved;

    public Transform debugBgTrans;

    Hero hero2;

    public UiController uiScript;

    EnemyList enemyList;
    Camera mainCameraController;
    // Use this for initialization
    void Start () {

        mainCameraController = GameObject.Find("Main Camera").GetComponent<Camera>();

        enemyList = new EnemyList();

        enemyList.AddEnemyToScene();
        enemyList.AddEnemyToScene();
        enemyList.AddEnemyToScene();

        //hero2 = new Hero();
        
        
        newHeroPosition = new Vector3(hero.transform.position.x, hero.transform.position.y);
        heroBeingMoved = false;


    }
	
	// Update is called once per frame
	void Update () {

        
		
	}
    private void FixedUpdate()
    {

        if (enemyList.enemies.Count == 0 && !heroBeingMoved)
        {
            AdvanceToNextWave();
            uiScript.stage.Finished = true;
            newHeroPosition.x = hero.transform.position.x + 11;
            enemyList.StartingPosition = newHeroPosition;
            heroBeingMoved = true;
            

        }
        if (heroBeingMoved)
        {
            Rigidbody2D heroRigid = hero.GetComponent<Rigidbody2D>();
            heroRigid.velocity = heroRigid.velocity.normalized * 5f;

            if (Math.Abs(Vector3.Distance(hero.transform.position,newHeroPosition)) > 1)
                return;
            else
            {
                heroRigid = hero.GetComponent<Rigidbody2D>();
                heroRigid.velocity = new Vector2(0f, heroRigid.velocity.y);
                heroBeingMoved = false;

                enemyList.AddEnemyToScene(hero.transform.position);
                enemyList.AddEnemyToScene(hero.transform.position);
                enemyList.AddEnemyToScene(hero.transform.position);

            }
        }
            



        if (enemyList.enemies.Count != 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
                enemyList.DamageEnemies(DamageTypeEnum.DamageTypes.Global_Damage);
            }
        }
    }

    public void AdvanceToNextWave()
    {
        
        Rigidbody2D heroRigid = hero.GetComponent<Rigidbody2D>();
        heroRigid.velocity = new Vector2(5f, heroRigid.velocity.y);
        //heroRigid.velocity = 5f * (heroRigid.velocity.normalized);



        //enemyList.AddEnemyToScene();
        //enemyList.AddEnemyToScene();
        //enemyList.AddEnemyToScene();


    }




}
