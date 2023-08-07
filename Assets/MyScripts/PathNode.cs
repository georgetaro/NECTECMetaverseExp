using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNode : MonoBehaviour
{
    [SerializeField]
    public float gCost;
    [SerializeField]
    public float hCost;
    [SerializeField]
    public float FCost;

    public float distance;

    //[SerializeField]
    //GameObject startNode;
    //[SerializeField]
    //GameObject endNode;

    public PathNode cameFromNode;
    

}
