using System;

namespace RRF.JsonReader.Abstract
{
    public interface IJsonReader
    {
        string GetJsonAsString(string fileName);
    }
}