using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VirtualPlayer : MonoBehaviour
{


    public GameObject PlayerToFollow;
    CinemachineVirtualCamera followCamera;
    Player infoPlayerToFollow;

    //info of the game object 
    Rigidbody2D rg2D;

    //speed Vector
    Vector2 SpeedForce;

    // Use this for initialization
    void Start()
    {
        //PlayerToFollow = GameObject.FindGameObjectWithTag("PlayerVoulant");
        followCamera = GameObject.FindGameObjectWithTag("FollowCamera").GetComponent<CinemachineVirtualCamera>();
        infoPlayerToFollow = PlayerToFollow.GetComponent<Player>();

        rg2D = gameObject.GetComponent<Rigidbody2D>();

        SpeedForce = new Vector2(0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (infoPlayerToFollow.isMouving)
        {
            SpeedForce = new Vector2(4, 0);
        }
        else
        {
            SpeedForce = new Vector2(1, 0);
        }
        rg2D.AddForce(Vector2.right * Time.deltaTime / 10, ForceMode2D.Impulse);
        followCamera.Follow = this.gameObject.transform;
    }
}
