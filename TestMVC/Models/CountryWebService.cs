using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public class CountryWebService
    {

        public string ObtenerCountry() {


            string url = "http://services.groupkt.com/state/get/IND/all";

            HttpClient client = new HttpClient();

            var json = client.GetStringAsync(url);

            //string des = JsonConvert.DeserializeObject<string>(json.Result);

            return json.Result.ToString();
        }
    }
}
