using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyList
{

    public List<Enemy> enemies;
    private Vector3 startingPosition;

    

    public EnemyList()
    {
        startingPosition = new Vector3(28.2f, -0.5f);
        enemies = new List<Enemy>();
    }
    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    void PositionEnemies()
    {
        for (int cnt = 0; cnt < enemies.Count; cnt++)
        {
            enemies[cnt].EnemyP.transform.position = new Vector3(startingPosition.x + (cnt * 3), startingPosition.y);
        }
    }
    void PositionEnemies(Vector3 spawnPoint)
    {
        for (int cnt = 0; cnt < enemies.Count; cnt++)
        {
            enemies[cnt].EnemyP.transform.position = new Vector3(spawnPoint.x + (cnt * 3), spawnPoint.y);
        }
    }

    public void AddEnemyToScene()
    {

        enemies.Add(new Enemy("enemy prefab"));
        PositionEnemies();
    }
    public void AddEnemyToScene(Vector3 spawnPoint)
    {
        Vector3 newEnemySpawn = new Vector3(spawnPoint.x + 3, spawnPoint.y);
        enemies.Add(new Enemy("enemy prefab"));
        PositionEnemies(newEnemySpawn);
    }

    public void DamageEnemies(DamageTypeEnum.DamageTypes enumDamage)
    {
        if (enumDamage == DamageTypeEnum.DamageTypes.Global_Damage)
        {

            foreach (Enemy e in enemies)
            {


                foreach (Transform child in e.EnemyP.GetComponentInChildren<Transform>())
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
            if (enumDamage == DamageTypeEnum.DamageTypes.Single_RandomTarget_Damage)
        {
            
            int randEnemyidx = Random.Range(0, enemies.Count);
            

            foreach (Transform child in enemies[randEnemyidx].EnemyP.GetComponentInChildren<Transform>())
            { 
                if (child != null)
                {
                    Transform newHealthTrans = enemies[randEnemyidx].Health.OnHit();
                    if (enemies[randEnemyidx].Health.AmountOfHp <= 0)
                    {
                        enemies[randEnemyidx].Kill();
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

        for (int i = 0; i < enemies.Count && enemies.Count != 0;)
        {

            if (!enemies[i].Alive)
            {
                enemies.RemoveAt(i);
            }
            else
                i++;


        }
    }


}
