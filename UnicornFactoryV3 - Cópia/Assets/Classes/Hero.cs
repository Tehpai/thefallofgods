using Assets.Classes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Entity {

    List<Skill> skills;

	public Hero(string prefabPath) : base(prefabPath)
    {
        skills = new List<Skill>();
    }
    public Hero(string prefabPath,List<Skill> skills) : base(prefabPath)
    {
        this.skills = skills;
    }



    public void useSkill(Skill skillUsed)
    {
        Animator anim = base.EntityP.GetComponent<Animator>();
        anim.SetBool("isUsingSkill", true);
        SkillSelectionBehaviour.skillBeingUsed = skillUsed;











        //codigo para mudar a sprite de um gameobject (já usado no gamecontroller.cs manualmente)
        //SpriteRenderer EnemySprender = EnemyP.GetComponent<SpriteRenderer>();
        //EnemySprender.sprite = (Sprite)Resources.Load("CharAbility");
    }


}
