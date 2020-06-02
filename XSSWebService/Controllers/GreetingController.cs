using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using Microsoft.Security.Application;

namespace XSSWebService.Controllers
{
    public class GreetingController : ApiController
    {
        [Route("api/Greeting")]
        [HttpGet]
        public HttpResponseMessage GetGreeting(string name)
        {
            // Generate an insecure <div> element that displays a greeting message to the user
            var response = new HttpResponseMessage();
            response.Content = new StringContent(String.Format("<div>Hello there, {0}!</div>", name));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }

        [Route("api/Greeting/secure")]
        [HttpGet]
        public HttpResponseMessage GetSecureGreeting(string name)
        {
            // Generate a secure <div> element that displays a greeting message to the user
            var response = new HttpResponseMessage();
            // Sanitize the incoming string before generating the greeting message
            string sanitizedName = Sanitizer.GetSafeHtmlFragment(name);
            response.Content = new StringContent(String.Format("<div>Hi there, {0}!</div>", sanitizedName));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}