using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace trivago.servicios
{
    public class Conexionfirebase
    {
        public static FirebaseClient firebase = new FirebaseClient("https://trivago-5f76b-default-rtdb.firebaseio.com/");
    }
}
