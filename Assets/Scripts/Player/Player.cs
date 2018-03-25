using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Player : MonoBehaviour
{
    public enum Type
    {
        Roulant, Volant
    }

    //info of the gameObject Player
    Rigidbody2D rg2D;
    public bool isMouving;
    public Type PetrolostType;

    //info of the speed vector 
    Vector2 SpeedForceRoulant;
    Vector2 SpeedForceVoulant;

    // Use this for initialization
    void Start()
    {
        rg2D = gameObject.transform.GetComponent<Rigidbody2D>();
        isMouving = false;
        PetrolostType = Type.Volant;

        SpeedForceRoulant = new Vector2(0, 0);
        SpeedForceVoulant = new Vector2(0, 0);

    }

    private void FixedUpdate()
    {

    }


    public void Move(bool move_key_espace)
    {
        if (move_key_espace)
        {

        }
    }


    public void Clone(int nbClone)
    {

    }



    public void TrasFormType()
    {

    }

}
