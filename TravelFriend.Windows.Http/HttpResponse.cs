﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TravelFriend.Windows.Http
{
    public class HttpResponse
    {
        public int code { get; set; } = 200;
        public string message { get; set; }

        public string localError { get; set; }
    }
}
