﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using type;

namespace type
{
    public enum Type
    {
        Roulant, Volant
    }
}

public class Player : MonoBehaviour
{

    //information camera and the virtual player who focus the camera 
    [Tooltip("the virtual player")]
    public GameObject virtualPlayer;


    //info of the gameObject Player
    Rigidbody2D rg2D;
    public bool isMouving;
    public Type PetrolostType;
    Animator animationMoveSprite;

    //info of the speed vector 
    Vector2 SpeedForceRoulant;
    Vector2 SpeedForceVoulant;
    Vector2 RightForce;


    //parent of all the player
    GameObject playerParent;

    // Use this for initialization
    void Start()
    {
        rg2D = gameObject.transform.GetComponent<Rigidbody2D>();
        isMouving = false;
        //PetrolostType = Type.Volant;
        animationMoveSprite = gameObject.GetComponent<Animator>();

        SpeedForceRoulant = new Vector2(0, 0);
        SpeedForceVoulant = new Vector2(0, 0);
        RightForce = new Vector2(0, 0);

        playerParent = GameObject.FindGameObjectWithTag("PlayerParent");
    }

    private void FixedUpdate()
    {
        rg2D.AddForce(SpeedForceVoulant * GV.MAX_SPEED_PLAYER_VOULANT);
        rg2D.AddForce(RightForce * 5);
        rg2D.AddTorque(-SpeedForceRoulant.magnitude * GV.MAX_SPEED_PLAYER_ROULANT);
    }


    private void Update()
    {
        if (Vector3.Distance(virtualPlayer.transform.position, gameObject.transform.position) > GV.MAX_DISTANCE_FROM_VIRTUAL_PLAYER)
        {
            Die(gameObject);
        }
    }

    public void Move(bool move_key_espace)
    {
        if (move_key_espace)
        {
            if (this.gameObject.CompareTag("PlayerVoulant"))
            {
                SpeedForceVoulant = Vector2.up;
                PetrolostType = Type.Volant;
            }
            else if (gameObject.CompareTag("PlayerRoulant"))
            {
                SpeedForceRoulant = Vector2.right;
                PetrolostType = Type.Roulant;
            }

            RightForce = GV.MAX_FORWARD_FORCE;
            isMouving = true;
            animationMoveSprite.StopPlayback();
        }
        else
        {
            SpeedForceRoulant = new Vector2(0, 0);
            SpeedForceVoulant = new Vector2(0, 0);
            RightForce = new Vector2(0, 0);
            isMouving = false;
            animationMoveSprite.StartPlayback();
        }
    }


    public void Die(GameObject playerToDie)
    {
        Destroy(playerToDie);
        if (playerParent.transform.childCount - 1 == 0)
        {
            FlowManager.Instance.CallGameOver();
        }
    }
}
