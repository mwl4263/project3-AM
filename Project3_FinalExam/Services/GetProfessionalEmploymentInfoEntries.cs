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
    public class GetProfessionalEmploymentInfoEntries
    {
        public async Task<List<ProfessionalEmploymentInfoEntries>> GetEmploymentInfoEntries()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/employment/employmentTable", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<ProfessionalEmploymentInfoEntries>>>(data);

                    List<ProfessionalEmploymentInfoEntries> employmentList = new List<ProfessionalEmploymentInfoEntries>();
                    ProfessionalEmploymentInfoEntries employment = new ProfessionalEmploymentInfoEntries();
                    Console.Write(rtnResults);
                    foreach (KeyValuePair<string, List<ProfessionalEmploymentInfoEntries>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            employmentList.Add(item);
                        }
                    }

                    return employmentList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<ProfessionalEmploymentInfoEntries> employmentList = new List<ProfessionalEmploymentInfoEntries>();
                    return employmentList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<ProfessionalEmploymentInfoEntries> employmentList = new List<ProfessionalEmploymentInfoEntries>();
                    return employmentList;
                    //return "Exception"; ;
                }
            }
        }
    }
}
