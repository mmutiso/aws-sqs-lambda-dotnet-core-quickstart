using Amazon.Lambda.Core;
using System;

using Newtonsoft.Json;
using System.Threading.Tasks;
using Amazon.Lambda.SQSEvents;
using System.Net.Mime;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace autoscale_lambda
{
    public class Program
    {
        public async Task  FunctionHandler(SQSEvent invocationEvent, ILambdaContext context)
        {
            await Task.FromResult(0);

            LambdaLogger.Log("Context: " + JsonConvert.SerializeObject(context));
            LambdaLogger.Log("Event: " + JsonConvert.SerializeObject(invocationEvent));
        }
    }
}
