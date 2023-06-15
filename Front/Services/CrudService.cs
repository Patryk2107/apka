﻿using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Front.Models;
using Newtonsoft.Json;

namespace SavingFileRazorFrontend.Services
{
    public class CrudService
    {
        private HttpClient _httpClient;

        public CrudService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<HttpResponseMessage> Logging(string url, string content)
        {
            var response = await _httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));
            return response;
        }

        public async Task<List<TW>> GetAllNoToken<TW>(string url)
        {
            string content = await _httpClient.GetStringAsync(url);
            List<TW> values = JsonConvert.DeserializeObject<List<TW>>(content);

            return values;
        }

        public async Task<List<TW>> GetAllWithToken<TW>(string url, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            string content = await _httpClient.GetStringAsync(url);
            List<TW> values = JsonConvert.DeserializeObject<List<TW>>(content);

            return values;
        }

        public async Task<TW> GetById<TW>(string url, int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            string content = await _httpClient.GetStringAsync(url+"/"+id);
            var values = JsonConvert.DeserializeObject<TW>(content);

            return values;
        }       
        
        public async Task<HttpResponseMessage> Edit<TW>(string url, int id, string token, TW model)
        {
            string content = JsonConvert.SerializeObject(model);
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsync(url + "/" + id, new StringContent(content, Encoding.UTF8, "application/json"));
            return response;
        }

        public async Task Delete(string url, string token, int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync(url + "/" + id);
        }

        public async Task<HttpResponseMessage> Create<TW>(string token, string url, TW model )
        {
            string content = JsonConvert.SerializeObject(model);
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));

            return response;
        }

        public async Task<HttpResponseMessage> CreateNoLogin<TW>(string url, TW model)
        {
            string content = JsonConvert.SerializeObject(model);
            var response = await _httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));

            return response;
        }

        public async Task<T> SearchNoAuth<TW, T>(string url, TW model)
        {
            string content = JsonConvert.SerializeObject(model);
            var response = await _httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));
            var result = await response.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<T>(result);

            return value;
        }

        public async Task<FileModel> GetFile(string url, FileSearchModel model)
        {
            string content = JsonConvert.SerializeObject(model);
            var response = await _httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));
            var result = await response.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<FileModel>(result);
            return value;
        }

        //public byte[] GetImage(string sBase64String)
        //{
        //    byte[] bytes = null;
        //    if (!string.IsNullOrEmpty(sBase64String))
        //    {
        //        bytes = Convert.FromBase64String(sBase64String);
        //    }

        //    return bytes;
        //}
    }
}
