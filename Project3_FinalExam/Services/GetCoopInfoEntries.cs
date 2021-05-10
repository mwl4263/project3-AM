﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3_FinalExam.Services
{
    public class GetCoopInfoEntries : IGetCoop
    {
        public async Task<List<coopInfoEntries>> GetCoopEntries()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/employment/coopTable/coopInformation", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<coopInfoEntries>>>(data);

                    List<coopInfoEntries> coopList = new List<coopInfoEntries>();
                    coopInfoEntries coop = new coopInfoEntries();
                    Console.Write(rtnResults);
                    foreach (KeyValuePair<string, List<coopInfoEntries>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            coopList.Add(item);
                        }
                    }

                    return coopList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<coopInfoEntries> coopList = new List<coopInfoEntries>();
                    return coopList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<coopInfoEntries> coopList = new List<coopInfoEntries>();
                    return coopList;
                    //return "Exception"; ;
                }
            }
        }
    }
}
