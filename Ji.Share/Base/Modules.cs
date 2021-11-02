using DevExpress.Utils.Extensions;
using Ji.Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Base
{
    public enum APIMethod
    {
        POST,
        GET,
        PUT,
        DELETE,
        PATCH
    }
    public abstract class Modules 
    {
        
    }
    /// <summary>
    /// Lớp tham số
    /// </summary>
    public class Parameter
    {
        public static Parameter Parameters;
        public static Parameter CreateParameter()
        {
            if (Parameters == null)
                Parameters = new Parameter();
            return Parameters;
        }
        public string Query { get; set; }
        public string Methods { get; set; }
        public Dictionary<string, object> Params = new Dictionary<string, object>();
        /// <summary>
        /// Truyền vào Params[<paramref name="key"/>] = value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object this[string key]
        {
            get
            {
                return Params;
            }
            set
            {
                Params[key] = value;
            }
        }
        private RestClient Client;
        public RestClient GetClient(string Url)
        {
            Client = new RestClient(Url);
            Client.Timeout = -1;
            return Client;
        }
        /// <summary>
        /// Get giá trị trong app.config by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString();
        }
        /// <summary>
        /// Hàm này gọi khi gọi API đến các câu truy vấn như INSERT/UPDATE/DELETE trả về số lượng dòng bị ảnh hưởng bởi câu truy vấn
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual int Modify(Parameter p, APIMethod method)
        {
            RestRequest request = new RestRequest();
            foreach (var item in p.Params)
                request.AddParameter(item.Key, item.Value);
            request.AddParameter("Query", p.Query);
            RestClient api = GetClient(GetAppSetting("API") + "Excute/Modify");
            IRestResponse<int> response;
            switch (method)
            {
                case APIMethod.POST:
                    request.Method = Method.POST;
                    response = api.Post<int>(request);
                    break;
                case APIMethod.GET:
                    request.Method = Method.GET;
                    response = api.Get<int>(request);
                    break;
                case APIMethod.PUT:
                    request.Method = Method.PUT;
                    response = api.Put<int>(request);
                    break;
                case APIMethod.DELETE:
                    request.Method = Method.DELETE;
                    response = api.Delete<int>(request);
                    break;
                case APIMethod.PATCH:
                    request.Method = Method.PATCH;
                    response = api.Patch<int>(request);
                    break;
                default:
                    response = Client.Post<int>(request);
                    break;
            }
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            else
                throw new Exception(response.StatusDescription);
        }
        /// <summary>
        /// Hàm này trả về ô đầu tiên và dòng đầu tiên của câu truy vấn
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual T Execute<T>(Parameter p, APIMethod method)
        {
            RestRequest request = new RestRequest();
            foreach (var item in p.Params)
                request.AddParameter(item.Key, item.Value);
            request.AddParameter("Query", p.Query);
            RestClient api = GetClient(GetAppSetting("API") + "Excute/Excute");
            IRestResponse<T> response;
            switch (method)
            {
                case APIMethod.POST:
                    request.Method = Method.POST;
                    response = api.Post<T>(request);
                    break;
                case APIMethod.GET:
                    request.Method = Method.GET;
                    response = api.Get<T>(request);
                    break;
                case APIMethod.PUT:
                    request.Method = Method.PUT;
                    response = api.Put<T>(request);
                    break;
                case APIMethod.DELETE:
                    request.Method = Method.DELETE;
                    response = api.Delete<T>(request);
                    break;
                case APIMethod.PATCH:
                    request.Method = Method.PATCH;
                    response = api.Patch<T>(request);
                    break;
                default:
                    response = Client.Post<T>(request);
                    break;
            }
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            else
                throw new Exception(response.StatusDescription);
        }
        /// <summary>
        /// Hàm này gọi khi gọi API đến các câu truy vấn trả về 1 đối tượng kiểu class
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual T ExecuteForObject<T>(Parameter p, APIMethod method) where T : class
        {
            if (p["Url"] == null)
                throw new Exception("Thiếu đường dẫn API, vui lòng đặt URL bên trong param[\"URL\"]");
            RestClient api = GetClient(p["URL"].ToString());
            RestRequest request = new RestRequest();
            foreach (var item in p.Params)
                request.AddParameter(item.Key, item.Value);
            request.AddParameter("Query", p.Query);
            IRestResponse<T> response;
            request.AddHeader("Authorization", p["Token"]?.ToString());
            switch (method)
            {
                case APIMethod.POST:
                    request.Method = Method.POST;
                    response = Client.Post<T>(request);
                    break;
                case APIMethod.GET:
                    request.Method = Method.GET;
                    response = Client.Get<T>(request);
                    break;
                case APIMethod.PUT:
                    request.Method = Method.PUT;
                    response = Client.Put<T>(request);
                    break;
                case APIMethod.DELETE:
                    request.Method = Method.DELETE;
                    response = Client.Delete<T>(request);
                    break;
                case APIMethod.PATCH:
                    request.Method = Method.PATCH;
                    response = Client.Patch<T>(request);
                    break;
                default:
                    response = Client.Post<T>(request);
                    break;
            }
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            else
                throw new Exception(response.StatusDescription);
        }
        /// <summary>
        /// Hàm này gọi khi gọi API đến các câu truy vấn trả về 1 đối tượng
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual object ExecuteForObject()
        {
            RestClient api = GetClient(GetAppSetting("API") + "Execute/Execute");
            RestRequest request = new RestRequest();
            foreach (var item in Params)
                request.AddParameter(item.Key, item.Value);
            request.AddParameter("Query", Query);
            IRestResponse<DataTable> response;
            request.AddHeader("Authorization", "Bearer " + API.Access_Token);
            switch (Methods.ToLower())
            {
                case "post":
                    request.Method = Method.POST;
                    response=api.Post<DataTable>(request);
                    break;
                case "get":
                    request.Method = Method.GET;
                    response = api.Get<DataTable>(request);
                    break;
                case "put":
                    request.Method = Method.PUT;
                    response = api.Put<DataTable>(request);
                    break;
                case "delete":
                    request.Method = Method.DELETE;
                    response = api.Delete<DataTable>(request);
                    break;
                case "patch":
                    request.Method = Method.PATCH;
                    response = api.Patch<DataTable>(request);
                    break;
                default:
                    response = api.Post<DataTable>(request);
                    break;
            }
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            else
                throw new Exception(response.StatusDescription);
        }
        /// <summary>
        /// Hàm này gọi khi gọi API đến các câu truy vấn trả về 1 danh sách đối tượng
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> ExecuteForList<T>() where T : class
        {
            RestClient api = GetClient(GetAppSetting("API") + "Execute/ExecuteForList");
            RestRequest request = new RestRequest();
            IRestResponse<List<T>> response;
            foreach (var item in Params)
                request.AddParameter(item.Key, item.Value);
            request.AddParameter("Query", Query);
            request.AddHeader("Authorization", "Bearer " + API.Access_Token);
            switch (Methods)
            {
                case "post":
                    request.Method = Method.POST;
                    response = api.Post<List<T>>(request);
                    break;
                case "get":
                    request.Method = Method.GET;
                    response = api.Get<List<T>>(request);
                    break;
                case "put":
                    request.Method = Method.PUT;
                    response = api.Put<List<T>>(request);
                    break;
                case "delete":
                    request.Method = Method.DELETE;
                    response = api.Delete<List<T>>(request);
                    break;
                case "patch":
                    request.Method = Method.PATCH;
                    response = api.Patch<List<T>>(request);
                    break;
                default:
                    response = api.Post<List<T>>(request);
                    break;
            }
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            else
                throw new Exception(response.StatusDescription);
        }
    }
}
