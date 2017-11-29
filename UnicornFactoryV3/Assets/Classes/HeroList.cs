using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroList {

    public List<Hero> heroes;
    private Vector3 startingPosition;



    public HeroList()
    {
        startingPosition = new Vector3(26.2f, -0.5f);
        heroes = new List<Hero>();
    }

   
}
