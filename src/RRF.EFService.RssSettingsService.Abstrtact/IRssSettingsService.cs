
using RRF.EFModels;
using System;
using System.Threading.Tasks;

namespace RRF.EFService.RssSettingsService.Abstrtact
{
    public interface IRssSettingsService
    {
        Task<XElementModel> GetXElementDescendant(string userId);
    }
}
