using RFF.JsonFunction.Abstract;
using RRF.JsonConfigModel.Abstract;
using RRF.JsonDeserialize.Abstract;
using RRF.JsonReader.Abstract;
using RRF.JsonToEntity.Abstract;
using System;

namespace RFF.JsonFunction
{
    public class JsonFunction<T> : IJsonGetFunction<T>
    {
        private readonly IFileModel fileName;
        private readonly IJsonDeserialize<T> jsonDeserialize;
        private readonly IJsonReader jsonReader;

        public JsonFunction(
            IFileModel fileName,
            IJsonDeserialize<T> jsonDeserialize,
            IJsonReader jsonReader)
        {
            this.fileName = fileName;
            this.jsonDeserialize = jsonDeserialize;
            this.jsonReader = jsonReader;
        }

        public T Get()
        {
            var item = this.jsonDeserialize.Deserialize(
                        this.jsonReader.GetJsonAsString(
                            this.fileName.FileName)
                            );

            return item;
        }
    }
}