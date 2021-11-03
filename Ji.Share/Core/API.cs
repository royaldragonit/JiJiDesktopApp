using Ji.Commons;
using Ji.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Ji.Core
{
    public static class API
    {
        #region Khai báo các biến, Property
        /// <summary>
        /// Access Token để đăng nhập
        /// </summary>
        public static string Access_Token { get; set; }
        public static string FacID { get; set; }
        public static IServiceProvider ServiceProvider { get; set; }
        public static int UpdateRecipe(int RecipeID, string Note)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Recipe/UpdateRecipe");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("RecipeID", RecipeID);
            request.AddParameter("Note", Note);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.VNDToNumber();
            return 0;
        }

        public static int ConvertTable(int fromFloor, int fromTable, int toTable)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Order/ConvertTable");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("FromFloor", fromFloor);
            request.AddParameter("FromTable", fromTable);
            request.AddParameter("ToTable", toTable);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.VNDToNumber();
            return 0;
        }

        public static string GetPriceFood(int FoodID)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/GetPriceFood");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("FoodID", FoodID);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return "0";
        }

        /// <summary>
        /// Loại Token
        /// </summary>
        public static readonly string Token_Type = "bearer ";
        #endregion
        public static SetupShops GetSetup<T>(string url, string access_Token, string facID)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("FacID", facID);
            var response = client.Post<SetupShops>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        public static T Post<T>(string url,object param=null)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", UrlApi.TokenType + AuthorizeConstant.Token); client.ConfigureWebRequest((r) =>
            {
                r.ServicePoint.Expect100Continue = false;
                r.KeepAlive = true;
            });
            request.AddJsonBody(param);
            var data = client.Execute<T>(request);
            return data.Data;
        }
        public static T Get<T>(string url)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", UrlApi.TokenType + AuthorizeConstant.Token); client.ConfigureWebRequest((r) =>
            {
                r.ServicePoint.Expect100Continue = false;
                r.KeepAlive = true;
            });
            var data = client.Execute<T>(request);
            return data.Data;
        }
        public static int AddResourceRecipe(int PriceCost, int Quantity, int ResourcesID, int RecipeID)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Recipe/AddResourceRecipe");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("PriceCost", PriceCost);
            request.AddParameter("Quantity", Quantity);
            request.AddParameter("ResourcesID", ResourcesID);
            request.AddParameter("RecipeID", RecipeID);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.VNDToNumber();
            return -1;
        }

        public static int AddResource(string ResourceName, string BrandName, string Price, string Quantity, string QuantityInAUnit, string Unit)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Poached/AddResource");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("ResourceName", ResourceName);
            request.AddParameter("BrandName", BrandName);
            request.AddParameter("Price", Price);
            request.AddParameter("Quantity", Quantity);
            request.AddParameter("QuantityInAUnit", QuantityInAUnit);
            request.AddParameter("Unit", Unit);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.VNDToNumber();
            return 0;
        }

        public static string SetDefaultDLL(string fileName2, string className)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/SetDefaultDLL");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("DLL", fileName2);
            request.AddParameter("ClassName", className);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return null;
        }

        public static IEnumerable<Messenger> LoadMessenger(int iD)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/GetMessenger");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("CustomerID", iD);
            var response = client.Post<List<Messenger>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static Recipe AddRecipe(DateTime CreateOn, int FoodID)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Recipe/AddRecipe");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("CreateOn", CreateOn);
            request.AddParameter("FoodID", FoodID);
            var response = client.Post<Recipe>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static IEnumerable<T> GetFloors<T>(string url, string access_Token)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static IEnumerable<T> LoadAllMenu<T>(string url, string access_Token)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static IEnumerable<T> GetUsers<T>(string url, string access_Token)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static int SetSetup(string ShopName, string Abbreviation, string Phone, string Address, string Slogan, bool ShowBarCode, string DefaultPrint, string FaceBook, string Logo, int NumberPrintBill, bool WarningCheckout)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Setup/SetSetup");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("ShopName", ShopName);
            request.AddParameter("Abbreviation", Abbreviation);
            request.AddParameter("WarningCheckout", WarningCheckout);
            request.AddParameter("Phone", Phone);
            request.AddParameter("Logo", Logo);
            request.AddParameter("FaceBook", FaceBook);
            request.AddParameter("Address", Address);
            request.AddParameter("DefaultPrint", DefaultPrint);
            request.AddParameter("NumberPrintBill", NumberPrintBill);
            request.AddParameter("ShowBarCode", ShowBarCode);
            request.AddParameter("Slogan", Slogan);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.VNDToNumber();
            return 0;
        }

        public static IEnumerable<T> GetAllFormula<T>(string url, string access_Token)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static IEnumerable<T> GetResources<T>()
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Poached/GetResources");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static int SaveFormula(string url, string access_Token, Guid guid, int categoryID, string thanhPhan, string congThuc, string foodName, string unit, int price, int PriceInput, int CreateBy)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("FormulaID", guid);
            request.AddParameter("CategoryID", categoryID);
            request.AddParameter("Component", thanhPhan);
            request.AddParameter("Formula", congThuc);
            request.AddParameter("FoodName", foodName);
            request.AddParameter("Unit", unit);
            request.AddParameter("Price", price);
            request.AddParameter("PriceInput", PriceInput);
            request.AddParameter("CreateBy", CreateBy);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.ToInt();
            return 0;
        }

        /// <summary>
        /// Cập nhật User
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static string UpdateUser(Users users, string ListAppID)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Users/UpdateUser");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            var serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;
            var json = serializer.Serialize(users);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("Users", json);
            request.AddParameter("ListAppID", ListAppID);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return null;
        }

        public static string GetPermissionUser(int userID)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Users/GetPermissionUser");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("UserID", userID);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return null;
        }

        /// <summary>
        /// Thêm mới một menu 
        /// </summary>
        /// <param name="menus"></param>
        /// <returns></returns>
        public static string UpdateMenu(Menus menus)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/UpdateMenu");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/json");
            string JSONresult = JsonConvert.SerializeObject(menus);
            request.AddParameter("application/json", JSONresult, ParameterType.RequestBody);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return "0";
        }


        public static string AddMenu(Menus menus)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/AddMenu");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/json");
            string JSONresult = JsonConvert.SerializeObject(menus);
            request.AddParameter("application/json", JSONresult, ParameterType.RequestBody);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return null;
        }
        public static int RemoveRevenue(int orderID)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Report/RemoveRevenue");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("OrderID", orderID);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.ToInt();
            return -1;
        }

        /// <summary>
        /// Hàm gửi yêu cầu để in lại Bill
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="access_Token"></param>
        /// <param name="billID"></param>
        /// <returns></returns>
        public static IEnumerable<T> API_RePrinter<T>(string url, string access_Token, int billID)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("BillID", billID);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static string CreateUser(Users users)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Users/CreateUser");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            var serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;
            var json = serializer.Serialize(users);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("Users", json);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return null;
        }

        /// <summary>
        /// Hàm lấy dữ liệu chi tiền từ ngày <paramref name="a"/> đến ngày <paramref name="b"/>
        /// </summary>
        /// <param name="v"></param>
        /// <param name="access_Token"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public static IEnumerable<T> PayDistanceFromTo<T>(string url, string access_Token, DateTime a, DateTime b)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("DateFrom", a);
            request.AddParameter("DateTo", b);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static IEnumerable<T> GetOrders<T>(string url, string access_Token)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        /// <summary>
        /// Hàm thêm 1 lần chi trong ngày
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="access_Token"></param>
        /// <param name="billID"></param>
        /// <returns></returns>
        public static bool AddPay(string url, string access_Token, int Money, string Reason, string CreateBy, DateTime DateCreate, string TypePay)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("Money", Money);
            request.AddParameter("Reason", Reason);
            request.AddParameter("CreateBy", CreateBy);
            request.AddParameter("DateCreate", DateCreate);
            request.AddParameter("TypePay", TypePay);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return Convert.ToBoolean(response.Content);
            return false;
        }

        public static void SetActiveMenu(int foodID)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/SetActiveMenu");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("FoodID", foodID);
            var response = client.Post(request);
        }

        /// <summary>
        /// Lấy danh sách chi tiền trong ngày
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="access_Token"></param>
        /// <param name="Today"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetPayToDay<T>(string url, string access_Token, DateTime Today)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("Today", Today);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static IEnumerable<T> GetAllToppings<T>(string url, string access_Token)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        /// <summary>
        /// Lấy thông tin đăng nhập của Username
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="access_Token"></param>
        /// <returns></returns>
        public static Users GetInformationUser(string url, string access_Token)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            var response = client.Post<Users>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static int DeleteOrder(int floor, int table)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Order/DeleteOrder");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("Floor", floor);
            request.AddParameter("Table", table);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.VNDToNumber();
            return -1;
        }

        public static int RemoveOrderItems(int orderID, int foodID, string toppingID)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Order/RemoveOrderItems");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("OrderID", orderID);
            request.AddParameter("FoodID", foodID);
            request.AddParameter("ToppingID", toppingID);
            var response = client.Post<int>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return -1;
        }
        public static string ToJson(this Dictionary<string, string> dict)
        {
            var entries = dict.Select(d =>
                string.Format("\"{0}\": {1}", d.Key, string.Join(",", d.Value)));
            return "{" + string.Join(",", entries) + "}";
        }
        /// <summary>
        /// Hàm đăng nhập sử dụng API get về Token <see cref="API_LOGIN(string, string, string)"/>
        /// </summary>
        /// <param name="url"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string API_LOGIN(string url, string username, string password)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"Username\":\""+username+ "\",\r\n    \"Password\":\"" + password + "\"\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
        /// <summary>
        /// Hàm lấy chi tiết hóa đơn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="access_Token"></param>
        /// <param name="billID"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetBillDetail<T>(string url, string access_Token, int billID) where T : new()
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("BillID", billID);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        /// <summary>
        /// Hàm lấy tất cả các Application
        /// </summary>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static string API_GetAllApplication(string url, string token)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + token);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return string.Empty;
        }
        /// <summary>
        /// Hàm Checkout (tính tiền)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <param name="OrderID"></param>
        /// <param name="Discount"></param>
        /// <param name="CustomerName"></param>
        /// <param name="CustomerPhone"></param>
        /// <param name="date"></param>
        /// <param name="CustomerMoney"></param>
        /// <returns></returns>
        public static int API_ReportBill<T>(string url, string token, int OrderID, int Discount, string CustomerName, string CustomerPhone, DateTime date, int CustomerMoney, string Cashier, DateTime TimeCheckout, string CustomerRefund, int TotalMoney, DataTable orders, int? customerID, string delivery) where T : new()
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Content-Type", "application/json");
            orders.Columns.Add("OrderID",typeof( int));
            orders.Columns.Add("Discount", typeof(int));
            orders.Columns.Add("CustomerName", typeof(string));
            orders.Columns.Add("CustomerID", typeof(int));
            orders.Columns.Add("Delivery", typeof(string));
            orders.Columns.Add("CustomerPhone", typeof(string));
            orders.Columns.Add("TimeCheckout", typeof(DateTime));
            orders.Columns.Add("Cashier", typeof(string));
            orders.Columns.Add("CustomerRefund", typeof(string));
            orders.Columns.Add("date", typeof(DateTime));
            orders.Columns.Add("CustomerMoney", typeof(int));
            orders.Columns.Add("TotalMoney", typeof(int));
            foreach (DataRow item in orders.Rows)
            {
                item["OrderID"] = OrderID;
                item["Discount"] = Discount;
                item["CustomerName"] = CustomerName;
                item["CustomerID"] = customerID??-1;
                item["Delivery"] =delivery;
                item["CustomerPhone"] = CustomerPhone;
                item["TimeCheckout"] = TimeCheckout;
                item["Cashier"] = Cashier;
                item["CustomerRefund"] = CustomerRefund;
                item["date"] = date;
                item["CustomerMoney"] = CustomerMoney;
                item["TotalMoney"] = TotalMoney;
            }
            string JSONresult = JsonConvert.SerializeObject(orders);
            request.AddParameter("application/json", JSONresult,ParameterType.RequestBody);
            var response = client.Post<int>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return -1;
        }
        public static string DataTableToJsonObj(this DataTable dt)
        {
            DataSet ds = new DataSet();
            ds.Merge(dt);
            StringBuilder JsonString = new StringBuilder();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                JsonString.Append("[");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    JsonString.Append("{");
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        if (j < ds.Tables[0].Columns.Count - 1)
                        {
                            JsonString.Append("\r\n\"" + ds.Tables[0].Columns[j].ColumnName.ToString() + "\":" + "\"" + ds.Tables[0].Rows[i][j].ToString() + "\",\r\n");
                        }
                        else if (j == ds.Tables[0].Columns.Count - 1)
                        {
                            JsonString.Append("\r\n\"" + ds.Tables[0].Columns[j].ColumnName.ToString() + "\":" + "\"" + ds.Tables[0].Rows[i][j].ToString() + "\"\r\n");
                        }
                    }
                    if (i == ds.Tables[0].Rows.Count - 1)
                    {
                        JsonString.Append("}");
                    }
                    else
                    {
                        JsonString.Append("},");
                    }
                }
                JsonString.Append("\r\n]");
                return JsonString.ToString();
            }
            else
            {
                return null;
            }
        }
        public static IEnumerable<T> GetAllFood<T>(string url, string access_Token)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + access_Token);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        /// <summary>
        /// Hàm tính doanh thu trong ngày
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetRevenueToday<T>(string url, string token, DateTime date) where T : new()
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("date", date);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        public static IEnumerable<T> GetAllCategory<T>(string url, string token) where T : new()
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        /// <summary>
        /// Hàm tính doanh từ ngày a đến ngày b
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetRevenue<T>(string url, string token, DateTime from, DateTime to) where T : new()
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("FromDate", from);
            request.AddParameter("ToDate", to);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }

        public static int SetNoteOrder(int orderID, string note)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Order/SetNoteOrder");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("Note", note);
            request.AddParameter("OrderID", orderID);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.ToInt();
            return 0;
        }

        /// <summary>
        /// API thêm món vào danh sách Order
        /// </summary>
        /// <param name="floor"></param>
        /// <param name="listToppingID"></param>
        /// <param name="FoodID"></param>
        /// <param name="table"></param>
        public static List<OrderDetailV2> AddOrderItems(List<AddListOrder> listOrders)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Order/AddListOrder");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            request.AddHeader("Content-Type", "application/json");
            string json = JsonConvert.SerializeObject(listOrders);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            var response = client.Post<List<OrderDetailV2>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        /// <summary>
        /// API thêm món vào danh sách Order
        /// </summary>
        /// <param name="floor"></param>
        /// <param name="table"></param>
        public static List<OrderDetailV2> GetDataOrder(int floor, int table)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Order/GetListOrder?Table=" + table+"&Floor="+floor);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            var response = client.Post<List<OrderDetailV2>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        public static string GetTotalMoneyOrder()
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Order/GetTotalMoneyOrder");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + Access_Token);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return null;
        }

        /// <summary>
        /// Hàm lấy tất cả danh sách Topping
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IEnumerable<T> API_GetAllTopping<T>(string url) where T : new()
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            var response = client.Get<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        /// <summary>
        /// Hàm lấy danh sách order
        /// </summary>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <param name="table"></param>
        /// <param name="floor"></param>
        /// <returns></returns>
        public static string API_GetDataOrder(string url, string token, int table, int floor)
        {
            //var client = new RestClient("https://localhost:44369/api/Application/AllApplication");
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + token);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            return string.Empty;
        }
        /// <summary>
        /// Hàm lấy tất cả Application
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static IEnumerable<T> API_GetAllApplication<T>(string url, string token) where T : new()
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Token_Type + token);
            var response = client.Post<List<T>>(request);
            //IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
    }
}
