using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowManager {
    #region Singleton
    private static FlowManager instance;


    private FlowManager() {}

    public static FlowManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new FlowManager();
            }
            return instance;
        }
    }

    #endregion

    public void Start() {
        TimerManager.Instance.Start();

    }

    public void Update() {
        TimerManager.Instance.Update();

    }


}
