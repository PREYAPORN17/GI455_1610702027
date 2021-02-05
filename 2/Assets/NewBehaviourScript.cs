using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

namespace ProgramChat
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private WebSocket websocket;
        public InputField text0;
        public Text Text1, text2;
        string data1;
        bool num = false;

        // Start is called before the first frame update
        void Start()
        {
            websocket = new WebSocket("ws://127.0.0.1:59999/");
            websocket.OnMessage += OnMessge;
            websocket.Connect();
           
        }

        // Update is called once per frame
        //void Update()
        //{
            

        //}

        public void OnDestroy()
        {
           if(websocket != null)
            {
                websocket.Close();
            }
        }


        public void OnMessge (object sender, MessageEventArgs messageEventArgs)
        {
            data1 = messageEventArgs.Data;
            if (num == true)
            {
                text2.text += "\n";
                num = false;
            }
            else if(num == false)
            {
                text2.text += "\n" + data1;
                Text1.text += "\n";
            }
        } 


        public void buttonsend()
        {
            Text1.text += " \n " + text0.text;
            websocket.Send(text0.text);
            num = true;



        }





    }

}
