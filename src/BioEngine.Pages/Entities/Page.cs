﻿using System.ComponentModel.DataAnnotations.Schema;
using BioEngine.Core.Abstractions;
using BioEngine.Core.DB;
using BioEngine.Core.Entities;
using BioEngine.Pages.Routing;

namespace BioEngine.Pages.Entities
{
    [TypedEntity("page")]
    public class Page : ContentItem<PageData>
    {
        public override string TypeTitle { get; } = "Страница";
        [NotMapped] public override string PublicRouteName { get; set; } = BioEnginePagesRoutes.Page;
    }

    public class PageData : ITypedData
    {
    }
}
