using Microsoft.Extensions.Configuration;


namespace RecipesApi
{


    class AppConfig
    {
        private readonly IConfiguration configuration;

        public AppConfig(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }

}