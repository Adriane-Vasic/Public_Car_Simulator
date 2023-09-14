using CarLibrary;
using DriverLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Services
{
    public class DriverService : IDriverService
    {

        public async Task<API.Result> GetApiResult()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://randomuser.me/api/?inc=gender,name,email,dob"; // Replace with your API URL
                API.Result testResult = null;
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    // Console.WriteLine($"Response Content: {responseContent}");

                    try
                    {
                        API.ResponseData responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<API.ResponseData>(responseContent);

                        // Access the properties of the POCO
                        API.Result result = responseData.Results[0];

                        return result;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception occurred during deserialization: {ex}");
                    }
                }
                else
                {
                    Console.WriteLine($"HTTP request failed with status code: {response.StatusCode}");
                }

                return testResult;
            }

        }

        public Driver CreateDriver(Task<API.Result> result)
        {
            var driver = new Driver
            {
                FirstName = result.Result.Name.First,
                LastName = result.Result.Name.Last,
                Title = result.Result.Name.Title,
                Age = result.Result.Dob.Age,
                Email = result.Result.Email,
                Gender = result.Result.Gender,
                Energy = 20
            };


            return driver;
        }


        public Driver GetDriver()
        {
            var api = GetApiResult();
            var driver = CreateDriver(api);

            return driver;
        }

        public string DriverStatus(Driver driver)
        {
            if (driver.Energy < 10 && driver.Energy != 0)
            {
                var softMessage = "***** You Are Getting Tired. You Should Take a break ****\n";
                return softMessage;
            }

            if (driver.Energy == 0)
            {
                var hardMessage = "--------------- STOP & REST! ------------\n" +
                                 "DRIVING WHILE EXHAUSTED IS AS DANGEROUS AS DRIVING UNDER THE INFLUENCE! FOR YOUR SAFETY AND OTHERS STOP AND REST\n" +
                                 "********************************************************************************************************************\n";
                return hardMessage;
            }

            return "";
        }

        public Driver DriverGetsTired(Driver driver)
        {
            driver.Energy--;

            return driver;
        }

       
    }
}
