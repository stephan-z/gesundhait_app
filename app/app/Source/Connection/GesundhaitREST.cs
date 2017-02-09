using System;
using RestSharp;

namespace app.source.connection
{
    class GesundhaitREST
    {
        const String USERSSQLTABLE = "users";

        private RestClient client_;

        public GesundhaitREST()
        {
            client_ = new RestClient("http://192.168.178.20/gesundhait_backend/backend/src/index.php");
        }

        public void getAllUsers()
        {
            var request = new RestRequest(USERSSQLTABLE, Method.GET);

            // execute the request
            IRestResponse response = client_.Execute(request);
            var content = response.Content;
        }

        public void getUserByID(int ID)
        {
            var request = new RestRequest(USERSSQLTABLE +"/{id}", Method.GET);
            request.AddUrlSegment("id", ID.ToString()); // replaces matching token in request.Resource

            // execute the request
            IRestResponse response = client_.Execute(request);
            var content = response.Content;
        }
    }
}