﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scozzard.Model;

namespace Scozzard.Web.ViewModels
{
    public class XboxUserViewModel
    {
        public long XboxUserID { get; set; }
        public string GamerTag { get; set; }
        public string GameDisplayName { get; set; }
        public int Gamerscore { get; set; }
        public string GameDisplayPicRaw { get; set; }
        public string AccountTier { get; set; }
        public string XboxOneRep { get; set; }
        public string PreferredColor { get; set; }
        public List <XboxUser> Friends { get; set; }
        public List<Activity> Activities { get; set; }
    }
}