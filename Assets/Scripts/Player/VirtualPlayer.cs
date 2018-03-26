using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualPlayer : MonoBehaviour
{

    GameObject PlayerToFollow;
    GameObject followCamera;
    

    // Use this for initialization
    void Start()
    {
        PlayerToFollow = GameObject.FindGameObjectWithTag("PetrolostVoulant");
        followCamera = GameObject.FindGameObjectWithTag("FollowCamera");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
