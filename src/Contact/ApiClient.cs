using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Ivvy.API
{
    public partial class ApiClient : IApiClient
    {
        /// <summary>
        /// Returns a specific contact.
        /// </summary>
        public async Task<ResultOrError<Contact.Contact>> GetContactAsync(int id)
        {
            return await CallAsync<Contact.Contact>(
                "contact", "getContact", new
                {
                    id
                }
            );
        }

        /// <summary>
        /// Returns a collection of contacts.
        /// </summary>
        public async Task<ResultOrError<ResultList<Contact.Contact>>> GetContactListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest)
        {
            return await CallAsync<ResultList<Contact.Contact>>(
                "contact", "getContactList",
                new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <summary>
        /// Adds or updates a contact.
        /// </summary>
        public async Task<ResultOrError<Contact.ContactResult>> AddOrUpdateContactAsync(Contact.Contact contact)
        {
            return await CallAsync<Contact.ContactResult>(
                "contact", "addOrUpdateContact", contact
            );
        }

        /// <summary>
        /// Returns a specific company.
        /// </summary>
        public async Task<ResultOrError<Contact.Company>> GetCompanyAsync(int id)
        {
            return await CallAsync<Contact.Company>(
                "contact", "getCompany", new
                {
                    id,
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultList<Contact.Company>>> GetCompanyListAsync(
            int perPage,
            int start,
            Dictionary<string, object> filterRequest)
        {
            return await CallAsync<ResultList<Contact.Company>>(
                "contact", "getCompanyList",
                new
                {
                    perPage,
                    start,
                    filter = filterRequest
                }
            );
        }

        /// <inheritdoc />
        public async Task<ResultOrError<ResultObject>> AddOrUpdateCompanyAsync(Contact.Company company)
        {
            return await CallAsync<ResultObject>(
                "contact", "addOrUpdateCompany", company
            );
        }

        public class GroupAddResult {
            [JsonProperty("contactId")]
            int contactId {get; set;}
            [JsonProperty("status")]
            string status {get; set;}
        }

        public async Task<ResultOrError<List<GroupAddResult>>> AddContactGroupAsync(object contactGroup)
        {
            // KeyValuePair resultsList;
            return await CallAsync<List<GroupAddResult>>(
                "contact", "addContactsToSubscriptionGroup", contactGroup
            );
        }
    }
}