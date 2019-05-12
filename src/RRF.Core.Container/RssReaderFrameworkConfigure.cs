using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RFF.ModelFactory.XElementInterpretator.Abstract;
using RRF.Feed;
using RRF.Feed.Abstract;
using RRF.FeedModel.Abstract;
using RRF.FeedModelFactory.Abstract;
using RRF.FeedModelFactoryValidator.Abstract;
using RRF.FeedRepository.Abstract;
using RRF.ModelFactory.BaseModelFormat;
using RRF.ModelFactory.BaseModelFormat.Abstract;
using RRF.ModelFactory.BaseModelXElementInterpretator;
using RRF.ModelFactory.FormateElementsRepository.Abstract;
using RRF.ModelFactory.FormatElementsRepository;
using RRF.ModelFactory.ModelBindDateTime;
using RRF.ModelFactory.ModelBindDateTime.Abstract;
using RRF.ModelFactory.ModelBindImage;
using RRF.ModelFactory.ModelBindImage.Abstract;
using RRF.ModelFactory.ModelBindString;
using RRF.ModelFactory.ModelBindString.Abstract;
using RRF.Models.BaseModel.Abstract;
using RRF.FeedModelFactoryValidator;
using RRF.ModelFactory.StringValidator.Abstract;
using RRF.ModelFactory.StringValidator;
using RRF.BaseModelRepository;
using RRF.BaseModelRepository.Abstract;
using RRF.DateTimeWrapper.Abstract;
using RRF.WebClientWrapper.Abstract;
using RRF.XDocumentWrapper.Abstract;
using RRF.Identity.Models.BaseModel;
using RRF.IdentityUtility.UserManagerUtility.Abstract;
using RRF.IdentityUtility.UserManagerUtility;
using RRF.IdentityUtility.SignInManagerUtility.Abstract;
using RRF.IdentityUtility.SignInManagerUtility;
using RRF.Identity.AccountManager.Abstract;
using RRF.Identity.AccountManager;
using System;
using Microsoft.AspNetCore.Identity;
using RRF.BaseModelAccess;
using RRF.BaseModelAccess.Abstract;
using RRF.EFService.ItemModelService;
using RRF.EFService.ItemModelService.Abstract;
using RRF.EFService.RssChanelService.Abstract;
using RRF.EFService.RssChanelService;
using RRF.EFRepository.Abstract;
using RRF.EFModels;
using RRF.EFRepository;
using RRF.EFService.FormatElementsService.Abstract;
using RRF.EFService.FormatElementService;
using RRF.EFService.RssSettingsService.Abstrtact;
using RRF.EFService.RssSettingsService;
using RRF.EFModels.Abstract;

namespace RRF.Core.Container
{
    public class RssReaderFrameworkConfigure
    {
        public static void GoRssReaderFrameworkToWork(IServiceCollection service, string databaseName)
        {
            RegisterRssReaderFrameworkServices(service);
            RunRssReaderFrameworkDatabase(service, databaseName);
            RunRssReaderFrameworkIdentity(service);
        }

        private static void RunRssReaderFrameworkIdentity(IServiceCollection service)
        {
            service.AddIdentity<Client, IdentityRole>()
               .AddEntityFrameworkStores<RRFDbContext.RRFDbContext>()
               .AddDefaultTokenProviders();
        }

        private static void RunRssReaderFrameworkDatabase(IServiceCollection service, string databaseName)
        {
            service.AddDbContext<RRFDbContext.RRFDbContext>(option =>
               option.UseSqlServer(databaseName));
        }

        private static void RegisterRssReaderFrameworkServices(IServiceCollection service)
        {
            //FeedNode
            service.AddScoped<IFeed<IFeedNode>, FeedNodeFeed>();
            service.AddScoped<IFeedRepository<IFeedNode>, FeedNodeRepository.FeedNodeRepository>();

            //ModelFactory
            // FeedModelFactory
            service.AddScoped<IFeedModelFactory<IBaseModel>, FeedModelFactory.FeedModelFactory>();
            //Format
            //FormatElement Repository
            service.AddScoped<IFormateElementsRepository, ModelFactory.FormatElementsRepository.FormatElementsRepository>();
            //Models
            //BaseModel
            service.AddScoped<IBaseModelFormat<IBaseModel>, BaseModelFormat>();
            //Interpretators
            //XElement
            service.AddScoped<IXElementInterpretator<IBaseModel>, BaseModelXElementInterpretator>();
            //ModelBind
            service.AddScoped<IModelBindDateTime, ModelBindDateTime>();
            service.AddScoped<IModelBindImage, ModelBindImage>();
            service.AddScoped<IModelBindString, ModelBindString>();
            //Validator
            service.AddScoped<IFeedModelFactoryValidator<IBaseModel>, FeedModelFactoryValidator.FeedModelFactoryValidator>();
            service.AddScoped<IModelFactoryStringValidator, ModelFactoryStringValidator>();
            //Repository - Base
            service.AddScoped<IBaseModelRepository, BaseModelRepository.BaseModelRepository>();
            //Wrappers
            service.AddScoped<IDateTimePars, DateTimeWrapper.DateTimeWrapper>();
            service.AddScoped<IWebClientWrapper, WebClintWrapper.WebClientWrapper>(x => new WebClintWrapper.WebClientWrapper(new System.Net.WebClient()));
            service.AddScoped<IXDocumentWrapper, XDocumentWrapper.XDocumentWrapper>();
            //Identity
            service.AddScoped<IUserManagerUtility<Client>, UserManagerUtility>();
            service.AddScoped<ISignInManagerUtility<Client>, SignInManagerUtility>();
            service.AddScoped<IAccountManager<Client>, AccountManager>();
            //Acces Points
            service.AddScoped<IBaseModelAccess, BaseModelAccess.BaseModelAccess>();
            // EF SERVICESS
            service.AddScoped<IItemModelService, ItemModelService>();
            service.AddScoped<IRssChanelService, RssChanelService>();
            service.AddScoped<IFormatElementsService, FormatElementService>();
            service.AddScoped<IRssSettingsService, RssSettingsService>();
            //EF REPOSITORIES
            service.AddScoped<IEFRepository<RssChannel>, RssChanelRepository>();
            service.AddScoped<IEFRepository<RssSetting>, RssSettingsRepository>();
            service.AddScoped<IEFRepository<ModelElement>, ModelElementRepository>();
            service.AddScoped<IEFRepository<XElementModel>, EFRepository.FormatElementsRepository>();
        }
    }
}