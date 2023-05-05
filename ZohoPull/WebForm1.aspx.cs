/*    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;

    namespace ZohoPull
    {
        public partial class WebForm1 : System.Web.UI.Page
        {
            private readonly object responseObj;
            private string access_token;

            protected void Page_Load(object sender, EventArgs e)
            {

            }
            public async void GetToken(object sender, EventArgs e)
        {
                string code = Request.QueryString["code"];
            *//*var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://accounts.zoho.in/oauth/v2/auth?scope=Zohobooks.fullaccess.all&client_id=1000.CDIM4I23HBPMVUSG6OMG7VNWQSM5AC&response_type=" + code + "&redirect_uri=http://www.zoho.com/books&access_type=online");
            request.Headers.Add("Cookie", "stk=592836b1c83791f294f91a3a3b6e2519; 6e73717622=a666ff609d879e0aed399e8010732d82; _zcsr_tmp=c9e2678d-5c70-41c4-9dd1-12c36975b5df; iamcsr=c9e2678d-5c70-41c4-9dd1-12c36975b5df");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic responseObj = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
            string accessToken = responseObj.access_token;*/

/* var client = new HttpClient();
 string Url = "https://accounts.zoho.in/oauth/v2/auth?scope=ZohoBooks.fullaccess.all&client_id=1000.CDIM4I23HBPMVUSG6OMG7VNWQSM5AC&state=testing&response_type=" + code + "&redirect_uri=https://zohobooks.com/&access_type=offline";
 var request = new HttpRequestMessage(HttpMethod.Get, Url);
 request.Headers.Add("Cookie", "stk=592836b1c83791f294f91a3a3b6e2519; 6e73717622=a666ff609d879e0aed399e8010732d82; JSESSIONID=0795BAFC62237DF82326165EB7C092FA; _zcsr_tmp=c9e2678d-5c70-41c4-9dd1-12c36975b5df; iamcsr=c9e2678d-5c70-41c4-9dd1-12c36975b5df");
 var response = await client.SendAsync(request);
 response.EnsureSuccessStatusCode();
 string jsonResponse = await response.Content.ReadAsStringAsync();
 dynamic responseObj = JsonConvert.DeserializeObject<dynamic>(jsonResponse);*//*

var client = new HttpClient();
var url = "https://accounts.zoho.in/oauth/v2/auth?scope=ZohoBooks.fullaccess.all&client_id=1000.CDIM4I23HBPMVUSG6OMG7VNWQSM5AC&response_type=" + code + "&redirect_uri=https://www.zoho.com/books&access_type=online";
var request = new HttpRequestMessage(HttpMethod.Post, url);
request.Headers.Add("Cookie", "stk=592836b1c83791f294f91a3a3b6e2519; 6e73717622=a666ff609d879e0aed399e8010732d82; JSESSIONID=0795BAFC62237DF82326165EB7C092FA; _zcsr_tmp=c9e2678d-5c70-41c4-9dd1-12c36975b5df; iamcsr=c9e2678d-5c70-41c4-9dd1-12c36975b5df");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
string jsonResponse = await response.Content.ReadAsStringAsync();
dynamic responseObj = JsonConvert.DeserializeObject<dynamic>(jsonResponse);

*//*var proxyUrl = "https://your-proxy-endpoint.herokuapp.com/";
var zohoUrl = "https://accounts.zoho.in/oauth/v2/auth?scope=ZohoBooks.fullaccess.all&client_id=1000.CDIM4I23HBPMVUSG6OMG7VNWQSM5AC&response_type=" + code + "&redirect_uri=https://www.zoho.com/books&access_type=online";

var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Post, proxyUrl);
request.Headers.Add("X-Target-Url", zohoUrl);
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
string jsonResponse = await response.Content.ReadAsStringAsync();
dynamic responseObj = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
string accessToken = responseObj.access_token;*//*


string accessToken = responseObj.access_token;
File.WriteAllText("access_token.txt", accessToken);

    Response.Write(code);
*//*res2.Text = accessToken;
res3.Text = jsonResponse;*//*


// var auth_token = Request.QueryString["code"];
*//* var client_id = "1000.CDIM4I23HBPMVUSG6OMG7VNWQSM5AC";
 var client_secret = "9398112eab8b9a15cf2cfefe54b26c691ff64db3be";
 var redirect_uri = "http://www.zoho.com/books";*/

/*            var access_token = GetAccessToken(auth_token, client_id, client_secret, redirect_uri).Result;
*//*

// File.WriteAllText("access_token.txt", access_token);

// Console.WriteLine($"Access token: {access_token}");
}

*//*  static async Task<string> GetAccessToken(string auth_token, string client_id, string client_secret, string redirect_uri)
  {
      var url = $"https://accounts.zoho.com/oauth/v2/token?code={auth_token}&redirect_uri={redirect_uri}&client_id={client_id}&client_secret={client_secret}&grant_type=authorization_code";

      var client = new HttpClient();
      var response = await client.PostAsync(url, null);
      var responseBody = await response.Content.ReadAsStringAsync();

      if (response.IsSuccessStatusCode)
      {
          dynamic json = JsonConvert.DeserializeObject(responseBody);
          return json.access_token;
      }
      else
      {
          throw new Exception($"Failed to get access token: {responseBody}");
      }*//*
  }
}
*/

using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace ZohoPull
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string access_token;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public async void GetToken(object sender, EventArgs e)
        {
            string code = Request.QueryString["code"];
            string encodedCode = HttpUtility.UrlEncode(code);

            var client = new HttpClient();
            var url = "https://accounts.zoho.in/oauth/v2/auth?scope=ZohoBooks.fullaccess.all&client_id=1000.CDIM4I23HBPMVUSG6OMG7VNWQSM5AC&response_type=" + encodedCode + "&redirect_uri=https://www.zoho.com/books&access_type=online";
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("Cookie", "stk=592836b1c83791f294f91a3a3b6e2519; 6e73717622=a666ff609d879e0aed399e8010732d82; JSESSIONID=0795BAFC62237DF82326165EB7C092FA; _zcsr_tmp=c9e2678d-5c70-41c4-9dd1-12c36975b5df; iamcsr=c9e2678d-5c70-41c4-9dd1-12c36975b5df");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic responseObj = JsonConvert.DeserializeObject<dynamic>(jsonResponse);

            string accessToken = responseObj.access_token;
            File.WriteAllText("access_token.txt", accessToken);

            Response.Write(code);
        }
    }
}
