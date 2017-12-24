using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System;

public class EntityList
{
    public List<Entity> entities;
    private Vector3 startingPosition;
    public Vector3 StartingPosition
    {
        get
        {
            return startingPosition;
        }
        set
        {
            startingPosition = value;
        }

    }

    public EntityList()
    {
        startingPosition = GetEnemyListStartingPosition();
    }

    


    private Vector3 GetEnemyListStartingPosition()
    {



        throw new NotImplementedException();
    }
}