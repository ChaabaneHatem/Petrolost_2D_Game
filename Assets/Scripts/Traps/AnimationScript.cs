using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour {

    private Animation anim;
    public float animSpeed = 0.6f;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animation>();

    }
	
}
