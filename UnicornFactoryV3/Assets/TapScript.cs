//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine;

//public class TapScript : MonoBehaviour {

//    GameObject[] enemies; // old instance of enemy
//    GameObject[] healthBars;
//    GameObject healthBar;
//    int health;
//    Text tmptxt;
//    List<Health> hp;
//    List<Enemy> enemies2 = new List<Enemy>(); // new instance of enemy

//    // Use this for initialization
//    void Start()
//    {
//        health = 100;
//        enemies = GameObject.FindGameObjectsWithTag("enemy");
        


//        enemies2.Add(new Enemy("enemy prefab"));

        

//        return;
//    }

    
//    void Update () {

        


//    }
//    private void OnMouseDown()
//    {
        
        
//        int cnt = 0;
//        foreach (Enemy en in enemies2)
//        {
           

//            en.Health.OnHit();

           
//        }
//    }
    
//    //private void EnemyKilled()
//    //{
//    //    Text orbText = GameObject.FindGameObjectWithTag("orb").GetComponent<Text>();
//    //    orbText.text = "Enemy Killed";
//    //    int reward = Random.Range(0, 10);
//    //    orbText.text = reward.ToString() + " orbs received";
//    //    health = 100;
        

        
//    //}
//}
