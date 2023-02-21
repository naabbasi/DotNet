using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace QTimeReportingEngine.QTHttpClient
{
    class Client
    {
        private static HttpClient httpClient;
        private static HttpRequestHeaders requestHeaders;

        public Client(List<HttpRequestHeaders> httpRequestHeaders = default(List<HttpRequestHeaders>))
        {
            if(httpClient == null)
            {
                httpClient = new HttpClient();
                if(httpRequestHeaders != null) 
                {
                    foreach(HttpRequestHeaders httpheader in httpRequestHeaders)
                    {
                        Console.WriteLine(httpheader);
                    }
                }  
            }

            Task<int> task = Method1();
            int count = task.Result;
            Console.WriteLine(count);
        }

        ~Client()
        {
            httpClient = null;
        }

        public async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });

            return count;
        }

        public async Task<HttpResponseMessage> GetRequest(string url)
        {
            var result = await httpClient.GetAsync(url);
            return result;
        }
    }
}
