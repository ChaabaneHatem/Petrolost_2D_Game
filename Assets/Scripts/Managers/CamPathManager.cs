using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPathManager {



    #region Singleton
    private static CamPathManager instance;

    private CamPathManager() { }

    public static CamPathManager Instance {
        get {
            if (instance == null) {
                instance = new CamPathManager();
            }
            return instance;
        }
    }

    #endregion


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
