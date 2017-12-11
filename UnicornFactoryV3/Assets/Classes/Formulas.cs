using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Formulas {

    public Text stageText = GameObject.Find("Stage").GetComponent<Text>();
    int currentStage = 0;
 

	public float novaVidaInimigo()
    {
        currentStage = int.Parse(stageText.text) - 1;
        return Mathf.Pow(1.25f, currentStage) * 100;
    }
    private void Start()
    {
        
       
    }
}
