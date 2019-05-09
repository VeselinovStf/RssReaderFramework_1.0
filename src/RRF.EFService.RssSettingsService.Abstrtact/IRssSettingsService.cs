
using RRF.EFModels;
using System;
using System.Threading.Tasks;

namespace RRF.EFService.RssSettingsService.Abstrtact
{
    public interface IRssSettingsService
    {
        Task<DescendingElement> GetXElementDescendant(string userId);
    }
}
