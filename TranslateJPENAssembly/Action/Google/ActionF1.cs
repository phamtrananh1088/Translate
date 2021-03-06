using Anh.Translate.Model;
using Anh.Translate.Model.GoogleApi;
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

namespace Anh.Translate
{
	public class ActionF1 : ActionBase
	{
		public const string ecoEscapeBlank = "'";
		/// <summary>
		/// Translate Single Text
		/// </summary>
		/// <param name="tk_q"></param>
		/// <returns></returns>
		public async Task<JObject> GetSingle(string q, string sl = "ja", string tl = "en")
		{
			//PTANH2021/12/24 vandeso1: [2021/12/24yeucau] [update API: use new URL]
			//string tk = ActionF1.GetTk(q);
			string encodeQ = Uri.EscapeDataString(q);
			//PTANH2021/12/24 vandeso1: [2021/12/24yeucau] [update API: use new URL]
			//string tk_q = tk + "&q=" + encodeQ;
			string tk_q = "&q=" + encodeQ;
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
					client.BaseAddress = new Uri(ActionBase.UrlTranslateGoogleWebAPI);
					HttpRequestHeaders reqH = client.DefaultRequestHeaders;
					Authen(ref reqH);
					reqH.Add(HttpRequestHeader.Cookie.ToString(), "NID=188=" + RenCookie());
					//HTTP GET
					//PTANH2021/12/24 vandeso1: [2021/12/24yeucau] [update API: use new URL]
					//string[] paths = new string[] { "/translate_a/single?client=webapp&sl={0}&tl={1}&hl=vi&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&otf=2&ssel=0&tsel=0&kc=1{2}",
					//								"/translate_a/single?client=webapp&sl={0}&tl={1}&hl=vi&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&otf=2&ssel=3&tsel=3&kc=4{2}",
					//								"/translate_a/single?client=webapp&sl={0}&tl={1}&hl=vi&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&otf=2&ssel=3&tsel=3&kc=1{2}",
					//								"/translate_a/single?client=webapp&sl={0}&tl={1}&hl=vi&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&otf=1&ssel=3&tsel=3&kc=5{2}",
					//								"/translate_a/single?client=webapp&sl={0}&tl={1}&hl=vi&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&otf=2&ssel=3&tsel=3&kc=6{2}",
					//								"/translate_a/single?client=webapp&sl={0}&tl={1}&hl=vi&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&otf=2&ssel=3&tsel=3&kc=2{2}",
					//								"/translate_a/single?client=webapp&sl={0}&tl={1}&hl=vi&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&otf=1&ssel=3&tsel=3&kc=7{2}"};
					//Random r = new Random();
					//int i = r.Next(0, 7);
					//PTANH2021/12/24 vandeso1: [2021/12/24yeucau] [update API: use new URL]
					//string path = string.Format(paths[0], sl, tl, tk_q);
					string path = string.Format("/translate_a/single?client=gtx&dt=t&dt=bd&dj=1&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=at&sl={0}&tl={1}{2}", sl, tl, tk_q);
					
					response = await client.GetAsync(path);
				}
			}
			catch (Exception ex)
			{
				Debug.Fail("エラー: {0}", ex.ToString());
			}
			finally
			{
			}
			//try
			//{
			//    response.EnsureSuccessStatusCode();
			//    // Handle success
			//    res = await response.Content.ReadAsStringAsync();
			//}
			//catch (HttpRequestException ex)
			//{
			//    throw ex;
			//    // Handle failure
			//}
			if (response.IsSuccessStatusCode)
			{
				res = await response.Content.ReadAsStringAsync();
			}
			JObject jo = JsonConvert.DeserializeObject(res) as JObject;

