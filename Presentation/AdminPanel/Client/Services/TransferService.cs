using AdminPanel.Shared.DTOs;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace AdminPanel.Client.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;
        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Transfer(TransferDTO transferDTO)
        {
            var uri = "https://localhost:5003/Transfer";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDTO), System.Text.Encoding.UTF8);

            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}