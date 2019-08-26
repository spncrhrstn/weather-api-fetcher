﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;
using Newtonsoft.Json.Serialization;

namespace RestAPITest
{
    public class ConsolidatedWeather
    {
        public object ID { get; set; }
        public string Weather_State_Name { get; set; }
        public string Weather_State_Abbr { get; set; }
        public string Wind_Direction_Compass { get; set; }
        public DateTime Created { get; set; }
        public DateTime Applicable_Date { get; set; }
        public double Min_Temp { get; set; }
        public double Max_Temp { get; set; }
        public double The_Temp { get; set; }
        public double Wind_Speed { get; set; }
        public double Wind_Direction { get; set; }
        public double Air_Pressure { get; set; }
        public int Humidity { get; set; }
        public double? Visibility { get; set; }
        public int Predictability { get; set; }
    }


    public class Parent
    {
        public string Title { get; set; }
        public string Location_Type { get; set; }
        public int Woeid { get; set; }
        public string Latt_Long { get; set; }
    }

    public class Source
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string URL { get; set; }
        public int Crawl_Rate { get; set; }
    }

    public class Location
    {
        public List<ConsolidatedWeather> Consolidated_Weather { get; set; }
        public DateTime Time { get; set; }
        public DateTime Sun_Rise { get; set; }
        public DateTime Sun_Set { get; set; }
        public string Timezone_Name { get; set; }
        public Parent Parent { get; set; }
        public List<Source> Sources { get; set; }
        public string Title { get; set; }
        public string Location_Type { get; set; }
        public int Woeid { get; set; }
        public string Latt_Long { get; set; }
        public string Timezone { get; set; }
    }
}

//    public class Location
//    {
//        [DeserializeAs(Name = "title")]
//        public string Title { get; set; }

//        [DeserializeAs(Name = "location_type")]
//        public string LocationType { get; set; }

//        [DeserializeAs(Name = "latt_long")]
//        public string LattLong { get; set; }

//        [DeserializeAs(Name = "time")]
//        public DateTime Time { get; set; }

//        [DeserializeAs(Name = "sun_rise")]
//        public DateTime Sunrise { get; set; }

//        [DeserializeAs(Name = "sun_set")]
//        public DateTime Sunset { get; set; }

//        [DeserializeAs(Name = "timezone_name")]
//        public string TimezoneName { get; set; }

//        [DeserializeAs(Name = "woeid ")]
//        public int Woeid { get; set; }

//        [DeserializeAs(Name = "consolidated_weather")]
//        public List<ConsolidatedWeather> ConsolidatedWeather { get; set; }

//        [DeserializeAs(Name = "parent")]
//        public Parent Parent { get; set; }

//        [DeserializeAs(Name = "sources")]
//        public List<Source> Sources { get; set; }   
//    }

//    public class Parent
//    {
//        [DeserializeAs(Name = "title")]
//        public string Title { get; set; }

//        [DeserializeAs(Name = "location_type")]
//        public string LocationType { get; set; }

//        [DeserializeAs(Name = "latt_long")]
//        public string LattLong { get; set; }

//        [DeserializeAs(Name = "woeid")]
//        public int Woeid { get; set; }
//    }

//    public class Source
//    {
//        [DeserializeAs(Name = "title")]
//        public string Title { get; set; }

//        [DeserializeAs(Name = "url")]
//        public string URL { get; set; }

//        [DeserializeAs(Name = "slug")]
//        public string Slug { get; set; }

//        [DeserializeAs(Name = "crawl_rate")]
//        public int CrawlRate { get; set; }
//    }

//    public class ConsolidatedWeather
//    {
//        [DeserializeAs(Name = "id")]
//        public int ID { get; set; }

//        [DeserializeAs(Name = "applicable_date")]
//        public DateTime ApplicableDate { get; set; }

//        [DeserializeAs(Name = "weather_state_name")]
//        public string WeatherStateName { get; set; }

//        [DeserializeAs(Name = "weather_state_abbr")]
//        public string WeatherStateAbbreviation { get; set; }

//        [DeserializeAs(Name = "wind_speed")]
//        public float WindSpeed { get; set; }

//        [DeserializeAs(Name = "wind_direction")]
//        public float WindDirection { get; set; }

//        [DeserializeAs(Name = "wind_direction_compass")]
//        public string WindDirectionCompass { get; set; }

//        [DeserializeAs(Name = "min_temp")]
//        public int MinTemp { get; set; }

//        [DeserializeAs(Name = "max_temp")]
//        public int MaxTemp { get; set; }

//        [DeserializeAs(Name = "the_temp")]
//        public int Temp { get; set; }

//        [DeserializeAs(Name = "air_pressure")]
//        public float AirPressure { get; set; }

//        [DeserializeAs(Name = "humidity")]
//        public float Humidity { get; set; }

//        [DeserializeAs(Name = "visibility")]
//        public float Visibility { get; set; }

//        [DeserializeAs(Name = "predictability")]
//        public int Predictability { get; set; }
//    }
//}
