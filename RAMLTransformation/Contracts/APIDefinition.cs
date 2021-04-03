using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestEase;
using RAMLTransformation.Contracts.Models;

namespace RAMLTransformation.Contracts.Api
{
    /// <summary>
    /// APIDefinition
    /// </summary>
    public interface IAPIDefinitionApi
    {
        /// <summary>
        /// PostVaccinestatsAccesstoken (/vaccinestats/accesstoken)
        /// </summary>
        /// <param name="fullName"></param>
        [Post("/vaccinestats/accesstoken")]
        Task PostVaccinestatsAccesstokenAsync([Query] string fullName);

        /// <summary>
        /// GetVaccinestatsVaccinated (/vaccinestats/vaccinated)
        /// </summary>
        /// <param name="accessToken"></param>
        [Get("/vaccinestats/vaccinated")]
        Task GetVaccinestatsVaccinatedAsync([Query(Name = "access_token")] string accessToken);

        /// <summary>
        /// PostVaccinestatsVaccinated (/vaccinestats/vaccinated)
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="location"></param>
        /// <param name="date"></param>
        /// <param name="vaccineType"></param>
        [Post("/vaccinestats/vaccinated")]
        Task PostVaccinestatsVaccinatedAsync([Query(Name = "access_token")] string accessToken, [Query] string location, [Query] string date, [Query(Name = "vaccine_type")] string vaccineType);

        /// <summary>
        /// GetVaccinestatsVaccinatedByLocation (/vaccinestats/vaccinated/{location})
        /// </summary>
        /// <param name="accessToken"></param>
        [Get("/vaccinestats/vaccinated/{location}")]
        Task GetVaccinestatsVaccinatedByLocationAsync([Query(Name = "access_token")] string accessToken);

        /// <summary>
        /// GetVaccinestatsVaccinatedByDate (/vaccinestats/vaccinated/{date})
        /// </summary>
        /// <param name="accessToken"></param>
        [Get("/vaccinestats/vaccinated/{date}")]
        Task GetVaccinestatsVaccinatedByDateAsync([Query(Name = "access_token")] string accessToken);

        /// <summary>
        /// GetVaccinestatsVaccinatedByVaccinetype (/vaccinestats/vaccinated/{vaccinetype})
        /// </summary>
        /// <param name="accessToken"></param>
        [Get("/vaccinestats/vaccinated/{vaccinetype}")]
        Task GetVaccinestatsVaccinatedByVaccinetypeAsync([Query(Name = "access_token")] string accessToken);

        /// <summary>
        /// GetVaccinestatsVaccinatedSymptoms (/vaccinestats/vaccinated/symptoms)
        /// </summary>
        /// <param name="accessToken"></param>
        [Get("/vaccinestats/vaccinated/symptoms")]
        Task GetVaccinestatsVaccinatedSymptomsAsync([Query(Name = "access_token")] string accessToken);

        /// <summary>
        /// PostVaccinestatsVaccinatedSymptomsByVaccinetype (/vaccinestats/vaccinated/symptoms/{vaccinetype})
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="vaccineType"></param>
        /// <param name="symptoms"></param>
        [Post("/vaccinestats/vaccinated/symptoms/{vaccinetype}")]
        Task PostVaccinestatsVaccinatedSymptomsByVaccinetypeAsync([Query(Name = "access_token")] string accessToken, [Query(Name = "vaccine_type")] string vaccineType, [Query] string symptoms);
    }
}

namespace RAMLTransformation.Contracts.Models
{
    public class SuccessfulResponse
    {
        public string Location { get; set; }

        public string VaccineType { get; set; }

        public string Date { get; set; }

        public string AccessToken { get; set; }

        public string FullName { get; set; }

        public string Purpose { get; set; }

        public string Symptoms { get; set; }
    }
}
