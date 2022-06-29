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
    }
}
