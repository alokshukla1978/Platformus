﻿// Copyright © 2020 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Platformus.Core.Backend.ViewModels;
using Platformus.Website.Data.Entities;

namespace Platformus.Website.Backend.ViewModels.Shared
{
  public class DataTypeParameterViewModelFactory : ViewModelFactoryBase
  {
    public DataTypeParameterViewModel Create(DataTypeParameter dataTypeParameter)
    {
      return new DataTypeParameterViewModel()
      {
        Id = dataTypeParameter.Id,
        Name = dataTypeParameter.Name
      };
    }
  }
}