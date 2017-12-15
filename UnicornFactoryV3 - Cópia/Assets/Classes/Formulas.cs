using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Formulas {

    public Text stageText = GameObject.Find("Stage").GetComponent<Text>();
    int currentStage = 0;

    Array componentArray;
 

	public float novaVidaInimigo()
    {
        currentStage = int.Parse(stageText.text) - 1;
        return Mathf.Pow(1.25f, currentStage) * 100;
    }
    public Component GetDropsByRarity(EnemyType enemyType)
    {
        if(enemyType == EnemyType.Common)
        {
            componentArray = Enum.GetValues(typeof(ComponentEnum));

            foreach(ComponentEnum s in componentArray)
            {
                if(new System.Random().Next(1,100) <= 5) // representa uma chance de 5% imbutida num booleano
                {
                    Debug.Log(s + "dropado");
                    return new Component(s);
                    
                }
            }
            
        }
        return null;
    }
}
