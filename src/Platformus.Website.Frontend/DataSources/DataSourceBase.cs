﻿// Copyright © 2020 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Platformus.Core;
using Platformus.Core.Parameters;
using Platformus.Website.Data.Entities;
using Platformus.Website.DataSources;

namespace Platformus.Website.Frontend.DataSources
{
  public abstract class DataSourceBase : IDataSource
  {
    public abstract IEnumerable<ParameterGroup> ParameterGroups { get; }
    public abstract string Description { get; }

    public abstract Task<dynamic> GetDataAsync(HttpContext httpContext, DataSource dataSource);

    protected dynamic CreateViewModel(HttpContext httpContext, Object @object)
    {
      ExpandoObjectBuilder expandoObjectBuilder = new ExpandoObjectBuilder();

      expandoObjectBuilder.AddProperty("Id", @object.Id);
      expandoObjectBuilder.AddProperty("ClassId", @object.ClassId);

      foreach (Property property in @object.Properties)
        expandoObjectBuilder.AddProperty(property.Member.Code, property.GetValue(httpContext));

      return expandoObjectBuilder.Build();
    }
  }
}