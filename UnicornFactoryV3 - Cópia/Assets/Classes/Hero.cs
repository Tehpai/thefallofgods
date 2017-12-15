using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Entity {

	public Hero(string prefabPath) : base(prefabPath)
    {

    }

    public void useSkill()
    {
        Animator anim = base.EntityP.GetComponent<Animator>();
        anim.SetBool("isUsingSkill", true);











        //codigo para mudar a sprite de um gameobject (já usado no gamecontroller.cs manualmente)
        //SpriteRenderer EnemySprender = EnemyP.GetComponent<SpriteRenderer>();
        //EnemySprender.sprite = (Sprite)Resources.Load("CharAbility");
    }


}
