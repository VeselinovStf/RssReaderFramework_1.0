using Microsoft.EntityFrameworkCore;
using System;

namespace RRF.EFModelsConfig.Abstract
{
    public interface IEFModelConfig<T> : IEntityTypeConfiguration<T> where T : class 
    {
    }
}
