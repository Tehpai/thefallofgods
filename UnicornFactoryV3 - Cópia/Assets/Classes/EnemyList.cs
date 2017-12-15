using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System;

public class EnemyList
{
    public List<Enemy> enemies;
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

    public EnemyList()
    {
        startingPosition = GetEnemyListStartingPosition();
    }

    private Vector3 GetEnemyListStartingPosition()
    {



        throw new NotImplementedException();
    }
}