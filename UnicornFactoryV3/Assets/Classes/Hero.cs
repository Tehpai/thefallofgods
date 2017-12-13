using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Enemy {

	public Hero() : base("sampleHero")
    {

    }

    public void useSkill()
    {
        SpriteRenderer EnemySprender = EnemyP.GetComponent<SpriteRenderer>();
        EnemySprender.sprite = (Sprite)Resources.Load("CharAbility");
    }


}
