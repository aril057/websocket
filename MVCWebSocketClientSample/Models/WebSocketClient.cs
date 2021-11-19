using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebSocketSharp;

namespace MVCWebSocketClientSample.Models
{
    public class WebSocketClient
    {
        WebSocket wc = new WebSocket("ws://127.0.0.1:7890/Echo");
        public string output;
        public string received;

        public void Connect()
        {
            try
            {
                wc.OnMessage += Wc_OnMessage;
                wc.Connect();
                output = wc.Url.ToString();
                wc.Send("Hello There Server :)");
            }
            catch (Exception) { output = "No Connection Found" + Environment.NewLine; }
        }

        public void GetRFIDPhoto()
        {
            try
            {
                wc.OnMessage += Wc_OnMessage;
                wc.Connect();
                wc.Send("RFID_Photo");
            }
            catch (Exception) { output = "No Connection Found" + Environment.NewLine; }
        }

        private void Wc_OnMessage(object sender, MessageEventArgs e)
        {
            output = e.Data;
            //received = e.Data;
        }
    }
}