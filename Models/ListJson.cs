using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nexodo.Models
{
    public class ListJson
    {
        public List<Json> lstJson { get; set; }
        public ListJson()
        {
            lstJson = new List<Json>();
        }


        /// <summary>
        /// Devuelve objeto JSON 
        /// </summary>
        /// <returns></returns>
        public string toJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Deserializa el json a objeto complejo.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public ListJson jsonToObject(String json)
        {
            ListJson l = new ListJson();
            try
            {
                l.lstJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Json>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return l;
        }

    }
}