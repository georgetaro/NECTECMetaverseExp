using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshPlayerControllerFiltered : MonoBehaviour
{



    private NavMeshAgent myNavMeshAgent;
    List<Vector2> target2 = new List<Vector2>();
    int j = 0;

    [SerializeField] public Transform movePositionTransform;

    private void Awake()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();

    }

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    void Update()
    {

        if (j < target2.Count)
        {

            myNavMeshAgent.destination = new Vector3(target2[j].x - 38.38f, 0, target2[j].y - 17.01f);
            //Debug.Log(myNavMeshAgent.destination);
            //myNavMeshAgent.destination = movePositionTransform.position;

        }

    }

    IEnumerator MyCoroutine()
    {


        target2 = GameObject.FindGameObjectWithTag("DataFilter").GetComponent<DataFilter>().target2;
        while (true)
        {
            if (target2.Count > 0)
            {


                //while (Vector2.Distance(target[j], new Vector2(transform.localPosition.x, transform.localPosition.z)) > 0.1f)
                while (Vector2.Distance(target2[j], new Vector2(transform.localPosition.x, transform.localPosition.z)) > 0.1f)
                {


                    //Debug.Log(transform.localPosition);
                    
                    //Debug.Log(target2[j]);
                    //Debug.Log(Vector2.Distance(target2[j], new Vector2(transform.localPosition.x, transform.localPosition.z)));
                        
                    //Debug.Log(myNavMeshAgent.destination);
                    //Debug.Log(Vector2.Distance(target[j], new Vector2(transform.localPosition.x, transform.localPosition.z)));
                       
                    yield return null;

                }


                if (j < target2.Count - 1)
                {
                    j = j + 1;
                }


                    //Debug.Log(j);

            }


            yield return null;
         }

    }

    //Debug.Log(Destination[1]);
    //Debug.Log(destination[1]);




    //void Start()
    //{
    //    myNavMeshAgent = GetComponent<NavMeshAgent>();
    //    myLineRenderer = GetComponent<LineRenderer>();
    //    myLineRenderer.startWidth = 0.15f;
    //    myLineRenderer.endWidth = 0.15f;
    //    myLineRenderer.positionCount = 0;
    //}

}
