// Template: Controller Interface (ApiControllerInterface.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RAMLTransformation.APIDefinition.Models;


namespace RAMLTransformation.APIDefinition
{
    public interface I1.0VaccinestatsController
    {

        Task<IActionResult> Post([FromBody] string content,string fullname);
        Task<IActionResult> Get(string access_token);
        Task<IActionResult> PostVaccinated([FromBody] string content,string access_token,string location,string date,string vaccine_type);
        Task<IActionResult> GetVaccinatedByLocation(string Location,string access_token);
        Task<IActionResult> GetVaccinatedByDate(string Date,string access_token);
        Task<IActionResult> GetVaccinatedByVaccinetype(string Vaccinetype,string access_token);
        Task<IActionResult> GetVaccinatedSymptoms(string access_token);
        Task<IActionResult> PostVaccinatedSymptomsByVaccinetype([FromBody] string content,string Vaccinetype,string access_token,string vaccine_type,string symptoms);
    }
}
