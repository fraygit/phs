using System.Web.Http;
using WebActivatorEx;
using Phs.API;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Phs.API
{
	public class SwaggerConfig
	{
		public static void Register()
		{
			var thisAssembly = typeof(SwaggerConfig).Assembly;

			GlobalConfiguration.Configuration
                .EnableSwagger(c => { c.SingleApiVersion("v1", "Phs.API");
                c.IncludeXmlComments(string.Format(@"{0}\bin\Phs.API.XML",           
                           System.AppDomain.CurrentDomain.BaseDirectory)); })
				.EnableSwaggerUi(c => { });
		}
	}
}
