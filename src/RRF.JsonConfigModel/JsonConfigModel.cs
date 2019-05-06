using RRF.JsonConfigModel.Abstract;
using System;

namespace RRF.JsonConfigModel
{
    public class JsonConfigModel : IFileModel
    {
        public string FileName { get; set; }
    }
}