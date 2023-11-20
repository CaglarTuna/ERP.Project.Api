using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ApiHandlers
{
    public class ApiHandler
    {
        public T GetAPI<T>(string url,string token)
        {
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.ContentType = "application/json";
            httpRequest.Method = "GET";
            httpRequest.Headers.Add("Authorization", "Bearer " + token);
            var response = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var model = JsonConvert.DeserializeObject<T>(result);
                response.Close();
                return model;
            }
        }
        public T PostAPIWithModel<T>(dynamic dynamicModel, string url,string Token)
        {
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.ContentType = "application/json";
            httpRequest.Method = "POST";
            string JsonData = JsonConvert.SerializeObject(dynamicModel);
            byte[] byteArray = Encoding.UTF8.GetBytes(JsonData);
            httpRequest.ContentLength = byteArray.Length;
            httpRequest.Headers.Add("Authorization", "Bearer " + Token);
            Stream dataStream = httpRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            var response = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                T model = JsonConvert.DeserializeObject<T>(result);
                response.Close();
                return model;
            }
        }
        public T PostAPITokenWithModel<T>(dynamic dynamicModel, string url)
        {
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.ContentType = "application/json";
            httpRequest.Method = "POST";
            string JsonData = JsonConvert.SerializeObject(dynamicModel);
            byte[] byteArray = Encoding.UTF8.GetBytes(JsonData);
            httpRequest.ContentLength = byteArray.Length;
            Stream dataStream = httpRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            var response = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                T model = JsonConvert.DeserializeObject<T>(result);
                response.Close();
                return model;
            }
        }
    }
}
