using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLineScript : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "PlayerVoulant" || other.gameObject.tag == "PlayerRoulant") {

            Debug.Log("FINISH!!!!!");

            FlowManager.Instance.CallGameOver();


        }

    }
}
