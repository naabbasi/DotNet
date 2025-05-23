﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QTimeReportingEngine.Models
{
    public class JWTContainerModel : IAuthenticationContainerModel
    {
        #region Public Methods
        public int ExpireMinutes { get; set; } = 10080; // 7 days.
        public string SecretKey { get; set; } = "TW9zaGVFcmV6UHJpdmF0ZUtleQ=="; // This secret key should be moved to some configurations outter server.
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;
        public Claim[] Claims { get; set; }
        #endregion
    }
}
