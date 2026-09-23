namespace StarWarsPlanetsStats.ApiDataAccess
{
    public class ApiDataReader : IApiDataReader
    {
        public async Task<string> Read(string baseAddress, string responseUri)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            HttpResponseMessage response = await client.GetAsync(responseUri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}