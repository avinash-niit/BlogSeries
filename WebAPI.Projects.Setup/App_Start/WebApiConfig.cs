using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace WebAPI.Projects.Setup
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            SetSerializationDefaults(config.Formatters.JsonFormatter.SerializerSettings);

        }

        private static void SetSerializationDefaults(JsonSerializerSettings serializerSettings)
        {
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //Lot more will be added here            
        }
    }
}
