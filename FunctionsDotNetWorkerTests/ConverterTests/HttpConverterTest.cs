﻿using CommandLine;
using FunctionsDotNetWorker;
using FunctionsDotNetWorker.Converters;
using Microsoft.Azure.WebJobs.Script.Grpc.Messages;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace FunctionsDotNetWorkerTests
{
    public class HttpConverterTests
    { 
        private HttpRequestDataConverter _httpConverter;
        public HttpConverterTests()
        {
            _httpConverter = new HttpRequestDataConverter();
        }

        [Fact]
        public void SourceIsNotRpcHttpTest()
        {
            object source = new List<string>();
            object target;
            Type targetType = typeof(HttpRequestData);
            var result = _httpConverter.TryConvert(source, targetType, "name", out target);
            Assert.False(result);
        }

        [Fact]
        public void TargetIsNotHttpRequestDataTest()
        {
            object source = new RpcHttp();
            object target;
            System.Type targetType = typeof(string);
            var result = _httpConverter.TryConvert(source, targetType, "name", out target);
            Assert.False(result);
        }

        [Fact]
        public void SuccessfulConverstionTest()
        {
            object source = new RpcHttp();
            object target;
            Type targetType = typeof(HttpRequestData);
            var result = _httpConverter.TryConvert(source, targetType, "name", out target);
            Assert.True(result);
        }
    }
}