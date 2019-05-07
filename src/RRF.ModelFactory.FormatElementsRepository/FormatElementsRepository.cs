using FakeEFContext;
using RRF.ModelFactory.FormateElementsRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.ModelFactory.FormatElementsRepository
{
    public class FormatElementsRepository : IFormateElementsRepository
    {
        private readonly IFakeContext context;

        public FormatElementsRepository(IFakeContext context)
        {
            this.context = context;
        }

        public IList<string> GetFormatElements()
        {
            return this.context.FormatElements;
        }

        public  Task<IList<string>> GetFormatElementsAsync()
        {
            throw new NotImplementedException("GetFormatElementsAsync is not implemented !!!");
        }
    }
}
