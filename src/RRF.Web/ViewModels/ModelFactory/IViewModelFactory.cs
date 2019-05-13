using RRF.Web.ViewModels.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.Web.ViewModels.ModelFactory
{
    public interface IViewModelFactory
    {
        RegisterViewModel Create(object serviceModel);
    }
}