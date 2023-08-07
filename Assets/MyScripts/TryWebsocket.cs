//using UnityEngine;
//using WebSocketSharp;

//public class TryWebsocket : MonoBehaviour
//{
//    private WebSocket ws;

//    void Start()
//    {
//        ws = new WebSocket("wss://socket.lailab.online/ble/location/?EIO=4&transport=websocket");

//        ws.OnOpen += (sender, e) =>
//        {
//            Debug.Log("WebSocket connection opened");
//        };

//        ws.OnMessage += (sender, e) =>
//        {
//            Debug.Log("Received message: " + e.Data);
//        };

//        ws.OnError += (sender, e) =>
//        {
//            Debug.Log("Error occurred: " + e.Message);
//        };

//        ws.OnClose += (sender, e) =>
//        {
//            Debug.Log("WebSocket connection closed");
//        };

//        ws.Connect();
//    }

//    void OnDestroy()
//    {
//        ws.Close();
//    }
//}