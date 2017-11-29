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

        SpriteRenderer bgSprender;
        GameObject stageUi;
        GameObject mainUi;
        private bool finished;
        public bool Finished
        {
            get;
            set;
        }
        private float initBgPos;

        public Stage(GameObject mainUi)
        {
            this.mainUi = mainUi;
            

            foreach (SpriteRenderer sprender in mainUi.GetComponentsInChildren<SpriteRenderer>())
            {
                if (sprender.name == "background2")
                {
                    bgSprender = sprender;
                    initBgPos = bgSprender.transform.position.x;
                    


                }

            }
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

                bgSprender.transform.localPosition = new Vector3(bgSprender.transform.position.x + bgSprender.transform.localScale.x, bgSprender.transform.position.y,bgSprender.transform.position.z);

            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }







    }
}
