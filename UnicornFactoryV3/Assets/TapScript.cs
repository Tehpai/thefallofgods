using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TapScript : MonoBehaviour {

    GameObject[] enemies; // old instance of enemy
    GameObject[] healthBars;
    GameObject healthBar;
    int health;
    Text tmptxt;
    List<Health> hp;
    List<Enemy> enemies2; // new instance of enemy


    int orbs;



    // Use this for initialization
    void Start()
    {
        health = 100;
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        healthBars = GameObject.FindGameObjectsWithTag("health"); // old implementation of health bar
        healthBar = GameObject.FindGameObjectWithTag("health2"); // new implementation of health bar
        hp = new List<Health>();
        enemies2 = new List<Enemy>();

        enemies2.Add(new Enemy("enemy prefab"));
        

        foreach (GameObject h in healthBars)
        {
            tmptxt = h.GetComponent<Text>();
            tmptxt.text = health.ToString();
        }
    }

    // Update is called once per frame
    void Update () {

       

    }
    private void OnMouseDown()
    {
        
        
        int cnt = 0;
        foreach (Enemy en in enemies2)
        {
            //en.Health = 
            //Transform healthCnt = GameObject.FindGameObjectWithTag("health2").GetComponent<Transform>();
            //hp.Add(new Health(healthCnt));

            hp[cnt].OnHit();

            //foreach (GameObject h in healthBars)
            //{
            //    if (health <= 95)
            //        EnemyKilled();
            //    health--;
            //    tmptxt = h.GetComponent<Text>();
            //    tmptxt.text = health.ToString();
            //    Debug.Log(g.tag + cnt + "was hit");
            //    cnt++;
            //}
        }
    }
    //private void EnemyKilled()
    //{
    //    Text orbText = GameObject.FindGameObjectWithTag("orb").GetComponent<Text>();
    //    orbText.text = "Enemy Killed";
    //    int reward = Random.Range(0, 10);
    //    orbText.text = reward.ToString() + " orbs received";
    //    health = 100;
        

        
    //}
}
