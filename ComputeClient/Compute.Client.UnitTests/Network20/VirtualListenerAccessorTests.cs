﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Client;
using DD.CBU.Compute.Api.Client.Network20;
using DD.CBU.Compute.Api.Contracts.Network20;
using DD.CBU.Compute.Api.Contracts.Vip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Compute.Client.UnitTests.Network20
{
    [TestClass]
    public class VirtualListenerAccessorTests : BaseApiClientTestFixture
    {
        [TestMethod]
        public async Task CreateVirtualListener_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.CreateVirtualListener(accountId), RequestFileResponseType.AsGoodResponse("CreateVirtualListenerResponse.xml"));

            var webApi = GetWebApiClient();
            var createVirtualListener = new createVirtualListener
            {
                networkDomainId = Guid.NewGuid().ToString(),
                name = "NetworkNodeTest",
                description = "Descrioption",
                connectionLimit = 100,
                connectionRateLimit = 100
            };

            var virtualListener = new VipVirtualListenerAccessor(webApi);
            ResponseType domainResponse = await virtualListener.CreateVirtualListener(createVirtualListener);

            Assert.IsNotNull(domainResponse);
            Assert.AreEqual("OK", domainResponse.responseCode);
            Assert.AreEqual("CREATE_VIRTUAL_LISTENER", domainResponse.operation);
            Assert.IsNotNull(domainResponse.info.Any(q => q.name == "virtualListenerId"));
            Assert.IsNotNull(domainResponse.info.Any(q => q.name == "name"));
            Assert.IsNotNull(domainResponse.info.Any(q => q.name == "listenerIpAddress"));
        }

        [TestMethod]
        public async Task ListVirtualListeners_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.GetVirtualListeners(accountId), RequestFileResponseType.AsGoodResponse("ListVirtualListeners.xml"));
            var webApi = GetWebApiClient();
            var virtualListener = new VipVirtualListenerAccessor(webApi);

            var result = await virtualListener.GetVirtualListeners();

            Assert.AreEqual(1, result.Count());
            Assert.IsNotNull(result.First().networkDomainId);
        }

        [TestMethod]
        public async Task ListVirtualListenersPaginated_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.GetVirtualListeners(accountId), RequestFileResponseType.AsGoodResponse("ListVirtualListeners.xml"));
            var webApi = GetWebApiClient();
            var virtualListener = new VipVirtualListenerAccessor(webApi);

            var result = await virtualListener.GetVirtualListenersPaginated();

            Assert.AreEqual(1, result.pageNumber);
            Assert.AreEqual(1, result.items.Count());
        }

        [TestMethod]
        public async Task GetVirtualListeners_ReturnsResponse()
        {
            var virtualListenerId = Guid.NewGuid();
            requestsAndResponses.Add(ApiUris.GetVirtualListener(accountId, virtualListenerId), RequestFileResponseType.AsGoodResponse("GetVirtualListener.xml"));
            var webApi = GetWebApiClient();
            var virtualListener = new VipVirtualListenerAccessor(webApi);

            var result = await virtualListener.GetVirtualListener(virtualListenerId);

            Assert.IsNotNull(result.networkDomainId);
            Assert.IsNotNull(result.state);
        }

        [TestMethod]
        public async Task EditVirtualListenerReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.EditVirtualListener(accountId), RequestFileResponseType.AsGoodResponse("EditVirtualListener.xml"));
            var webApi = GetWebApiClient();
            var virtualListener = new VipVirtualListenerAccessor(webApi);

            var editVirtualListener = new editVirtualListener();

            var result = await virtualListener.EditVirtualListener(editVirtualListener);

            Assert.AreEqual("EDIT_VIRTUAL_LISTENER", result.operation);
            Assert.AreEqual("OK", result.responseCode);
        }

        [TestMethod]
        public async Task DeleteVirtualListener_ReturnsResponse()
        {
            var virtualListenerId = Guid.NewGuid();
            requestsAndResponses.Add(ApiUris.DeleteVirtualListener(accountId), RequestFileResponseType.AsGoodResponse("DeleteVirtualListener.xml"));
            var webApi = GetWebApiClient();
            var virtualListener = new VipVirtualListenerAccessor(webApi);

            var result = await virtualListener.DeleteVirtualListener(virtualListenerId);

            Assert.AreEqual("DELETE_VIRTUAL_LISTENER", result.operation);
            Assert.AreEqual("OK", result.responseCode);
        }
    }
}
