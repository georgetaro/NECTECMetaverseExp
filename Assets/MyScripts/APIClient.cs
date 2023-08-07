using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class APIClient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MakeRequest());
    }

    IEnumerator MakeRequest()
    {
        string url = "https://rtls.lailab.online/api_get_floor_info_by_id";

        UnityWebRequest www = new UnityWebRequest(url, "POST");

        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes("floor_id=3");
        www.uploadHandler = new UploadHandlerRaw(bodyRaw);

        www.downloadHandler = new DownloadHandlerBuffer();
        // Set a HTTP request header to a custom value
        www.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        www.SetRequestHeader("Authorization", "ae16e993-840d-44a8-9fbb-d268578002fe");

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
        }
    }

    //void Start()
    //{
    //    StartCoroutine(Upload());
    //}

    //IEnumerator Upload()
    //{
    //    WWWForm form = new WWWForm();
    //    form.AddField("myField", "floor_id=3");

    //    using (UnityWebRequest www = UnityWebRequest.Post("https://rtls.lailab.online/api_get_floor_info_by_id", form))
    //    {
    //        yield return www.SendWebRequest();

    //        if (www.result != UnityWebRequest.Result.Success)
    //        {
    //            Debug.Log(www.error);
    //        }
    //        else
    //        {
    //            Debug.Log("Form upload complete!");
    //        }
    //    }
    //}
}
