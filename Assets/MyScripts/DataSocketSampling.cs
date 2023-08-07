using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class DataSocketSampling : MonoBehaviour
{
    public float delay = 10f;
    float timer = 0;
    List<Vector2> target = new List<Vector2>();
    Vector2 temp;
    public List<Vector2> target2 = new List<Vector2>();
    Transform player;
    int j = 0;



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("DataSocket").GetComponent<TrySocketIO>().target;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        //if (Vector2.Distance(target.Last(),new Vector2(player.localPosition.x,player.localPosition.z))>1f)
       // {
       //target2.Add(target.Last());
       // Debug.Log("target2 Added" + target2.Last());

      //  }
        

        InvokeRepeating("AddTarget", 5, 0.5f);
    }

    void AddTarget()
    {
        if (j < target.Count - 1)
        {
            target2.Add(target.Last());
            
            //Debug.Log("ready to be sampled target count: "+ target.Count);
            Debug.Log("sampled target added" + target.Last());
            //Debug.Log("sampled target count: "+target2.Count);
            j += 1;
            
        }
        
    }

    //void Update()
    //{

    //        temp = target.Last();
    //        Debug.Log(temp);
    //        target2.Add(temp);

    //}













}
