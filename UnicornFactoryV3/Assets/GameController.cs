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

    //Hero hero2;

    public UiController uiScript;

    EnemyList enemyList;

    Camera mainCameraController;
    Vector3 difHeroCamera;


    // Use this for initialization
    void Start () {

        mainCameraController = GameObject.Find("Main Camera").GetComponent<Camera>();
        difHeroCamera = new Vector3(Math.Abs(uiScript.MainCamera.transform.position.x - hero.transform.position.x), Math.Abs(uiScript.MainCamera.transform.position.y - hero.transform.position.y));
        CameraScript.difHeroCamera = difHeroCamera;


        enemyList = new EnemyList();

        enemyList.AddEnemyToScene(hero.transform.position);
        enemyList.AddEnemyToScene(hero.transform.position);
        enemyList.AddEnemyToScene(hero.transform.position);

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

            if (Math.Abs(Vector3.Distance(hero.transform.position, newHeroPosition)) > 0.5)
            {
                
            }
            else
            {
                //uiScript.stage.bgObjecttmp.transform.position = new Vector3(uiScript.stage.bgObjecttmp.transform.position.x + uiScript.stage.bgIncrement, uiScript.stage.bgObjecttmp.transform.position.y, uiScript.stage.bgObjecttmp.transform.position.z);

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
                enemyList.DamageEnemies(DamageTypeEnum.DamageTypes.Single_RandomTarget_Damage);
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
