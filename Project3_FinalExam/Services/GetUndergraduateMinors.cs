using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3_FinalExam.Services
{
    public class GetUndergraduateMinors : IGetUndergraduateMinors
    {
        public async Task<List<UnderGradMinors>> GetUnderGradMinors()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/minors/UgMinors", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<UnderGradMinors>>>(data);
                    List<UnderGradMinors> underGradList = new List<UnderGradMinors>();
                    UnderGradMinors underGradMinors = new UnderGradMinors();

                    foreach (KeyValuePair<string, List<UnderGradMinors>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            underGradList.Add(item);
                        }
                    }

                    return underGradList;



                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<UnderGradMinors> underGradMinorsList = new List<UnderGradMinors>();
                    return underGradMinorsList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<UnderGradMinors> underGradMinorsList = new List<UnderGradMinors>();
                    return underGradMinorsList;
                }
            }
        }
    }
}
