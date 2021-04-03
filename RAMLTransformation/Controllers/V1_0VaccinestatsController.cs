// Template: Controller Implementation (ApiControllerImplementation.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RAMLTransformation.APIDefinition.Models;

namespace RAMLTransformation.APIDefinition
{
    public partial class 1.0VaccinestatsController : I1.0VaccinestatsController
    {

/// <summary>
		/// Provides the client with an access token for future API calls. - /vaccinestats/accesstoken
		/// </summary>
		/// <param name="content"></param>
		/// <param name="fullname"></param>
		/// <returns>VaccinestatsAccesstokenPost200</returns>
        public async Task<IActionResult> Post([FromBody] string content,string fullname)
        {
            // TODO: implement Post - route: vaccinestats/accesstoken
			// var result = new VaccinestatsAccesstokenPost200();
			// return new OkObjectResult(result);
			return new OkObjectResult("");
        }

/// <summary>
		/// Outputs the total number of vaccinated people according to voluntary user input. - /vaccinestats/vaccinated
		/// </summary>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedGet200</returns>
        public async Task<IActionResult> Get(string access_token)
        {
            // TODO: implement Get - route: vaccinestats/vaccinated
			// var result = new VaccinestatsVaccinatedGet200();
			// return new OkObjectResult(result);
			return new OkObjectResult("");
        }

/// <summary>
		/// Adds a randomly generated ID to the database to count another person as vaccinated. - /vaccinestats/vaccinated
		/// </summary>
		/// <param name="content"></param>
		/// <param name="access_token"></param>
		/// <param name="location"></param>
		/// <param name="date"></param>
		/// <param name="vaccine_type"></param>
		/// <returns>VaccinestatsVaccinatedPost200</returns>
        public async Task<IActionResult> PostVaccinated([FromBody] string content,string access_token,string location,string date,string vaccine_type)
        {
            // TODO: implement PostVaccinated - route: vaccinestats/vaccinated
			// var result = new VaccinestatsVaccinatedPost200();
			// return new OkObjectResult(result);
			return new OkObjectResult("");
        }

/// <summary>
		/// Outputs a running list of locations users have received vaccines alongside a user count. - /vaccinestats/vaccinated/{location}
		/// </summary>
		/// <param name="Location"></param>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedLocationGet200</returns>
        public async Task<IActionResult> GetVaccinatedByLocation(string Location,string access_token)
        {
            // TODO: implement GetVaccinatedByLocation - route: vaccinestats/vaccinated/{location}
			// var result = new VaccinestatsVaccinatedLocationGet200();
			// return new OkObjectResult(result);
			return new OkObjectResult("");
        }

/// <summary>
		/// Outputs a running list of dates users have received vaccines alongside a user count. - /vaccinestats/vaccinated/{date}
		/// </summary>
		/// <param name="Date"></param>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedDateGet200</returns>
        public async Task<IActionResult> GetVaccinatedByDate(string Date,string access_token)
        {
            // TODO: implement GetVaccinatedByDate - route: vaccinestats/vaccinated/{date}
			// var result = new VaccinestatsVaccinatedDateGet200();
			// return new OkObjectResult(result);
			return new OkObjectResult("");
        }

/// <summary>
		/// Outputs a running list of vaccine types users have received alongside a user count. - /vaccinestats/vaccinated/{vaccinetype}
		/// </summary>
		/// <param name="Vaccinetype"></param>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedVaccinetypeGet200</returns>
        public async Task<IActionResult> GetVaccinatedByVaccinetype(string Vaccinetype,string access_token)
        {
            // TODO: implement GetVaccinatedByVaccinetype - route: vaccinestats/vaccinated/{vaccinetype}
			// var result = new VaccinestatsVaccinatedVaccinetypeGet200();
			// return new OkObjectResult(result);
			return new OkObjectResult("");
        }

/// <summary>
		/// Outputs a running list of user-reported symptoms alongside the vaccine user(s) received. - /vaccinestats/vaccinated/symptoms
		/// </summary>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedSymptomsGet200</returns>
        public async Task<IActionResult> GetVaccinatedSymptoms(string access_token)
        {
            // TODO: implement GetVaccinatedSymptoms - route: vaccinestats/vaccinated/symptoms
			// var result = new VaccinestatsVaccinatedSymptomsGet200();
			// return new OkObjectResult(result);
			return new OkObjectResult("");
        }

/// <summary>
		/// Allows the user to report their symptoms and to specify the vaccine type they received. - /vaccinestats/vaccinated/symptoms/{vaccinetype}
		/// </summary>
		/// <param name="content"></param>
		/// <param name="Vaccinetype"></param>
		/// <param name="access_token"></param>
		/// <param name="vaccine_type"></param>
		/// <param name="symptoms"></param>
		/// <returns>VaccinestatsVaccinatedSymptomsVaccinetypePost200</returns>
        public async Task<IActionResult> PostVaccinatedSymptomsByVaccinetype([FromBody] string content,string Vaccinetype,string access_token,string vaccine_type,string symptoms)
        {
            // TODO: implement PostVaccinatedSymptomsByVaccinetype - route: vaccinestats/vaccinated/symptoms/{vaccinetype}
			// var result = new VaccinestatsVaccinatedSymptomsVaccinetypePost200();
			// return new OkObjectResult(result);
			return new OkObjectResult("");
        }

    }
}
