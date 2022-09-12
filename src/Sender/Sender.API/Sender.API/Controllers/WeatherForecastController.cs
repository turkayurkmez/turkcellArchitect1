using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Sender.API.Models;

namespace Sender.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPublishEndpoint publishEndpoint;
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IPublishEndpoint publishEndpoint, ISendEndpointProvider sendEndpointProvider)
        {
            _logger = logger;
            this.publishEndpoint = publishEndpoint;
            _sendEndpointProvider = sendEndpointProvider;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public async Task<IActionResult> Send(string message)
        {
            var mQMessage = new MQMessageEvent { Message = message };
            await publishEndpoint.Publish<MQMessageEvent>(mQMessage);

            //Dikkat!! ISendEndpointProvider -> Queue
            //         IPublishEndpoint -> Tüm dinleyenlere gönderir.
            var sendEndPoint =  await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:send-message"));
            await sendEndPoint.Send(mQMessage);

            return Ok(new { message = $"Message is send....{mQMessage.Message}" });

        }
    }
}