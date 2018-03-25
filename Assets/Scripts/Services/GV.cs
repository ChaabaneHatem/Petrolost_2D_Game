using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GV
{

    public static readonly Vector2 RANGE_CLONE_UNITY = new Vector2(1, 6); //de 1 a 5
    public static readonly float MAX_SPEED_PLAYER_ROULANT = 2;
    public static readonly float MAX_SPEED_PLAYER_VOULANT = 4;



    public static float GetRandomFloat(Vector2 vector)
    {
        return Random.Range(vector.x, vector.y);
    }

    public static int GetRandomInt(Vector2 vector)
    {
        return (int)Random.Range(vector.x, vector.y);
    }


}
