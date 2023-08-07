using System;
using System.Collections.Generic;
using SocketIOClient;
using SocketIOClient.Newtonsoft.Json;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Newtonsoft.Json.Linq;
using SocketIOClient.JsonSerializer;
using Newtonsoft.Json;

public class TrySocketIO : MonoBehaviour
{
    public SocketIOUnity socket;
    public List<Vector2> target = new List<Vector2>();

    OneEuroFilter floatFilter;
    OneEuroFilter<Vector3> vector3Filter;
    public float filterFrequency = 120.0f;

    public int inputTagID;

    [System.Serializable]
    public class TagData
    {
 

        public int event_time_start;
        public string created_at;
        public int floor;
        public string floor_name;
        public float x;
        public float y;
        public string firstName;
        public int userId;
    }

    private void OnDisable()
    {
        socket.Disconnect();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        inputTagID = int.Parse(UIDemo.userID);
        Debug.Log(inputTagID);
        //floatFilter = new OneEuroFilter(filterFrequency);
        //vector3Filter = new OneEuroFilter<Vector3>(50.0f, 0.5f, 0.1f, 0.1f);
        vector3Filter = new OneEuroFilter<Vector3>(50.0f,0.5f,0.1f,0.1f);

        //TODO: check the Uri if Valid.
        var uri = new Uri("https://socket.lailab.online");
        socket = new SocketIOUnity(uri, new SocketIOOptions
        {
            Path = "/ble/location/",

            EIO = 4
            ,
            Transport = SocketIOClient.Transport.TransportProtocol.WebSocket
        });
        Debug.Log("Meow");

        socket.JsonSerializer = new NewtonsoftJsonSerializer();

        //var jsonSerializer = socket.JsonSerializer as SystemTextJsonSerializer;


        ///// reserved socketio events
        socket.OnConnected += (sender, e) =>
        {
            Debug.Log("socket.OnConnected");
            socket.Emit("/join", "unai/1/1/5/tag");
            
        };
        socket.OnPing += (sender, e) =>
        {
            Debug.Log("Ping");
        };
        socket.OnPong += (sender, e) =>
        {
            Debug.Log("Pong: " + e.TotalMilliseconds);
        };
        socket.OnDisconnected += (sender, e) =>
        {
            Debug.Log("disconnect: " + e);
        };
        socket.OnReconnectAttempt += (sender, e) =>
        {
            Debug.Log($"{DateTime.Now} Reconnecting: attempt = {e}");
        };

        Debug.Log("Connecting...");

        socket.Connect();

        socket.On("clientBox", (response) =>
        {

            TagData myTagData = JsonUtility.FromJson<TagData>(response.ToString().Trim('[', ']'));
            if (myTagData.userId == inputTagID)
            //2160
            {
                Debug.Log(myTagData.firstName);

                //target.Add(new Vector2(myTagData.x, myTagData.y));
                //Debug.Log("all target received from socketIO: " + myTagData.x + ", " + myTagData.y);
                
                Vector3 FilteredInput = vector3Filter.Filter(new Vector3(myTagData.x, myTagData.y, 0));
                target.Add(new Vector2(FilteredInput.x, FilteredInput.y));
                Debug.Log("all Filtered target received from socketIO: " + FilteredInput.x + ", " + FilteredInput.y);
             
             }




        });

     }


    
    
    
}


