// Template: Base Controller (ApiControllerBase.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RAMLTransformation.APIDefinition.Models;

// Do not modify this file. This code was generated by AMF Server Scaffolder

namespace RAMLTransformation.APIDefinition
{
    [ApiController]
    [Route("[controller]")]
    public partial class 1.0VaccinestatsController : Controller
    {


/// <summary>
		/// Provides the client with an access token for future API calls. - /vaccinestats/accesstoken
		/// </summary>
		/// <param name="content"></param>
		/// <param name="fullname"></param>
		/// <returns>VaccinestatsAccesstokenPost200</returns>
        [HttpPost("accesstoken")]
        public virtual async Task<IActionResult> PostBase([FromBody] string content,string fullname)
        {
            // Do not modify this code
                        return await ((I1.0VaccinestatsController)this).Post(content,fullname);
                    }

/// <summary>
		/// Outputs the total number of vaccinated people according to voluntary user input. - /vaccinestats/vaccinated
		/// </summary>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedGet200</returns>
        [HttpGet("vaccinated")]
        public virtual async Task<IActionResult> GetBase(string access_token)
        {
            // Do not modify this code
                        return await ((I1.0VaccinestatsController)this).Get(access_token);
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
        [HttpPost("vaccinated")]
        public virtual async Task<IActionResult> PostVaccinatedBase([FromBody] string content,string access_token,string location,string date,string vaccine_type)
        {
            // Do not modify this code
                        return await ((I1.0VaccinestatsController)this).PostVaccinated(content,access_token,location,date,vaccine_type);
                    }

/// <summary>
		/// Outputs a running list of locations users have received vaccines alongside a user count. - /vaccinestats/vaccinated/{location}
		/// </summary>
		/// <param name="Location"></param>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedLocationGet200</returns>
        [HttpGet("vaccinated/{location}")]
        public virtual async Task<IActionResult> GetVaccinatedByLocationBase(string Location,string access_token)
        {
            // Do not modify this code
                        return await ((I1.0VaccinestatsController)this).GetVaccinatedByLocation(Location,access_token);
                    }

/// <summary>
		/// Outputs a running list of dates users have received vaccines alongside a user count. - /vaccinestats/vaccinated/{date}
		/// </summary>
		/// <param name="Date"></param>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedDateGet200</returns>
        [HttpGet("vaccinated/{date}")]
        public virtual async Task<IActionResult> GetVaccinatedByDateBase(string Date,string access_token)
        {
            // Do not modify this code
                        return await ((I1.0VaccinestatsController)this).GetVaccinatedByDate(Date,access_token);
                    }

/// <summary>
		/// Outputs a running list of vaccine types users have received alongside a user count. - /vaccinestats/vaccinated/{vaccinetype}
		/// </summary>
		/// <param name="Vaccinetype"></param>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedVaccinetypeGet200</returns>
        [HttpGet("vaccinated/{vaccinetype}")]
        public virtual async Task<IActionResult> GetVaccinatedByVaccinetypeBase(string Vaccinetype,string access_token)
        {
            // Do not modify this code
                        return await ((I1.0VaccinestatsController)this).GetVaccinatedByVaccinetype(Vaccinetype,access_token);
                    }

/// <summary>
		/// Outputs a running list of user-reported symptoms alongside the vaccine user(s) received. - /vaccinestats/vaccinated/symptoms
		/// </summary>
		/// <param name="access_token"></param>
		/// <returns>VaccinestatsVaccinatedSymptomsGet200</returns>
        [HttpGet("vaccinated/symptoms")]
        public virtual async Task<IActionResult> GetVaccinatedSymptomsBase(string access_token)
        {
            // Do not modify this code
                        return await ((I1.0VaccinestatsController)this).GetVaccinatedSymptoms(access_token);
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
        [HttpPost("vaccinated/symptoms/{vaccinetype}")]
        public virtual async Task<IActionResult> PostVaccinatedSymptomsByVaccinetypeBase([FromBody] string content,string Vaccinetype,string access_token,string vaccine_type,string symptoms)
        {
            // Do not modify this code
                        return await ((I1.0VaccinestatsController)this).PostVaccinatedSymptomsByVaccinetype(content,Vaccinetype,access_token,vaccine_type,symptoms);
                    }
    }
}