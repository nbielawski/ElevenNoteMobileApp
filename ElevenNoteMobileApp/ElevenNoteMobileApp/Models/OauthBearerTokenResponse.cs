﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElevenNoteMobileApp.Models
{
    public class OauthBearerTokenResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string userName  { get; set; }


    }
}
