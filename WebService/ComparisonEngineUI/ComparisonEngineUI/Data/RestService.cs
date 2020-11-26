using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebService.Base_Classes;

namespace ComparisonEngineUI.Data
{
    class RestService
    {
        HttpClient client;

        public RestService()
        {
            client = new HttpClient();
        }

        public async Task<List<Bar>> GetBars()
        {
            Uri uri = new Uri(Constants.BarsUrl);
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                if(!response.IsSuccessStatusCode)
                {
                    return null;
                }

                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Bar>>(content);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Drink>> GetDrinks()
        {
            Uri uri = new Uri(Constants.DrinksUrl);
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Drink>>(content);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<SpecificPrice>> GetSpecificPrices()
        {
            Uri uri = new Uri(Constants.SpecificPricesUrl);
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SpecificPrice>>(content);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> SaveBar(Bar bar, bool isNew)
        {
            Uri uri = new Uri(Constants.BarsUrl);

            try
            {
                string json = JsonConvert.SerializeObject(bar);
                var content = new StringContent(json);
                HttpResponseMessage response = null;

                if (isNew)
                {
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    response = await client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SaveDrink(Drink drink, bool isNew)
        {
            Uri uri = new Uri(Constants.DrinksUrl);

            try
            {
                string json = JsonConvert.SerializeObject(drink);
                var content = new StringContent(json);
                HttpResponseMessage response = null;

                if (isNew)
                {
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    response = await client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SaveSpecificPrice(SpecificPrice specificPrice, bool isNew)
        {
            Uri uri = new Uri(Constants.SpecificPricesUrl);

            try
            {
                string json = JsonConvert.SerializeObject(specificPrice);
                var content = new StringContent(json);
                HttpResponseMessage response = null;

                if (isNew)
                {
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    response = await client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteBar(string id)
        {
            Uri uri = new Uri(string.Format(Constants.BarsUrl, id));
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(uri);

                if(response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteDrink(string id)
        {
            Uri uri = new Uri(string.Format(Constants.DrinksUrl, id));
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteSpecificPrice(string id)
        {
            Uri uri = new Uri(string.Format(Constants.SpecificPricesUrl, id));
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
