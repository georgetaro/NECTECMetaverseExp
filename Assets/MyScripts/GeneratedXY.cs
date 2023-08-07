using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedXY : MonoBehaviour
{
    //Underdamped 
    List<float> lx = new List<float>() { 63f, 67.58f, 71.32f, 76.23f, 80.92f, 86.3f, 81.48f, 88.11f, 93.35f };
    List<float> lz = new List<float>() { 23.25f, 24.53f, 23.28f, 24.72f, 23.72f, 23.72f, 20.15f, 20.15f, 20.15f };

    //longlist
    //List<float> lx = new List<float>() { 72.4f, 72.3f , 72.1f, 71.9f, 67.92f, 64.79f, 58.3f, 50.3f, 50.3f, 54.4f, 54.4f, 47.1f, 38.05f, 32.3f, 26.2f, 26.2f, 25.82f, 14.11f, 14.11f, 14.11f, 14.11f};
    //List<float> lz = new List<float>() { 24.06f, 24.06f, 24.06f, 24.06f, 24.06f, 24.06f, 24.06f, 24.06f, 19.95f, 19.95f, 16.44f, 14.95f, 14.95f, 14.95f, 14.95f, 23.6f, 26.61f, 26.61f, 21.86f,17.07f, 12.63f};


    public List<Vector2> target = new List<Vector2>();
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        for (int i = 0; i < lx.Count; i++)
        {
            target.Add(new Vector2(lx[i], lz[i]));
           //Debug.Log(target[i]);
             yield return null;
           // yield return new WaitForSecondsRealtime(1f);
           //yield return new WaitForSecondsRealtime(5f);
        }
    }



}





