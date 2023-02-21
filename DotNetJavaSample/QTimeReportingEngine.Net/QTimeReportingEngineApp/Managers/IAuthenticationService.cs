using System;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QTimeReportingEngine.Models;

namespace QTimeReportingEngine.Managers
{
    interface IAuthenticationService
    {
        string SecretKey { get; set; }

        bool IsTokenValid(string token);
        string GenerateToken(IAuthenticationContainerModel model);
        IEnumerable<Claim> GetTokenClaims(string token);
    }
}
