using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

    private SpriteRenderer render;
    private BoxCollider2D collider;
    Timer.toCall handler;
    Timer switchingTimer;


    public float switchTime = 2.0f;

    // Use this for initialization
    void Start () {
        render = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();

        handler += SwitchOnOff;
        switchingTimer = new Timer(switchTime, handler, true);
        TimerManager.Instance.AddTimer(this, switchingTimer);
    }
    


	// Update is called once per frame
	void Update () {
		
	}


    public void SwitchOnOff()
    {


        if (render.enabled)
        {
            collider.enabled = false;
            
            render.enabled = false;
        }
        else {
            collider.enabled = true;
            render.enabled = true;
        }


    }



}
