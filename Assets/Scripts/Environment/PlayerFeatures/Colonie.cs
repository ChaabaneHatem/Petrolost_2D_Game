using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonie : MonoBehaviour
{

    //la position de l'object qui collide 
    Vector3 GameObjectPosition = new Vector3();

    public Transform playerParent;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerRoulant"))
        {
            GameObjectPosition = collision.gameObject.transform.position;
            for (int i = 0; i < GV.GetRandomInt(GV.RANGE_CLONE_UNITY); i++)
            {
                GameObjectPosition += new Vector3(1, 0, 0);
                GameObject newobj = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs\\Player\\PetrolostRoulant"));
                newobj.transform.position = GameObjectPosition;
            }
        }

        else if (collision.gameObject.CompareTag("PlayerVoulant"))
        {
            GameObjectPosition = collision.gameObject.transform.position;
            for (int i = 0; i < GV.GetRandomInt(GV.RANGE_CLONE_UNITY); i++)
            {
                GameObjectPosition += new Vector3(1, 0, 0);
                GameObject newobj = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs\\Player\\PetrolostVoulant"));
                newobj.transform.position = GameObjectPosition;
                newobj.gameObject.transform.SetParent(playerParent);
            }
        }

        GameObject.Destroy(this.gameObject);
    }


}
