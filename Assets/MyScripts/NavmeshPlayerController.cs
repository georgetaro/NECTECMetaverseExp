using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using Unity.Netcode;
using System.Linq;

public class NavmeshPlayerController : NetworkBehaviour
{


    private bool Atspawnlocation = false;
    private NavMeshAgent myNavMeshAgent;
    List<Vector2> target = new List<Vector2>();

    int j = 0;

    [SerializeField] public Transform movePositionTransform;


    private void Awake()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    { 
        target = gameObject.GetComponent<TrySocketIO>().target;
        StartCoroutine(MyCoroutine());
        Debug.Log("Hello Hello");
    }


    void Update()
    {   
        if (!Atspawnlocation && target!=null)
        {
            transform.localPosition = new Vector3(target.Last().x, 0, target.Last().y);
            Atspawnlocation = true;
            Debug.Log("Warped!");
        }


        if (Vector2.Distance(new Vector2(transform.localPosition.x,transform.localPosition.z), new Vector2(target.Last().x, target.Last().y))>5f)
        {
            //Debug.Log(new Vector2(transform.localPosition.x, transform.localPosition.z));
            //Debug.Log("target is:" + new Vector2(target.Last().x, target.Last().y).ToString());
            //myNavMeshAgent.destination = movePositionTransform.position;
            myNavMeshAgent.destination = new Vector3(target.Last().x - 38.38f, 0, target.Last().y - 17.01f); ;
            //Debug.Log(new Vector2(myNavMeshAgent.destination.x + 38.38f, myNavMeshAgent.destination.z + 17.01f));
        }





    }
    IEnumerator MyCoroutine()
    {



        while (true)
        {
            if (target.Count > 0)
            {

                while (true)
                {

                    while (myNavMeshAgent.remainingDistance > 0.5f)
                    {

                        if (myNavMeshAgent.pathStatus == NavMeshPathStatus.PathPartial)
                        {
                            Debug.Log(myNavMeshAgent.pathStatus);
                            break;
                        }


                        yield return null;
                    }


                   yield return null;
                }


            }
            yield return null;

        }
    }
}
