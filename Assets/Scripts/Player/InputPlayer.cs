using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputPlayer : MonoBehaviour
{

    List<KeyToEventInt> keyToEventList = new List<KeyToEventInt>();
    Player PlayerController;


    // Use this for initialization
    void Start()
    {
        PlayerController = GetComponent<Player>();
        keyToEventList.Add(new KeyToEventInt(KeyCode.Space, PlayerController.Move));
    }

    // Update is called once per frame
    void Update()
    {

        foreach (KeyToEventInt kv in keyToEventList)
        {
            bool resultat = Input.GetKey(kv.KeyCodeBoolean);
            kv.boolEvent.Invoke(resultat);
        }

    }

    [System.Serializable]
    public class KeyToEventInt
    {
        public KeyCode KeyCodeBoolean;
        public IntEvent boolEvent;



        public KeyToEventInt(KeyCode _KeyCodeBoolean, IntEvent _boolEvent)
        {
            KeyCodeBoolean = _KeyCodeBoolean;
            boolEvent = _boolEvent;

        }

        public KeyToEventInt(KeyCode _KeyCodeBoolean, params UnityAction<bool>[] _boolAction)
        {
            KeyCodeBoolean = _KeyCodeBoolean;
            boolEvent = new IntEvent();
            foreach (UnityAction<bool> action in _boolAction)
            {
                boolEvent.AddListener(action);
            }
        }

    }

    [System.Serializable]
    public class IntEvent : UnityEvent<bool>
    {

    }

}
