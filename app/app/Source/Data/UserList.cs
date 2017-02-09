using System;
using System.Collections.Generic;

using Newtonsoft.Json.Linq;

namespace App.Source.Data
{
    class UserList
    {
        private const string JSON_USERS = "Users";

        private List<User> userList_;

        public UserList()
        {
            userList_ = new List<User>();
        }

        public void setFromJSON(string userListAsJSON)
        {
            JObject obj = JObject.Parse(userListAsJSON);
            JArray arr = (JArray)obj[JSON_USERS];
            for (int i = 0; i < arr.Count; ++i)
            {
                User newUser = new User();
                newUser.setFromJSON(arr[i].ToString());
                userList_.Add(newUser);
            }
        }
    }
}