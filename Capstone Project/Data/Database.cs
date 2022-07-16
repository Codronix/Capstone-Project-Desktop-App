using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Capstone_Project
{
    class Database
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "<Your Firebase API Key Here>",
            BasePath = "<Your Firebase Realtime Database link here>"
        };

        public IFirebaseClient client;
        public FirebaseResponse response;

        public void Cloud_DB_Connect()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch 
            {
                
            }
        }

        public bool isConnected_TO_Internet() 
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead(config.BasePath))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
