using RRF.EFModels;
using RRF.Identity.Models.BaseModel;
using System;

namespace RRF.EFSeed
{
    public class EFSeed
    {

        public static Client[] SeedDefaultClient()
        {
            return new Client[]
            {
                new Client()
                {
                    Id = "baa0d4c2-1589-4378-be1c-238612953ae1",
                    UserName = "Client",
                    NormalizedUserName = "client@mail.com".ToUpper(),
                    Email = "client@mail.com",
                    TwoFactorEnabled = false,
                    NormalizedEmail = "client@mail.com".ToUpper(),
                    EmailConfirmed = true,
                    PhoneNumber = "+359359",
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    AccessFailedCount = 0,
                    LockoutEnabled = false,
                }
            };
        }

        public static RssChannel[] SeedRssChannels()
        {
            return new RssChannel[]
            {
                new RssChannel()
                {
                     Id = 1,
                     CreatedOn = DateTime.Now,
                     Name = "testRssChannel",
                     URL = "https://www.vesti.bg/rss.php",
                     IsDeleted = false,
                      ClientId = "baa0d4c2-1589-4378-be1c-238612953ae1"
                }
            };
        }

        public static RssSetting[] SeedRssSettings()
        {
            return new RssSetting[]
            {
                new RssSetting()
                {
                     CreatedOn = DateTime.Now,
                     IsDeleted = false,
                     Id = 1,
                     RssChanel_Id = 1,
                      ClientId = "baa0d4c2-1589-4378-be1c-238612953ae1",

                }
            };
        }

        public static XElementModel[] SeedXElementsModels()
        {
            return new XElementModel[]
            {
                new XElementModel()
                {
                     Id = 1,
                     Name = "<p>",
                     RssSettingFormatElements_Id = 1
                },
                new XElementModel()
                {
                    Id = 2,
                    Name = "</p>",
                    RssSettingFormatElements_Id = 1
                }
            };
        }

        public static DescendingElement[] SeedDescendantElements()
        {
            return new DescendingElement[]
            {
                new DescendingElement()
                {
                     CreatedOn = DateTime.Now,
                      Id = 1,
                       IsDeleted = false,
                        ModifiedOn = DateTime.Now,
                         Name = "item",
                          RssSettingDescendantElement_Id = 1
                }
            };
        }

        public static ModelElement[] SeedModelElements()
        {
            return new ModelElement[]
            {
                new ModelElement()
                {
                     Id = 1,
                     CreatedOn = DateTime.Now,
                     Description = "description",
                     LinkToCurrentElement = "link",
                     ModifiedOn = DateTime.Now,
                     PubDate = "pubDate",
                     RssSettingDisplayModelElementId = 1,
                     Title = "title",
                     ImageSRC = "image",
                     IsDeleted = false
                }
            };
        }

        
    }
}