using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Sample1.Controllers;
using Sample1.Models.Input;
using Sample1.Models.Output;
using Sample1.Repository;

namespace MLS.ServiceGateway.Cybersource.UnitTests
{
	[TestClass]
	public class SubscriptionTests
	{
		[ClassInitialize]
		public static void ClassInitialize(TestContext context)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(System.AppContext.BaseDirectory)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

			IConfiguration configuration = builder.Build();	
		}

		[TestMethod]
		public void Test1_Post()
		{
			var mock = new Mock<ILogger<RobotsController>>();

			ILogger<RobotsController> logger = mock.Object;

			// Create mock HttpRequest.
			Dictionary<string, StringValues> query = new Dictionary<string, StringValues>();

			query.Add("version", new StringValues("1.0"));

			PalletTransportRequest l = new PalletTransportRequest();

			var req = new Mock<HttpRequest>();

			req.Setup(r => r.Path).Returns(new PathString($"/api/robots/closest"));
			req.Setup(r => r.Query).Returns(new QueryCollection(query));
			req.Setup(r => r.Headers).Returns(new HeaderDictionary());

			var stream = new MemoryStream();
			var writer = new StreamWriter(stream);
			writer.Write(Newtonsoft.Json.JsonConvert.SerializeObject(l));
			writer.Flush();
			stream.Position = 0;
			req.Setup(r => r.Body).Returns(stream);
			
			var repository = new RobotRepository();

			var controller = new RobotsController(logger, repository);

			var response = controller.Closest(l);

			Assert.IsTrue(response.GetType() == typeof(ObjectResult));			
		}
	}
}
