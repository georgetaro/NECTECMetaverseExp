using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataFilter : MonoBehaviour
{

    List<Vector2> target = new List<Vector2>();
    int j = 0;
    int k = 0;

    List<Transform> nodes = new List<Transform>();
    
    public float snapDistance = 5f;
    public float smallestDistance = 5f;
    Vector2 temp;
    public List<Vector2> target2 = new List<Vector2>();
    public Transform player;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("DataGen").GetComponent<GeneratedXY>().target;
        
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        nodes = GameObject.FindGameObjectWithTag("NNode").GetComponent<NavNode>().Navnodes;
        //StartCoroutine(MyCoroutine());
    }




    void Update()
    {
        temp = new Vector2(player.localPosition.x, player.localPosition.z);
        if (j < target.Count-1)
        {
            //Debug.Log(target[j]);
            foreach(Transform node in nodes)
            {
                //Debug.Log(node);
                //Debug.Log(Vector2.Distance(target[j], new Vector2(node.localPosition.x, node.position.z)));
                //Debug.Log(target[j]);
                //Debug.Log(new Vector2(node.localPosition.x, node.position.z));
                
                if (Vector2.Distance(target[j], new Vector2(node.localPosition.x, node.localPosition.z)) < smallestDistance )
                {
                    smallestDistance = Vector2.Distance(target[j], new Vector2(node.localPosition.x, node.localPosition.z));
                    //target2.Add(new Vector2(node.localPosition.x, node.localPosition.z));
                    temp = new Vector2(node.localPosition.x, node.localPosition.z);

                 }

                
            }
            target2.Add(temp);


            Debug.Log(target2[k]);
            k = k + 1;

           //Debug.Log(smallestDistance);
            Debug.Log(target2.Count);
            j = j + 1;
            smallestDistance = snapDistance;
        }
        
       
    }


    //target2.Insert(k, new Vector2(node.localPosition.x, node.localPosition.z));
    //Debug.Log(target2[k]);
    //k = k + 1;

    //target2[k] = new Vector2(node.position.x, node.position.z);


    //IEnumerator MyCoroutine()
    //{
    //    foreach (Transform node in nodes)
    //    {
    //        //Debug.Log(node);
    //        //Debug.Log(node.position);

    //        if (Vector3.Distance(node.position, new Vector3(target[j].x - 38.38f, 0, target[j].y - 17.01f)) < 1f)
    //        {
    //            //smallestDistance = Vector3.Distance(node.position, new Vector3(target[j].x - 38.38f, 0, target[j].y - 17.01f));
    //            target2.Insert(j, new Vector3(node.position.x - 38.38f, 0, node.position.y - 17.01f));
    //            j = j + 1;

    //        }
    //    }
    //    //myNavMeshAgent.destination = target2[j];

    //    return null;
    //}
}
