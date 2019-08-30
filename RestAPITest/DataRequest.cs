﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;

namespace WeatherAPIFetcher
{
    static class ZipcodeDataRequest
    {
        private const string BaseUrl = "https://api.zippopotam.us/";

        public static IRestClient Client { get; set; } = new RestClient(BaseUrl)
            .UseSerializer(() => new Program.JsonNetSerializer());

        public static IRestResponse<ZipcodeData.ZipcodeData> GetZipcodeData(string zipcode)
        {
            //create the request
            var request = new RestRequest("us/" + zipcode, DataFormat.Json);

            //deserialize the request data
            var response = Client.Get<ZipcodeData.ZipcodeData>(request);

            return response;
        }
    }

    static class IPDataRequest
    {
        private const string BaseUrl = "https://ipvigilante.com/json/";

        public static IRestClient Client { get; set; } = new RestClient(BaseUrl)
            .UseSerializer(() => new Program.JsonNetSerializer());

        public static IRestResponse<IPData.IPData> GetIPData(string ipAddress)
        {
            //create the request
            var request = new RestRequest(ipAddress + "/full", DataFormat.Json);

            //deserialize
            var response = Client.Get<IPData.IPData>(request);

            return response;
        }
    }

    static class DSWeatherDataRequest
    {
        private const string BaseUrl = "https://api.darksky.net/";

        public static IRestClient Client { get; set; } = new RestClient(BaseUrl)
            .UseSerializer(() => new Program.JsonNetSerializer());

        public static IRestResponse<DarkSkyData> GetWeatherData(string lat, string longi)
        {
            //create the request
            var request = new RestRequest("forecast/{key}/{lat},{long}/", DataFormat.Json);
            request.AddUrlSegment("key", ConfigurationManager.AppSettings.Get("DarkSkyAPIKey"));
            request.AddUrlSegment("lat", lat);
            request.AddUrlSegment("long", longi);

            //deserialize
            var response = Client.Get<DarkSkyData>(request);

            return response;
        }

    }
}
