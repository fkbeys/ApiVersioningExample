using Microsoft.AspNetCore.Mvc.Versioning;

namespace ApiVersioningExample
{
    public static class ApiVersioningExtentionStartup
    {
        public static void ApiVersioningExtention(this IServiceCollection services)
        {
            services.AddApiVersioning(opt =>
            {
                //we define the default version...
                opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                //if the request doesnt contain any version number, we will redirect to the default version
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.ReportApiVersions = true;

                opt.ApiVersionReader = ApiVersionReader.Combine(
                    new UrlSegmentApiVersionReader(),
                    new HeaderApiVersionReader("x-api-version"),
                    new MediaTypeApiVersionReader("x-api-version"));

                 

            });


            services.AddVersionedApiExplorer(conf =>
            {
                conf.GroupNameFormat = "'v'VVV";
                conf.SubstituteApiVersionInUrl = true;
            });
        }
    }
}
