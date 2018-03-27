using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using type;

public class GameFlow : MonoBehaviour
{

    GameObject followCamera;
    GameObject currentPlayer;
    Dictionary<Type, GameObject> TypeOfPetrolost = new Dictionary<Type, GameObject>();

    void Start()
    {
        //TypeOfPetrolost.Add(Type.Volant, GameObject.Instantiate(Resources.Load<GameObject>("Prefabs\\Player\\PetrolostVoulant")));
        //TypeOfPetrolost.Add(Type.Roulant, GameObject.Instantiate(Resources.Load<GameObject>("Prefabs\\Player\\PetrolostRoulant")));
        //currentPlayer = TypeOfPetrolost[Type.Volant];
        //currentPlayer.transform.position = GV.DEFAULT_BEGIN_POINT;
        //followCamera = GameObject.FindGameObjectWithTag("FollowCamera");
        //followCamera.GetComponent<CinemachineVirtualCamera>().Follow = currentPlayer.transform;
    }



    public void TransformType()
    {
        Player InfoCurrentPLayer = currentPlayer.GetComponent<Player>();
        if (InfoCurrentPLayer.PetrolostType == Type.Volant)
        {
            Debug.Log(InfoCurrentPLayer.PetrolostType);
            Transform currentPosition = currentPlayer.transform;
            currentPlayer.SetActive(false);
            currentPlayer = TypeOfPetrolost[Type.Roulant];
            InfoCurrentPLayer.PetrolostType = Type.Roulant;
            currentPlayer.transform.position = currentPosition.position + new Vector3(4, 0, 0);
            currentPlayer.SetActive(true);
            followCamera.GetComponent<CinemachineVirtualCamera>().Follow = currentPlayer.transform;
        }
    }


    public void ReplayGame()
    {

        GameObject[] lasers = GameObject.FindGameObjectsWithTag("Laser");

        foreach (GameObject go in lasers)
        {

            go.GetComponent<LaserScript>().SwitchActive(true);

        }

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene2");
    }

    public void PlayGame()
    {

        GameObject[] lasers = GameObject.FindGameObjectsWithTag("Laser");

        foreach (GameObject go in lasers)
        {

            go.GetComponent<LaserScript>().SwitchActive(true);

        }

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene2");
    }

}
