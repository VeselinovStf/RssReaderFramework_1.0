using RRF.JsonReader.Abstract;
using System;
using System.IO;

namespace RRF.JsonReader
{
    public class JsonReader : IJsonReader
    {
        public string GetJsonAsString(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("JsonReader Configuration file name is empty or null!");
            }

            try
            {
                using (StreamReader r = new StreamReader(fileName))
                {
                    var jsonAsString = r.ReadToEnd();

                    return jsonAsString;
                }
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException("Can't find RssReader Config File!");
            }
        }
    }
}