﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravelFriend.Windows.Http.Login
{
    public class RegisterRequest : HttpRequest
    {
        public RegisterRequest(string userName, string password, string nickName) : base(ApiUtils.Register)
        {
            UserName = userName;
            Password = password;
            NickName = nickName;
        }

        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("nickname")]
        public string NickName { get; set; }
    }
}
