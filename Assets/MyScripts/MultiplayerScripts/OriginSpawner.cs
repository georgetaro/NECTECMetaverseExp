using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class OriginSpawner : NetworkBehaviour
{
    public NetworkObject childrenTransform;
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Instantiate(myPrefab, new Vector3(-38.38f, 4.4f, -17.01f), Quaternion.identity);
        go.GetComponent<NetworkObject>().Spawn();



        childrenTransform.TrySetParent(go);
        bool success = childrenTransform.TrySetParent(go);
        if (success)
        {
            Debug.Log("Parent succcess");
        }
        else
        {
            Debug.Log("Parent failed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
