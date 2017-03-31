﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class XmlSFAttribute : IXmlSFAttribute
    {
        public void TestXmlSerializerSupportsFaults(string faultMsg)
        {
            throw new FaultException<FaultDetailWithXmlSerializerFormatAttribute_SupportFaults>(new FaultDetailWithXmlSerializerFormatAttribute_SupportFaults(faultMsg));
        }
    }
}
