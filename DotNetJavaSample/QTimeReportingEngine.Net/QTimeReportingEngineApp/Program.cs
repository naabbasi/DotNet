using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using QTimeReportingEngine.Managers;
using QTimeReportingEngine.Models;
using System.Security.Claims;
using QTimeReportingEngine.QTHttpClient;
using QTimeReportingEngineLibrary;
using com.qterminals.reporting;

namespace QTimeReportingEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            string jdkHome = @"C:\Dev\graalvm-ce-java17";
            string libPath = @"C:\Workspace\learn-dotnet\dotnet_java_sample\QTimeReportEngine-Bridge\dotnet-proxies";

            JVMLoader jVMLoader = new JVMLoader(jdkHome, libPath);

            JasperReportEngine jasperReportEngine = jVMLoader.GetJasperReportEngine();
            //jasperReportEngine.Run("test");
            byte[] pdfFileByte = jasperReportEngine.RunAndReturn("test");
            string pdfFilePath = "C:/reports/Report-Generated-By-Csharp.pdf";
            File.WriteAllBytes(pdfFilePath, pdfFileByte);

            Console.WriteLine("PDF file has been generated at {0}", pdfFilePath);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            Client qTHttpClient = new Client();
            var result = qTHttpClient.GetRequest("http://webcode.me").Result;
            Console.WriteLine("Status code: {0}", result.StatusCode);

            var content = result.Content.ReadAsStringAsync();
            Console.WriteLine("Content: {0}", content.Result);

            IAuthenticationContainerModel model = GetJWTContainerModel("Noman Ali", "nabbasi@QTerminals.com");
            IAuthenticationService authService = new JWTService(model.SecretKey);

            string token = authService.GenerateToken(model);
            Console.WriteLine("Generated Token: {0}", token);

            if (!authService.IsTokenValid(token))
                throw new UnauthorizedAccessException();
            else
            {
                List<Claim> claims = authService.GetTokenClaims(token).ToList();

                Console.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Name)).Value);
                Console.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Email)).Value);
            }
        }

        #region Private Methods
        private static JWTContainerModel GetJWTContainerModel(string name, string email)
        {
            return new JWTContainerModel()
            {
                Claims = new Claim[]
                {
                    new Claim(ClaimTypes.Name, name),
                    new Claim(ClaimTypes.Email, email)
                }
            };
        }
        #endregion
    }
}
