﻿using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SiteServer.CMS.Controllers.Http;
using SiteServer.CMS.Core;
using SiteServer.CMS.Plugin;
using SiteServer.CMS.Plugin.Model;

namespace SiteServer.API.Controllers.Http
{
    [RoutePrefix("api")]
    public class PluginHttpController : ApiController
    {
        [HttpGet, Route(PluginHttpApi.Route)]
        public HttpResponseMessage Get(string pluginId)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpGet == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpGet.Invoke(context);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet, Route(PluginHttpApi.RouteName)]
        public HttpResponseMessage Get(string pluginId, string name)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpGetWithName == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpGetWithName.Invoke(context, name);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet, Route(PluginHttpApi.RouteNameAndId)]
        public HttpResponseMessage Get(string pluginId, string name, string id)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpGetWithNameAndId == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpGetWithNameAndId.Invoke(context, name, id);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost, Route(PluginHttpApi.Route)]
        public HttpResponseMessage Post(string pluginId)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpPost == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpPost.Invoke(context);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost, Route(PluginHttpApi.RouteName)]
        public HttpResponseMessage Post(string pluginId, string name)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpPostWithName == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpPostWithName.Invoke(context, name);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost, Route(PluginHttpApi.RouteNameAndId)]
        public HttpResponseMessage Post(string pluginId, string name, string id)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpPostWithNameAndId == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpPostWithNameAndId.Invoke(context, name, id);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPut, Route(PluginHttpApi.Route)]
        public HttpResponseMessage Put(string pluginId)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpPut == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpPut.Invoke(context);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPut, Route(PluginHttpApi.RouteName)]
        public HttpResponseMessage Put(string pluginId, string name)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpPutWithName == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpPutWithName.Invoke(context, name);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPut, Route(PluginHttpApi.RouteNameAndId)]
        public HttpResponseMessage Put(string pluginId, string name, string id)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpPutWithNameAndId == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpPutWithNameAndId.Invoke(context, name, id);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete, Route(PluginHttpApi.Route)]
        public HttpResponseMessage Delete(string pluginId)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpDelete == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpDelete.Invoke(context);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete, Route(PluginHttpApi.RouteName)]
        public HttpResponseMessage Delete(string pluginId, string name)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpDeleteWithName == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpDeleteWithName.Invoke(context, name);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete, Route(PluginHttpApi.RouteNameAndId)]
        public HttpResponseMessage Delete(string pluginId, string name, string id)
        {
            try
            {
                var context = new RequestContext();
                var service = PluginManager.GetService(pluginId);

                return service?.HttpDeleteWithNameAndId == null
                    ? Request.CreateResponse(HttpStatusCode.NotFound)
                    : service.HttpDeleteWithNameAndId.Invoke(context, name, id);
            }
            catch (Exception ex)
            {
                LogUtils.AddPluginErrorLog(pluginId, ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}