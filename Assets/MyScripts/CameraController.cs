using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class CameraController : NetworkBehaviour
{
    public Camera FPSCamera;


    private void Update()
    {
        if (IsOwner)
        {
            FPSCamera.gameObject.SetActive(true);
        }
        else
        {
            FPSCamera.gameObject.SetActive(false);
        }
    }

}