			return jo;
		}

		/// <summary>
		/// Voice text
		/// </summary>
		/// <param name="q"></param>
		/// <param name="tl"></param>
		/// <returns></returns>
		public async Task<byte[]> Translate_tts(string q, string tl = "ja")
		{
			string tk = ActionF1.GetTk(q);
			var iTextLen = q.Length;
			string encodeQ = Uri.EscapeDataString(q);
            byte[] res = null;
			HttpResponseMessage response = null;
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(ActionBase.UrlTranslateGoogleWebAPI);
					HttpRequestHeaders reqH = client.DefaultRequestHeaders;
					Authen(ref reqH);
					reqH.Add(HttpRequestHeader.Cookie.ToString(), "NID=188=" + RenCookie());
					string pathH = "/translate_tts?ie=UTF-8{0}&tl={1}&total=1&idx=0&textlen={2}{3}&client=webapp&prev=input";
					string path = string.Format(pathH, encodeQ, tl, iTextLen, tk);
					response = await client.GetAsync(path);
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
				res = await response.Content.ReadAsByteArrayAsync();
			}
			return res;
		}

		public string RenCookie()
		{
			Random r = new Random();
			int i = r.Next(0, 1);
			return cookies[i];
		}

		static string[] cookies = new string[]
		{
			"188=XFYB2Lnp4nax9yrsHueGO_c5X5mbBYLo5L95ZRPwDB-dvpyttWrVYyabPHPoHv_ItYhmdUOwlR1vE3lFvG7BgzEMxNgjjFX6Uv9gHmz6bvK-IdzbeNeq3oz8b60ZMSEahO97uW3ws2kIzvHQRgR9l_Dl9afmTtzRr3q2IIRWJlU",
		};
		private async Task<string> LogGetSingle(string q)
		{

			string res = "";
			HttpResponseMessage response = null;
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(ActionBase.UrlPlayGoogleWebAPI);
					HttpRequestHeaders reqH = client.DefaultRequestHeaders;
					Authen(ref reqH);
					//client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
					//client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
					//HTTP POST
					string path = "/log?format=json&hasfast=true&authuser=0";
					JArray data = GetLogData(q);
					//var buffer = System.Text.Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
					//var byteContent = new ByteArrayContent(buffer);
					//byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
					StringContent ct = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
					response = await client.PostAsync(path, ct);
					//var Tresponse = client.PostAsJsonAsync<JArray>(path, data);
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

			return res;
		}

		public async Task<HttpResponseMessage> GetTEST(string encodeQ)
		{
			HttpResponseMessage res = null;
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(ActionBase.UrlZenWebAPI);
					HttpRequestHeaders reqH = client.DefaultRequestHeaders;
					//Authen(ref reqH);
					//HTTP GET
					string path = "Kokyaku/Get新規登録番号?asBumonCd={0}";
					path = string.Format(path, encodeQ);
					res = await client.GetAsync(path);
				}
			}
			catch (Exception ex)
			{
				Debug.Fail("エラー: {0}", ex.ToString());
			}
			finally
			{
			}
			return res;
		}
		private void Authen(ref HttpRequestHeaders reqH)
		{
			reqH.Add("authority", "translate.google.com.vn");
			//reqH.Add("accept", "*/*");
			//reqH.Accept.Clear();
			//reqH.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			//reqH.Add("scheme", "https");
			//reqH.Add("method", "GET");
			//reqH.Add("accept-encoding", "gzip, deflate, br");
			//reqH.Add("accept-language", "en-US,en;q=0.9,vi;q=0.8,fr-FR;q=0.7,fr;q=0.6");
			//reqH.Add("referer", "https://translate.google.com.vn/?hl=vi");
			string chrome = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.142 Safari/537.36";
			//string edge = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 Edge/18.18362";
			reqH.Add("user-agent", chrome);
			//reqH.GetCookies().Add(new CookieHeaderValue("NID", "188=XFYB2Lnp4nax9yrsHueGO_c5X5mbBYLo5L95ZRPwDB-dvpyttWrVYyabPHPoHv_ItYhmdUOwlR1vE3lFvG7BgzEMxNgjjFX6Uv9gHmz6bvK-IdzbeNeq3oz8b60ZMSEahO97uW3ws2kIzvHQRgR9l_Dl9afmTtzRr3q2IIRWJlU"));
			//reqH.Add("Cache-Control", new string[] { "no-cache, no-store, must-revalidate" });
			//reqH.Add("Pragma","no-cache");
			//reqH.Add("x-client-data", "CIq2yQEIo7bJAQjBtskBCNG3yQEIqZ3KAQioo8oBCLGnygEI4qjKAQigqcoBCPGpygEIl63KAQjNrcoB");
			//reqH.Add("x-client-data", "aaaCIq2yQEIo7bJAQjBtskBCNG3yQEIqZ3KAQioo8oBCLGnygEI4qjKAQigqcoBCPGpygEIl63KAQjNrcoB");
		}


		public JArray GetLogData(string q)
		{
			JArray j_0 = new JArray(1, null, null, null, null, null, null, null, null, null, new JArray(null, null, null, null, "vi"));
			string j_2_0_0 = GetTime().ToString();
			JArray j_2_0_7 = new JArray("en", null, null, null, null, null, null, null, null, null, null, null, null, "", null, "ja", null, null, null, null, null, null, null, null, null, new JArray(), null, null, null, null, 1, 0, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "vi", null, "日本", 0, null, null, null, null, null, null, null, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, null, null, null, null, null, new JArray());
			j_2_0_7[51] = q;
			JArray j_2_0 = new JArray(j_2_0_0, null, new JArray(), null, null, null, null, JsonConvert.SerializeObject(j_2_0_7), null, null, null, null, null, null, null, new JArray(null, new JArray(), null, JsonConvert.SerializeObject(new JArray(new JArray(), new JArray(), new JArray(17259, 15700023, 15700186, 15700190, 15700256, 15700259, 15700262), new JArray()))), null, null, null, new JArray(), 18, null, null, null, null, null, new JArray());
			j_2_0[20] = q.Length;
			JArray j_2 = new JArray();
			j_2.Add(j_2_0);
			string j_3 = (GetTime() + 368).ToString();
			JArray j = new JArray(j_0, 375, j_2, j_3, new JArray(), null, null, null, null, null, null, null, null, 0);

			return j;
		}

		private Int64 GetTime()
		{
			Int64 retval = 0;
			DateTime st = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			TimeSpan t = (DateTime.Now.ToUniversalTime() - st);
			retval = (Int64)t.TotalMilliseconds;
			return retval;
		}

		public List<string> ReadJArrayRes(JArray jj)
		{
			const string startCellCode = "((";
			const string endCellCode = "))";
			if (jj == null)
			{
				return null;
			}
			List<string> li = new List<string>();
			bool bStartCell = false;
			bool bEndCell = false;
			JToken j_0 = jj[0];
			StringBuilder sb = new StringBuilder();
			int iLen = j_0.Count();
			for (int i = 0; i < iLen; i++)
			{
				JToken item = j_0[i];
				if (item != null)
				{
					if (item[0] != null)
					{
						string j_0_0 = item[0].ToString();
						if (!bStartCell && j_0_0.StartsWith(startCellCode))
						{
							bStartCell = true;
							j_0_0 = j_0_0.Substring(2, j_0_0.Length - 2);
						}
						if (!bStartCell)
						{
							if (j_0_0.EndsWith("\n"))
							{
								j_0_0 = j_0_0.Substring(0, j_0_0.Length - 1);
								if (j_0_0 == ecoEscapeBlank)
								{
									j_0_0 = "";
								}
								string[] rowpp = j_0_0.Split(new string[] { "\n" }, StringSplitOptions.None);
								rowpp[0] = rowpp[0] + sb.ToString();
								li.AddRange(rowpp);
								sb.Clear();
							}
							else
							{
								sb.Append(j_0_0);
							}

						}
						else
						{
							if (j_0_0.EndsWith("\n"))
							{
								j_0_0 = j_0_0.Substring(0, j_0_0.Length - 1);
							}

							if (bStartCell && j_0_0.EndsWith(endCellCode))
							{
								bEndCell = true;
								j_0_0 = j_0_0.Substring(0, j_0_0.Length - 2);
								if (j_0_0 == ecoEscapeBlank)
								{
									j_0_0 = "";
								}
							}
							else
							{
								if (j_0_0 == ecoEscapeBlank)
								{
									j_0_0 = "";
								}
								sb.AppendLine(j_0_0);
							}


							if (bEndCell)
							{
								string[] rowpp = j_0_0.Split(new string[] { "\n" }, StringSplitOptions.None);
								rowpp[0] = rowpp[0] + sb.ToString();
								li.AddRange(rowpp);
								sb.Clear();
								bStartCell = false;
								bEndCell = false;
							}
						}
					}

				}
			}

			return li;
		}
        public List<DataReturn> ReadJArrayRes2(JObject jj, bool Pronoun = true)
        {
            if (jj == null)
            {
                return null;
            }
			//PTANH2021/12/24 vandeso1: [2021/12/24yeucau] [update API: new API return JObject]
			TranslateResponse res = jj.ToObject<TranslateResponse>();
			List<DataReturn> li = new List<DataReturn>();
            for (int i = 0; i < res.sentences.Count - 1; i++)
            {
				li.Add(new DataReturn { textOrg = res.sentences[i].orig, textTran = res.sentences[i].trans });
			}
            //bool bEndCell = false;
            //JToken j_0 = jj[0];
            //StringBuilder sb = new StringBuilder();
            //int iLen = j_0.Count();
            //for (int i = 0; i < iLen; i++)
            //{
            //    JToken item = j_0[i];
            //    if (item != null)
            //    {
            //        if (item[0] != null)
            //        {
            //            //ptanh 05/28/2021 DEL START
            //            //string j_0_0 = item[0].ToString();
            //            //if (j_0_0.EndsWith("\n") || (i == iLen - 2))
            //            //{
            //            //    bEndCell = true;
            //            //}
            //            //else
            //            //{
            //            //    sb.Append(j_0_0);
            //            //}

            //            //if (bEndCell)
            //            //{
            //            //    string[] rowppT = j_0_0.Split(new string[] { "\n" }, StringSplitOptions.None);
            //            //    string[] rowpp = new string[rowppT.Length > 1 ? rowppT.Length - 1: rowppT.Length];
            //            //    rowpp[0] = (rowppT[0] == "..." ? null : rowppT[0]);
            //            //    if (sb.Length > 0)
            //            //    {
            //            //     rowpp[0] = sb.ToString() + rowpp[0];
            //            //        //when first line is blank, tip: insert 「。。。」, than after translated return value = [. . .]
            //            //        if (rowpp[0]== ". . .")
            //            //        {
            //            //            rowpp[0] = null;
            //            //        }
            //            //    }
            //            //    li.AddRange(rowpp);
            //            //    sb.Clear();
            //            //    bEndCell = false;
            //            //}
            //            //ptanh 05/28/2021 DEL END
            //            //ptanh 05/28/2021 AND START
            //            string j_0_1_ori = item[1].ToString();
            //            string j_0_0_tran = item[0].ToString();
            //            if (li.Count > 0)
            //            {
            //                DataReturn prevData = li[li.Count - 1];
            //                if (prevData.textTran.EndsWith("\n"))
            //                    li.Add(new DataReturn { textOrg = j_0_1_ori, textTran = j_0_0_tran });
            //                else
            //                {
            //                    prevData.textOrg += j_0_1_ori;
            //                    prevData.textTran += j_0_0_tran;
            //                }
            //            } else
            //                li.Add(new DataReturn { textOrg = j_0_1_ori,textTran= j_0_0_tran });
            //            //ptanh 05/28/2021 AND END
            //        }

            //    }
            //}
            if (Pronoun && _bOutputPronunciation && res.sentences.Count >= 2)
            {
                //JToken spell = j_0[iLen-1];
                //if (spell[3]!=null)
                if (!FncCheckEmpty(res.sentences[res.sentences.Count - 1].src_translit))
				{
                    //ptanh 05/28/2021 DEL START
                    //string[] rowpp = spell[3].ToString().Split(new string[] { "..."}, StringSplitOptions.RemoveEmptyEntries);
                    //int k = 0;
                    //for (int i = 0; i < li.Count; i++)
                    //{
                    //    if (li[i]==null)
                    //    {
                    //        continue;
                    //    }
                    //    if (k < rowpp.Length)
                    //    {
                    //        li[i] = li[i] + "\n" + rowpp[k];
                    //        k++;
                    //    }
                    //}
                    //ptanh 05/28/2021 DEL END
                    //string[] rowpp = spell[3].ToString().Split(new string[] { "!" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] rowpp = res.sentences[res.sentences.Count - 1].src_translit.Split(new string[] { "!" }, StringSplitOptions.RemoveEmptyEntries);
                    int k = 0;
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (k < rowpp.Length)
                        {
                            li[i].pronounce = rowpp[k];
                            k++;
                        }
                    }
				}
			}
            return li;
        }
		static bool FncCheckEmpty(string text)
		{
			if (string.IsNullOrEmpty(text))
				return true;
			if (text.Trim().Length == 0)
				return true;
			return false;
		}
	}
}
