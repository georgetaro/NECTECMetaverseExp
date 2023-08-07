using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour {
    [SerializeField]
    public GameObject startNode;
    [SerializeField]
    public GameObject endNode;
    public float distance;
    public float FCost;

    //List<GameObject> OpenList = new List<GameObject>() { startNode };
   


    void Start()
    {
        //Debug.Log(startNode.transform.position);
        //Debug.Log(startNode.GetComponent<PathNode>().gCost);
        GameObject[] objectarray = GameObject.FindGameObjectsWithTag("Node");

        foreach (GameObject obj in objectarray)
        {
            obj.GetComponent<PathNode>().gCost = int.MaxValue;
            obj.GetComponent<PathNode>().FCost = CalculateFCost(obj);
            obj.GetComponent<PathNode>().cameFromNode = null;
            Debug.Log(obj.transform.position);
        }

        Debug.Log("Test");

        //startNode = start
        //Debug.Log(startNode.transform.position);
        //Debug.Log(startNode.GetComponent<PathNode>().gCost);
        startNode.GetComponent<PathNode>().gCost = 0;
        startNode.GetComponent<PathNode>().hCost = CalculateDistanceCost();
        startNode.GetComponent<PathNode>().FCost = CalculateFCost(startNode);

    }



    void Update()
    {
        //n1.gCost = 10;
        //CalculateDistanceCost(startNode,endNode);
    }


    float CalculateDistanceCost()
    {
        //this.startNode = startNode;
        //this.endNode = endNode;
        distance = startNode.transform.position.x - endNode.transform.position.x;
        Debug.Log(distance);
        return distance;
    }

    float CalculateFCost(GameObject obj)
    {
        FCost = obj.GetComponent<PathNode>().gCost + obj.GetComponent<PathNode>().hCost;
        return FCost;
    }

}
