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

    int clickCount;



    

    public UiController uiScript;

    EntityList enemyList;
    HeroList heroList;

    Camera mainCameraController;
    Vector3 difHeroCamera;


    // Use this for initialization
    void Start () {

        //excerto de debug

        Formulas f = new Formulas();

        Component dropedComp;
        do
        {
            dropedComp = f.GetDropsByRarity(EnemyType.Common);
        } while (dropedComp == null);
        

        //fim do excerto

        mainCameraController = GameObject.Find("Main Camera").GetComponent<Camera>();
        difHeroCamera = new Vector3(Math.Abs(uiScript.MainCamera.transform.position.x - hero.transform.position.x), Math.Abs(uiScript.MainCamera.transform.position.y - hero.transform.position.y));
        CameraScript.difHeroCamera = difHeroCamera;

        clickCount = 0;

        //criar e adicionar os inimigos à lista
        enemyList = new EntityList();

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

        //se nao houver inimigos e o heroi nao tiver a ser movido
        if (enemyList.entities.Count == 0 && !heroBeingMoved)
        {
            AdvanceToNextWave();
            uiScript.stage.Finished = true;
            //indicação da nova posição do heroi,de modo a se ir movendo para la frame a frame
            newHeroPosition.x = hero.transform.position.x + 10.8f;
            enemyList.StartingPosition = newHeroPosition;
            heroBeingMoved = true;
            

        }
        //se o heroi estiver a ser movido
        if (heroBeingMoved)
        {
            
            //dar ao heroi uma velocidade constante
            Rigidbody2D heroRigid = hero.GetComponent<Rigidbody2D>();
            heroRigid.velocity = heroRigid.velocity.normalized * 5f;
            
            //se a diferença entre a posição atual e a nova posição que pertence ao heroi for pequena o suficiente, manda-se parar o heroi
            if (Math.Abs(Vector3.Distance(hero.transform.position, newHeroPosition)) > 0.5)
            {
                
            }
            else
            {
                

                //mandar parar o heroi e spawnar novo inimigos
                heroRigid = hero.GetComponent<Rigidbody2D>();
                heroRigid.velocity = new Vector2(0f, heroRigid.velocity.y);
                heroBeingMoved = false;

                enemyList.AddEnemyToScene(hero.transform.position);
                enemyList.AddEnemyToScene(hero.transform.position);
                enemyList.AddEnemyToScene(hero.transform.position);


            }
        }
            
        if(clickCount%10 == 0 && clickCount != 0)
        {
            //SpriteRenderer heroSprender = hero.GetComponent<SpriteRenderer>();
            //Sprite sp = (Sprite)Resources.Load("CharAbility");
            //hero.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load("CharAbility");
            SpriteRenderer s = hero.GetComponent<SpriteRenderer>();
            Sprite spritetemp = new Sprite();


            s.sprite = (Sprite)Resources.Load<Sprite>("CharAbility");

            clickCount++;

        }

        //se ainda houver inimigos, quando se pressiona o rato os inimigos sao danificados
        if (enemyList.entities.Count != 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
                clickCount++;
                enemyList.DamageEnemies(DamageTypeEnum.Global_Damage);
            }
        }
    }

    public void AdvanceToNextWave()
    {
        
        Rigidbody2D heroRigid = hero.GetComponent<Rigidbody2D>();
        heroRigid.velocity = new Vector2(5f, heroRigid.velocity.y);
        
        
        


    }




}
