using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health
{
    private Vector3 originalHealthBarScale = new Vector3(2.080382f, 0.2002107f);

    Formulas f = new Formulas();

    private float amountofHP;
    public float AmountOfHp
    {
        get { return amountofHP; }
        set { amountofHP = value; }

    }
    private Transform enemyHealthBar;
    public Transform EnemyHealthBar
    {
        get { return enemyHealthBar; }
        set { enemyHealthBar = value; }

    }
    
    public Health(Transform enemyHealthBar)
    {
        //AmountOfHp = 100;//temporary debug inicialization
        AmountOfHp = f.novaVidaInimigo();
        this.enemyHealthBar = enemyHealthBar;
        //this.enemyHealthBar.localScale = originalHealthBarScale;
        this.enemyHealthBar.localScale = new Vector3((AmountOfHp / f.novaVidaInimigo()) * originalHealthBarScale.x,this.enemyHealthBar.localScale.y);
        //AmountOfHp = 100; //primary inicialization


    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public Transform OnHit()
    {
        
        amountofHP-=10;
        //float newScale = enemyHealthBar.localScale.x - originalHealthBarScale.x/10;
        float newHealthScale = (AmountOfHp / f.novaVidaInimigo()) *originalHealthBarScale.x;
        enemyHealthBar.localScale = new Vector3(newHealthScale, enemyHealthBar.localScale.y);
        //if (amountofHP <=0)
        //{
        //    EnemyKilled();
        //    return null;
        //}
        return enemyHealthBar;
      

        
    }

    private void EnemyKilled()
    {
        Text orbText = GameObject.FindGameObjectWithTag("orb").GetComponent<Text>();
        
        int reward = Random.Range(0, 10);
        orbText.text = "Enemy Killed  | " + reward.ToString() + " orbs received";
        amountofHP = 100;
        




    }
}

