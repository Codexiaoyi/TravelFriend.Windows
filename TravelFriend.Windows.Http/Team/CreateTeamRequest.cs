using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravelFriend.Windows.Http
{
    public class CreateTeamRequest : HttpRequest
    {
        public CreateTeamRequest(string userName, string teamName, string introduction) : base(ApiUtils.CreateTeam)
        {
            UserName = userName;
            TeamName = teamName;
            Introduction = introduction;
        }

        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("teamname")]
        public string TeamName { get; set; }
        [JsonProperty("introduction")]
        public string Introduction { get; set; }
    }
}
