using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DoorTransform : MonoBehaviour
{
    
    GameFollow gameFlow;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision avec le player");
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("PetrolostVoulant"))

        {
            gameFlow = collision.gameObject.GetComponent<GameFollow>();
            if (gameFlow != null)
            {
                gameFlow.TransformType();
            }
        }


    }


}
