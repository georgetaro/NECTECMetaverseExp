using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActionOnTimerTesting : MonoBehaviour
{
    [SerializeField] private ActionOnTimer actionOnTimer;

    // Start is called before the first frame update
    private void Start()
    {
        actionOnTimer.SetTimer(1f, () => { Debug.Log("Timer complete!"); });
    }


}
