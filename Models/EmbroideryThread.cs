
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace craftSupplies.Models

{
    public class EmbroideryThread
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Hex { get; set; }

        public static List<EmbroideryThread> GetThreads()
        {
        var apiCallTask = ApiHelper.GetAll();
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<EmbroideryThread> threadList = JsonConvert.DeserializeObject<List<EmbroideryThread>>(jsonResponse.ToString());

        return threadList;
        }
    }
}