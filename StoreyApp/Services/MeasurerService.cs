using Newtonsoft.Json;
using StoreyApp.Enums;
using StoreyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace StoreyApp.Services
{
    public class MeasurerService
    {
        public async Task<List<Measurer>> GetMeasurers()
        {

            List<Measurer> measurers = new List<Measurer>();

            var mockApiMeasurers = await AddMockApiMeasurersAsync();

            measurers.AddRange(mockApiMeasurers);

            measurers.AddRange(AddAdditionalMeasurers());

            return measurers;
        }

        private async Task<List<Measurer>> AddMockApiMeasurersAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string url = "https://63643e927b209ece0f4372e0.mockapi.io/usuarios";
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    string content = await response.Content.ReadAsStringAsync();

                    var measurers = JsonConvert.DeserializeObject<List<Measurer>>(content);

                    return measurers;
                }
                catch (Exception ex)
                {
                    return new List<Measurer>();
                }

            }
        }

        private List<Measurer> AddAdditionalMeasurers()
        {
            var measurersAmount = 1000;
            List<Measurer> measurers = new List<Measurer>();

            for (var i = 0; i < measurersAmount; i++)
            {
                measurers.Add(new Measurer("DDZ1513", "37801561", "1853520", "CHAVES ALICIA", "YRIGOYEN H. 1560", "AYACUCHO", "", MeasurerStatus.Inactive, new DateTime(2020, 12, 5, 20, 54, 3)));
            }

            return measurers;
        }
    }
}