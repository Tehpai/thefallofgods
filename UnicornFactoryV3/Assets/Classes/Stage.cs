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

        public SpriteRenderer bgSprender;
        //GameObject stageUi;
        GameObject mainUi;
        //private bool finished;
        public bool Finished
        {
            get;
            set;
        }
        private float initBgPos;

        public Stage(GameObject mainUi,SpriteRenderer bgSprender)
        {
            this.mainUi = mainUi;

            this.bgSprender = bgSprender;
            

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

                GameObject bg2 = (GameObject)Resources.Load("background2");
                
                //bg2 = UnityEditor.PrefabUtility.InstantiatePrefab(bg2);

                bgSprender.transform.position = new Vector3(bgSprender.transform.position.x + 11, bgSprender.transform.position.y,bgSprender.transform.position.z);

            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }







    }
}
