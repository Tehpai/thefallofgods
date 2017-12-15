using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityList
{

    public List<Entity> entities;
    private Vector3 startingPosition;
    public Vector3 StartingPosition
    {
        get
        {
            return startingPosition;
        }
        set
        {
            startingPosition = value;
        }
        
    }
    GameObject hero;

    

    public EntityList()
    {
        hero = GameObject.Find("sampleHero");
        StartingPosition = new Vector3(hero.transform.position.x + 5, hero.transform.position.y);
        entities = new List<Entity>();
    }
    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    void PositionEntities()
    {
        Vector2 positionIncrement = new Vector2(1, 2);
        bool xCoordAdjust = false;
        for (int cnt = 0; cnt < entities.Count; cnt++, xCoordAdjust = !xCoordAdjust)
        {
            
            entities[cnt].EntityP.transform.position = new Vector3(StartingPosition.x + positionIncrement.x, StartingPosition.y + (cnt*positionIncrement.y));
            if (xCoordAdjust)
                positionIncrement.x = 1;
            else
                positionIncrement.x = -1;
        }
    }
    //void PositionEnemies(Vector3 spawnPoint)
    //{
    //    bool xCoordAdjust = false;
    //    for (int cnt = 0; cnt < enemies.Count; cnt++, xCoordAdjust = !xCoordAdjust)
    //    {

    //        enemies[cnt].EnemyP.transform.position = new Vector3(StartingPosition.x + positionIncrement.x, StartingPosition.y + (cnt * positionIncrement.y));
    //        if (xCoordAdjust)
    //            positionIncrement.x = 1;
    //        else
    //            positionIncrement.x = -1;
    //    }
    //}

    public void AddEnemyToScene()
    {

        entities.Add(new Entity("enemy prefab"));
        PositionEntities();
    }
    public void AddEnemyToScene(Vector3 spawnPoint)
    { 
        
        Vector3 newEnemySpawn = new Vector3(spawnPoint.x + 5, spawnPoint.y);
        if (newEnemySpawn.x > startingPosition.x)
            StartingPosition = newEnemySpawn;
        entities.Add(new Entity("enemy prefab"));
        PositionEntities();
    }

    public void DamageEnemies(DamageTypeEnum enumDamage)
    {
        if (enumDamage == DamageTypeEnum.Global_Damage)
        {

            foreach (Entity e in entities)
            {


                foreach (Transform child in e.EntityP.GetComponentInChildren<Transform>())
                {

                    if (child != null)
                    {
                        Transform newHealthTrans = e.Health.OnHit();
                        if (e.Health.AmountOfHp <= 0)
                        {
                            e.Kill();
                            break;
                        }
                        child.transform.localScale = newHealthTrans.localScale;

                    }
                    else
                        break;
                }
            }



        }
        else
            if (enumDamage == DamageTypeEnum.Single_RandomTarget_Damage)
        {
            
            int randEnemyidx = UnityEngine.Random.Range(0, entities.Count);
            

            foreach (Transform child in entities[randEnemyidx].EntityP.GetComponentInChildren<Transform>())
            { 
                if (child != null)
                {
                    Transform newHealthTrans = entities[randEnemyidx].Health.OnHit();
                    if (entities[randEnemyidx].Health.AmountOfHp <= 0)
                    {
                        entities[randEnemyidx].Kill();
                        break;
                    }
                    child.transform.localScale = newHealthTrans.localScale;

                }
                else
                    break;
            }
        }

            KillEnemiesInCurrentFrame();




        }
    public void KillEnemiesInCurrentFrame()
    {

        for (int i = 0; i < entities.Count && entities.Count != 0;)
        {

            if (!entities[i].Alive)
            {
                entities.RemoveAt(i);
            }
            else
                i++;


        }
    }


}
