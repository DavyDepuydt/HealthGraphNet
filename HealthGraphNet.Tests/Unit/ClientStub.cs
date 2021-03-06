﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using RestSharp.Portable;
using HealthGraphNet;
using System.Threading.Tasks;

namespace HealthGraphNet.Tests.Unit
{
    /// <summary>
    /// Stubbing out the actual restsharp request execution. Overriding internals in a different assembly thanks to the InternalsVisibleTo attribute.
    /// </summary>
    public class ClientStub : Client
    {
        public ClientStub() : base(null)
        {
        }

        #region IRequest Execution

        internal override async Task<T> Execute<T>(IRestRequest request, string baseUrl = null, HttpStatusCode? expectedStatusCode = null)
        {
            return new T();
        }

        internal override async Task Execute(IRestRequest request, string baseUrl = null, HttpStatusCode? expectedStatusCode = null)
        {
        }

        internal override async Task<string> ExecuteCreate(IRestRequest request, string baseUrl = null)
        {
            return string.Empty;
        }

        #endregion          
    }
}