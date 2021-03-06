﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Scozzard.XboxApiClient;
using Scozzard.XboxApiClient.Model;

namespace Scozzard.XboxApiClient.Client
{
    public class XboxApi : XboxApiClient
    {
        private const string apiResourceUrl = "https://xboxapi.com/v2/";

        // endpoints (https://xboxapi.com/documentation)
        // TODO: add endpoints here

        public virtual xbox_user GetUser(long xboxUserId)
        {
            var requestDetails = new RestRequestDetails(HttpMethod.Get, apiResourceUrl + xboxUserId + "/profile");

            return GetSingle<xbox_user>(requestDetails);
        }

        public virtual List<xbox_user> GetFriends(long xboxUserId)
        {
            var requestDetails = new RestRequestDetails(HttpMethod.Get, apiResourceUrl + xboxUserId + "/friends");

            return GetList<xbox_user>(requestDetails);
        }

        public virtual List<activity_item> GetUserActivities(long xboxUserId)
        {
            var requestDetails = new RestRequestDetails(HttpMethod.Get, apiResourceUrl + xboxUserId + "/activity");

            return GetSingle<activity>(requestDetails).activityItems;
        }

        public virtual List<game_clip> GetUserGameClips(long xboxUserId)
        {
            var requestDetails = new RestRequestDetails(HttpMethod.Get, apiResourceUrl + xboxUserId + "/game-clips");

            return GetList<game_clip>(requestDetails);
        }

        public virtual List<screenshot> GetUserScreenshots(long xboxUserId)
        {
            var requestDetails = new RestRequestDetails(HttpMethod.Get, apiResourceUrl + xboxUserId + "/screenshots");

            return GetList<screenshot>(requestDetails);
        }
    }
}
