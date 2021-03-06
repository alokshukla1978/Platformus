﻿// Copyright © 2020 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Platformus.Core.Backend.ViewModels;
using Platformus.Website.Data.Entities;

namespace Platformus.Website.Backend.ViewModels.Endpoints
{
  public class CreateOrEditViewModelMapper : ViewModelMapperBase
  {
    public Endpoint Map(Endpoint endpoint, CreateOrEditViewModel createOrEdit)
    {
      endpoint.Name = createOrEdit.Name;
      endpoint.UrlTemplate = createOrEdit.UrlTemplate;
      endpoint.Position = createOrEdit.Position;
      endpoint.DisallowAnonymous = createOrEdit.DisallowAnonymous;
      endpoint.SignInUrl = createOrEdit.SignInUrl;
      endpoint.CSharpClassName = createOrEdit.CSharpClassName;
      endpoint.Parameters = createOrEdit.Parameters;
      return endpoint;
    }
  }
}