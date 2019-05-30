using Newtonsoft.Json;
using Nexodo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Nexodo.BusinessLogic
{
    public class Negocio
    {

        public Negocio()
        {

        }

        /// <summary>
        /// Deserialza el fichero json a un objeto complejo.
        /// </summary>
        /// <returns>Lista con los datos del fichero json</returns>
        public List<Json> generaLista()
        {           
            ListJson objList = new ListJson();
            try
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"products.json");
                using (StreamReader jsonStream = File.OpenText(path))
                {
                    var json = jsonStream.ReadToEnd();                   
                    objList = objList.jsonToObject(json);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objList.lstJson;
        }
    }
}