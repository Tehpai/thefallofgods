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

        public String bgPrefab;
        public GameObject bgObject;
        
        public List<GameObject> bgManager;

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

        public Stage(GameObject mainUi, String bgPrefab)
        {
            bgIncrement = 10.38f;
            this.mainUi = mainUi;
            bgManager = new List<GameObject>();

            this.bgPrefab = bgPrefab;

            bgObject = ((GameObject)Resources.Load(bgPrefab));
            Canvas bgCanvas = mainUi.GetComponent<Canvas>();

            bgManager.Add(MonoBehaviour.Instantiate(bgObject, bgCanvas.transform));
            bgManager.Add(MonoBehaviour.Instantiate(bgObject, bgCanvas.transform));
            bgManager.Add(MonoBehaviour.Instantiate(bgObject, bgCanvas.transform));

            float bgloopTmpIdx = -(bgIncrement);
            foreach(GameObject g in bgManager)
            {
                //g.transform.SetParent(mainUi.transform, false);
                g.transform.position = new Vector3(g.transform.position.x + bgloopTmpIdx, g.transform.position.y, g.transform.position.z);
                bgloopTmpIdx += bgIncrement;
            }

           


            
            //bgManager[1].transform.position = new Vector3(bgObjecttmp.transform.position.x + bgIncrement, bgObjecttmp.transform.position.y, bgObjecttmp.transform.position.z);


            //foreach (SpriteRenderer sprender in mainUi.GetComponentsInChildren<SpriteRenderer>())
            //{
            //    if (sprender.name == "background2")
            //    {
            //        bgSprender = sprender;
            //        initBgPos = bgSprender.transform.position.x;



            //    }

            //}
        }

        public void NextRound()
        {
            Text stage = null;
            
            foreach (Text g in mainUi.GetComponentsInChildren<Text>())
            {
                if (g.name == "Stage")
                    stage = g;

            }
            

            try
            {
                
                stage.text = (int.Parse(stage.text) + 1).ToString();

                //GameObject bg2 = MonoBehaviour.Instantiate((GameObject)Resources.Load("background2"));


                float bgloopTmpIdx = -(bgIncrement)*2;
                foreach (GameObject g in bgManager)
                {
                    g.transform.SetParent(mainUi.transform, false);
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
