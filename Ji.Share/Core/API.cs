using Ji.Commons;
using Ji.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json.Serialization;
using RestSharp.Authenticators;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Ji.Core
{
    public static class API
    {
        #region Khai báo các biến, Property
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        /// Loại Token xác thực API
        /// </summary>
        public static readonly string TokenType = "bearer ";
        /// <summary>
        /// Access Token JWT để đăng nhập
        /// </summary>
        public static string AccessToken { get; set; }
        #endregion
        public static T Post<T>(string path, object param = null)
        {
            var client = new RestClient(UrlApi.Url + path);
            client.UseNewtonsoftJson();

            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", UrlApi.TokenType + AuthorizeConstant.Token);
            request.AddJsonBody(param);
            var res = client.Execute<T>(request);
            return res.Data;
        }

        public static T Get<T>(string path)
        {
            var client = new RestClient(UrlApi.Url + path);
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("Authorization", UrlApi.TokenType + AuthorizeConstant.Token);
            var res = client.Execute<T>(request);
            return res.Data;

        }
    }
}
