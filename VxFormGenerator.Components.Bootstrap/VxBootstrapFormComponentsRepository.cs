﻿using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using VxFormGenerator.Form.Components.Bootstrap;
using VxFormGenerator.Models;
using VxFormGenerator.Core.Repository;
using VxFormGenerator.Core;
using VxFormGenerator.Form.Components.Plain;
using VxFormGenerator.Core.Render;
using System.Reflection;

namespace VxFormGenerator.Repository.Bootstrap
{
    public class VxBootstrapRepository : FormGeneratorComponentModelBasedRepository
    {
        public VxBootstrapRepository()
        {

            var assemblies = Assembly.GetAssembly(typeof(VxBootstrapRepository));
            this.RegisterAllDiscoverableFormElements(new[] { assemblies });

            _ComponentDict = new Dictionary<Type, IList<VxDataTypeComponentRegistration>>()
                  {
                    { typeof(string),          typeof(InputText) },
                    { typeof(DateTime),        typeof(InputDate<>) },
                    { typeof(bool),            typeof(BootstrapInputCheckbox) },
                    { typeof(Enum),            typeof(BootstrapInputSelectWithOptions<>) },
                    { typeof(IDictionary<bool, Enum>), typeof(BootstrapInputCheckboxMultiple<>) },
                    { typeof(VxLookupKeyValue),typeof(BootstrapInputSelectWithOptions<>) },
                    { typeof(decimal),         typeof(InputNumber<>) },
                    { typeof(int),             typeof(InputNumber<>) },
                    { typeof(VxColor),         typeof(InputColor) }
                  };

            _DefaultComponent = null;

        }

    }
}
