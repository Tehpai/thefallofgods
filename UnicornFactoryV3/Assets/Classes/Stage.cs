using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Classes
{
    public class Stage
    {
        public Canvas bgCanvas;

        public String bgPrefab; //a string do nome do prefab do background
        public GameObject bgObject; // o gameObject do background
        //public GameObject bgCanvas; // o gameObject do ui principal


        public List<GameObject> bgManager; //uma lista de backgrounds para dar o efeito de movimento

        public float bgIncrement;
        //GameObject stageUi;
        GameObject mainUi;
        //private bool finished;
        public bool Finished
        {
            get;
            set;
        }
        //private float initBgPos;

        public Stage(GameObject mainUi,Canvas bgCanvas, String bgPrefab) // inicializa as variáveis e instancia o primeiro conjunto de inimigos
        {
            //o bgIncrement é uma variavel predefinida para saber onde o proximo bg deve ser spawnado
            bgIncrement = 10.30f;
            this.mainUi = mainUi;
            bgManager = new List<GameObject>();

            this.bgPrefab = bgPrefab;
            //this.bgCanvas = bgCanvas;
            
            //instanciacao de inimigos

            bgObject = ((GameObject)Resources.Load(bgPrefab));

            bgCanvas = mainUi.GetComponent<Canvas>();

            bgManager.Add(MonoBehaviour.Instantiate(bgObject, bgCanvas.transform));
            bgManager.Add(MonoBehaviour.Instantiate(bgObject,bgCanvas.transform));

            bgManager.Add(MonoBehaviour.Instantiate(bgObject, bgCanvas.transform));
            bgManager.Add(MonoBehaviour.Instantiate(bgObject, bgCanvas.transform));


            //posicionamento dos backgrounds
            float bgloopTmpIdx = -(bgIncrement);
            foreach(GameObject g in bgManager)
            {
                //g.transform.SetParent(mainUi.transform, false);
                g.transform.position = new Vector3(g.transform.position.x + bgloopTmpIdx, g.transform.position.y, g.transform.position.z);
                bgloopTmpIdx += bgIncrement;
            }

           


          
        }

        public void NextRound() //funcao que avança à proxima ronda (stage)
        {
            Text stage = null;
            
            //por o numero do stage no objeto correspondente
            foreach (Text g in mainUi.GetComponentsInChildren<Text>())
            {
                if (g.name == "Stage")
                    stage = g;

            }
            

            try
            {
                
                stage.text = (int.Parse(stage.text) + 1).ToString();

                


                //posicionar os backgrounds de novo,agora que o heroi vai avançar à proxima ronda
                float bgloopTmpIdx = -(bgIncrement)*2;
                foreach (GameObject g in bgManager)
                {
                   
                    g.transform.position = new Vector3(g.transform.position.x + bgIncrement, g.transform.position.y, g.transform.position.z);
                    bgloopTmpIdx += bgIncrement;
                }

            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }







    }
}
