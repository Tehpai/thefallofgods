using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
    private const float ORIGINAL_HEALTHBAR_SIZE = 2.446577f;
    private int amountofHP;
    public int AmountOfHp
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
        AmountOfHp = 100;
        this.enemyHealthBar = enemyHealthBar;
        
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void OnHit()
    {

        amountofHP--;
        float newScale = enemyHealthBar.localScale.x - ORIGINAL_HEALTHBAR_SIZE/10;
        enemyHealthBar.transform.localScale = new Vector3(newScale, enemyHealthBar.localScale.y);
        if (amountofHP == 90)
        {
            EnemyKilled();
            return;
        }
        
    }

    private void EnemyKilled()
    {
        Text orbText = GameObject.FindGameObjectWithTag("orb").GetComponent<Text>();
        
        int reward = Random.Range(0, 10);
        orbText.text = "Enemy Killed  | " + reward.ToString() + " orbs received";
        amountofHP = 100;
        




    }
}

