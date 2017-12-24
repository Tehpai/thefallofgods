using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroList {

    public List<Hero> heroes;
    private Vector3 startingPosition;



    public HeroList()
    {
        startingPosition = new Vector3(26.2f, -0.5f);
        startingPosition = ((GameObject)Resources.Load("sampleHero")).GetComponent<Transform>().position;
        heroes = new List<Hero>();
    }
    public void AddHeroToScene()
    {

        heroes.Add(new Hero("sampleHero"));
        PositionEntities();
    }

    void PositionEntities()
    {
        Vector2 positionIncrement = new Vector2(3, 3);
        bool xCoordAdjust = false;
        for (int cnt = 0; cnt < heroes.Count; cnt++, xCoordAdjust = !xCoordAdjust)
        {
            
            
            heroes[cnt].EntityP.transform.position = new Vector3(startingPosition.x + positionIncrement.x, startingPosition.y + (cnt * positionIncrement.y));
            if (xCoordAdjust)
                positionIncrement.x *= 1;
            else
                positionIncrement.x *= -1;
        }




    }



}
