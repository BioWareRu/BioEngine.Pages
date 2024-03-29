﻿using System;
using System.Threading.Tasks;
using BioEngine.Core.API;
using BioEngine.Core.DB;
using BioEngine.Core.Entities;
using BioEngine.Core.Repository;
using BioEngine.Core.Web;
using BioEngine.Pages.Db;
using BioEngine.Pages.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BioEngine.Pages.Api
{
    public abstract class
        ApiPagesController : ContentEntityController<Page, PagesRepository, Entities.Page, Entities.Page>
    {
        protected ApiPagesController(BaseControllerContext<Page, PagesRepository> context,
            BioEntitiesManager entitiesManager, ContentBlocksRepository blocksRepository) : base(context,
            entitiesManager, blocksRepository)
        {
        }

        public override async Task<ActionResult<StorageItem>> UploadAsync(string name)
        {
            var file = await GetBodyAsFileAsync();
            return await Storage.SaveFileAsync(file, name,
                $"pages/{DateTimeOffset.UtcNow.Year.ToString()}/{DateTimeOffset.UtcNow.Month.ToString()}");
        }
    }
}
