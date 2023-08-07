using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class SetParent : NetworkBehaviour {

    public NetworkObject Player;
    public Transform Origin;
    private void Update()
    {
        Player.TrySetParent(Origin);
        bool success = Player.TrySetParent(Origin);
        if (success)
        {
            Debug.Log("Parent succcess");
        }
        else
        {
            Debug.Log("Parent failed");
        }
    }
   
}
