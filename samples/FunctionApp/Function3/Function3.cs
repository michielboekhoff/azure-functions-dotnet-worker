﻿using Microsoft.Azure.Functions.DotNetWorker;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace FunctionApp
{
    public static class Function3
    {

        [FunctionName("Function3")]
        public static HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequestData req,
            OutputBinding<string> name)
        {
            var response = new HttpResponseData();
            response.StatusCode = "200";
            response.Body = "Success!!";

            name.SetValue("some name");

            return response;
        }
    }

}