using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebServicesHomework.Model
{
    public static class JsonExtensions
    {
        public static string ToJson(object obj) => JsonConvert.SerializeObject(obj, Converter.Settings);

        public static T FromJson<T>(string json) => JsonConvert.DeserializeObject<T>(json,Converter.Settings);

        public static List<T> FromJsonList<T>(string json) => JsonConvert.DeserializeObject<List<T>>(json, Converter.Settings);

    }
}
