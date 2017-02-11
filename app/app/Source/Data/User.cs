using Newtonsoft.Json.Linq;

namespace App.Source.Data
{
    public class User
    {
        private const string JSON_USER = "User";
        private const string JSON_ID = "ID";
        private const string JSON_SURNAME = "u_surname";
        private const string JSON_FORENAME = "u_forename";
        private const string JSON_NUMBER = "u_number";
        private const string JSON_MAIL= "u_mail";
        private const string JSON_USERNAME = "u_username";
        private const string JSON_PASSWORD = "u_password";
        private const string JSON_ACTIVE = "u_active";
        private const string JSON_CREATED = "u_created";

        private int ID_;
        private string surname_;
        private string forename_;
        private string number_;
        private string mail_;
        private string username_;
        private string password_;
        private bool active_;
        private string created_;

        public User()
        {
        }

        public void setFromJSON(string userAsJSON)
        {
            JObject objUser = JObject.Parse(userAsJSON);
            JObject objCont = (JObject)objUser[JSON_USER];
            ID_ = (int)objCont[JSON_ID];
            surname_ = (string)objCont[JSON_SURNAME];
            forename_ = (string)objCont[JSON_FORENAME];
            number_ = (string)objCont[JSON_NUMBER];
            mail_ = (string)objCont[JSON_MAIL];
            username_ = (string)objCont[JSON_USERNAME];
            password_ = (string)objCont[JSON_PASSWORD];
            active_ = (bool)objCont[JSON_ACTIVE];
            created_ = (string)objCont[JSON_CREATED];
        }

        public string toJSON()
        {
            JObject objCont = new JObject();
            objCont[JSON_ID] = ID_;
            objCont[JSON_SURNAME] = surname_;
            objCont[JSON_FORENAME] = forename_;
            objCont[JSON_NUMBER] = number_;
            objCont[JSON_MAIL] = mail_;
            objCont[JSON_USERNAME] = username_;
            objCont[JSON_PASSWORD] = password_;
            objCont[JSON_ACTIVE] = active_;
            objCont[JSON_CREATED] = created_;
            JObject objUser = new JObject();
            objUser[JSON_USER] = objCont;
            return objUser.ToString();
        }
    }
}