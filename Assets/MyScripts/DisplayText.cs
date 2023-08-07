using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;


  
    public class DisplayText : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI obj_text;
    [SerializeField] TextMeshProUGUI display;
    // Start is called before the first frame update
    void Start()
    {
        obj_text.text = PlayerPrefs.GetString("user_name");
    }

    // Update is called once per frame
    public void Create()
    {
        obj_text.text = display.text;
        PlayerPrefs.SetString("user_name", obj_text.text);
        PlayerPrefs.Save();
    }
}
