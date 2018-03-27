using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsScript : MonoBehaviour {



    void Start() {

    }



    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "PlayerVoulant" || coll.gameObject.tag == "PlayerRoulant") {
            Player script = coll.gameObject.GetComponent<Player>();
            script.Die();
        }

    }


    // Update is called once per frame
    void Update () {

               
		
	}

    

}
