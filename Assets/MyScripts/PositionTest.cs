using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour
    
{
    [SerializeField]
    public Transform redcube;
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject rc = redcube.GetComponent<Transform>();
        //transform.localPosition = Vector3.MoveTowards(transform.localPosition, rc.localPosition, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        //Transform redcube = redcube.GetComponent<Transform>();
        Debug.Log(transform.localPosition);
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, redcube.localPosition, speed * Time.deltaTime);
        Debug.Log(redcube.localPosition);
    }

    
}
