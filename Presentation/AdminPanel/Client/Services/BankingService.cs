using AdminPanel.Shared;
using AdminPanel.Shared.DTOs;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace AdminPanel.Client.Services
{
    public class BankingService : IBankingService
    {
        private readonly HttpClient _apiClient;
        public BankingService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<List<TransferDTO>> GetTransferHistory()
        {
            var uri = "https://localhost:5005/History";

            var response = await _apiClient.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<List<TransferDTO>>();
        }

        public async Task<List<Account>> GetAccounts()
        {
            var uri = "https://localhost:5003/Account";

            var response = await _apiClient.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<List<Account>>();
        }
    }
}