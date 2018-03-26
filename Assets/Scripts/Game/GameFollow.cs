using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using type;

public class GameFollow : MonoBehaviour
{

    GameObject followCamera;
    GameObject currentPlayer;


    private void Start()
    {
        currentPlayer = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs\\Player\\PetrolostVoulant"));
        currentPlayer.transform.position = GV.DEFAULT_BEGIN_POINT;
        followCamera = GameObject.FindGameObjectWithTag("FollowCamera");
        followCamera.GetComponent<CinemachineVirtualCamera>().Follow = currentPlayer.transform;
    }



    public void TransformType()
    {
        Player InfoCurrentPLayer = currentPlayer.GetComponent<Player>();
        if (InfoCurrentPLayer.PetrolostType == Type.Volant)
        {
            Transform currentPosition = currentPlayer.transform;
            GameObject.DestroyImmediate(currentPlayer);
            currentPlayer = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs\\Player\\PetrolostRoulant"));
            currentPlayer.transform.position = currentPosition.position + new Vector3(4, 0, 0);
            followCamera.GetComponent<CinemachineVirtualCamera>().Follow = currentPlayer.transform;
        }
    }




}
