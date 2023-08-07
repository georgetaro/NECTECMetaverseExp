using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIDemo : MonoBehaviour
{
    public InputField userName;
    public static string userID;
    
    public void MyDemoButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        userID = userName.text;
    }
}
