using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStart : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(gameObject);
        FlowManager.Instance.Start();
	}
	
	// Update is called once per frame
	void Update () {
        FlowManager.Instance.Update();
	}
}
