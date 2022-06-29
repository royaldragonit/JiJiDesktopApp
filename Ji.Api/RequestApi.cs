using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Api
{
    public class RequestApi
    {
        private readonly RestClient _client;
        public RequestApi()
        {
            _client = new RestClient("http://localhost:38901/");
        }
        public string Get()
        {
            string token= "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJhZG1pbiIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJob2FuZ2xvbmdpdDk2IiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiIxIiwiVXNlck5hbWUiOiJob2FuZ2xvbmdpdDk2IiwiRmFjSWQiOiIzIiwiZXhwIjoxNjU2MzczMDM2LCJpc3MiOiJUcmFzdWFqaWppLmNvbSIsImF1ZCI6IlRyYXN1YWppamkuY29tIn0.pAh2pcqgTukvDY-3ynPR4vIXj2MGfmu_hmymwnPrYwc";
            var client = new RestClient("http://localhost:38901/api/System/GetConfigureStore");
            var request = new RestRequest();
            request.Method = Method.Get;
            JwtAuthenticator jwt = new JwtAuthenticator(token);
            jwt.SetBearerToken(token);
            client.Authenticator = jwt;
            client.UseAuthenticator(jwt);
            request.AddHeader("Authorization", "Bearer "+ token);
            request.AddHeader("testAuthen", "Bearer "+ token);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response.Content;

        }
    }
}
