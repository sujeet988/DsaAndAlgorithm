using Newtonsoft.Json.Linq;

namespace CallApi
{
    internal class Program
    {
       async static Task Main(string[] args)
        {
            Console.WriteLine("Enter Country Name");
            string countryName = Console.ReadLine(); // Afghanistan Input the country name // Replace with the country name you want to query
            string capital = await GetCapitalApproach1(countryName);
            Console.WriteLine("Capital: " + capital);
        }

        private static async Task<string> GetCapitalApproach1(string countrtName)
        {
            string apiurl = $"https://jsonmock.hackerrank.com/api/countries?name={countrtName}";
            using (HttpClient client = new HttpClient()) 
            {
                try
                {
                    HttpResponseMessage responseMessage= await client.GetAsync(apiurl);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        string json= await responseMessage.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(json);
                        JArray countries = (JArray)data["data"];
                        if (countries.Count > 0)
                        {
                            // Country found, return capital
                            return (string)countries[0]["capital"];
                        }
                        else
                        {
                            // Country not found
                            return "-1";
                        }



                    }
                    else
                    {
                        // Handle HTTP error
                        Console.WriteLine("Error: " + responseMessage.StatusCode);
                        return "-1";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "-1";
                }
            
            }
        }


        private static async Task<string> GetCapitalApproach2(string countrtName)
        {
            string apiurl = $"https://jsonmock.hackerrank.com/api/countries?name={countrtName}";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(apiurl);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        string json = await responseMessage.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(json);
                        JArray countries = (JArray)data["data"];
                        if (countries.Count > 0)
                        {
                            // Country found, return capital
                            return (string)countries[0]["capital"];
                        }
                        else
                        {
                            // Country not found
                            return "-1";
                        }



                    }
                    else
                    {
                        // Handle HTTP error
                        Console.WriteLine("Error: " + responseMessage.StatusCode);
                        return "-1";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "-1";
                }

            }
        }
    }
}