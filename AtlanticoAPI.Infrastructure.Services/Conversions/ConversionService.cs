using AtlanticoAPI.Application.Interfaces.ExtServices.Conversions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AtlanticoAPI.Infrastructure.Services.Conversions
{
    public class ConversionService : IConversionService
    {
        private IConfiguration configuration;

        public ConversionService(IConfiguration iConfig)
        {
            configuration = iConfig;
        }

        /// <summary>
        /// Get API url
        /// </summary>
        /// <returns>Returns api url</returns>
        private string GetAPIUrl()
        {
            return configuration.GetSection("ConversionAPIUrl").Value;
        }


        /// <summary>
        /// Get the conversion rate
        /// </summary>
        /// <param name="currency"> Currency </param>
        /// <returns>Returns rates in json format</returns>
        public async Task<string> GetRate(string currency)
        {
            string url = GetAPIUrl();

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(url);

                var content = new FormUrlEncodedContent(new[]
                {new KeyValuePair<string, string>("from", currency) });

                var result = await client.PostAsync(url, content);

                string resultContent = await result.Content.ReadAsStringAsync();
                return resultContent;
            }
        }
    }
}
