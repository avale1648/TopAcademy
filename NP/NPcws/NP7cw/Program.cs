using HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("https://panorama.pub/science");
response.EnsureSuccessStatusCode();
string body = await response.Content.ReadAsStringAsync();
Console.WriteLine(body);

