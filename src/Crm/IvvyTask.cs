using System;
using Newtonsoft.Json;

namespace Ivvy.API.Crm
{
    /// <summary>
    /// An iVvy CRM task.
    /// </summary>
    public class IvvyTask // https://developer.ivvy.com/crm/add-or-update-task
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id
        {
            get; set;
        }

        // [JsonProperty("venueId")]
        // public int VenueId
        // {
        //     get; set;
        // }

        [JsonProperty("contactId")]
        public int? ContactId
        {
            get; set;
        }

        [JsonProperty("endDatetime")]
        protected string APiDateTime => EndDateTime.ToString("yyyy-MM-dd 09:00:00");
        public DateTime EndDateTime
        {
            get; set;
        }

        [JsonProperty("priority")]
        public string Priority // low, medium, high
        {
            get; set;
        }

        [JsonProperty("status")]
        public int Status // 0 = not started
        {
            get; set;
        }

        [JsonProperty("assignedUserId")]
        public int? AssignedUserId
        {
            get; set;
        }

        [JsonProperty("companyId")]
        public int? CompanyId
        {
            get; set;
        }
        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }
        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

    }
}
