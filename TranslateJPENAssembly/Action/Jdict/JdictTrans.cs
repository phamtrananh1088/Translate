using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Anh.Translate.Action.Jdict
{
    public class JdictTrans
    {
		/// <summary>
		/// analyzer Text
		/// </summary>
		/// <param name="q"></param>
		/// <returns>JArray</returns>
		public async Task<JObject> analyzer(string q)
		{
			string res = "";
			HttpResponseMessage response = null;
			try
			{
				//HttpClientHandler handler = new HttpClientHandler()
				//{
				//    Proxy = new WebProxy("http://192.168.0.12"),
				//    UseProxy = true,
				//};
				//using (var client = new HttpClient(handler))
				using (var client = new HttpClient())
				{
					//specify to use TLS 1.2 as default connection
					//System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
					client.BaseAddress = new Uri("https://jdict.net");
					HttpRequestHeaders reqH = client.DefaultRequestHeaders;
					Authen(ref reqH);

					string path = "/api/v1/analyzer";
					JObject mix = new JObject();
					mix.Add("keyword", q);
					response = await client.PostAsJsonAsync(path, mix);
				}
			}
			catch (Exception ex)
			{
				Debug.Fail("エラー: {0}", ex.ToString());
			}
			finally
			{
			}

			if (response.IsSuccessStatusCode)
			{
				res = await response.Content.ReadAsStringAsync();
			}
			JObject jj = JsonConvert.DeserializeObject(res) as JObject;

			return jj;
		}

		private void Authen(ref HttpRequestHeaders reqH)
		{
			reqH.Add("authority", "jdict.net");
			string chrome = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.142 Safari/537.36";
			reqH.Add("user-agent", chrome);
		}
	}
}
