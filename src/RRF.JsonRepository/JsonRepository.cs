using RRF.JsonData.Abstract;
using RRF.JsonRepository.Abstract;
using System;

namespace RRF.JsonRepository
{
    public class JsonRepository<T> : IJsonRepository<T>
    {
        private readonly IJsonData<T> dataAccess;

        /// <summary>
        /// For specific entity
        /// </summary>

        public JsonRepository(IJsonData<T> dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        // TODO: SCHANGE HERE
        public T Get()
        {
            return this.dataAccess.GetContent();
        }
    }
}