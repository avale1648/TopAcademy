using System.Text.RegularExpressions;
//1
string refference = "https://github.com";
using (HttpClient client = new HttpClient())
{
    try
    {
        HttpResponseMessage response = await client.GetAsync(refference);
        string body = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Cайт:\n\n{body}");
        Regex regex = new Regex(@"href\s*=\s*(?:[""'](?<1>[^""']*)[""']|(?<1>[^>\s]+))");
        MatchCollection matches = regex.Matches(body);
        Console.WriteLine("Ссылки:\n\n");
        if (matches.Count > 0)
            foreach (Match match in matches)
                Console.WriteLine(match.Value[6..^1]);
        else
            Console.WriteLine("Нет ссылок");
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
//2
using (HttpClient client = new HttpClient())
{
    try
    {
        Queue<string> refs = new Queue<string>();
        refs.Enqueue(refference);
        HttpResponseMessage response = await client.GetAsync(refs.Dequeue());
        string body = await response.Content.ReadAsStringAsync();
        
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine(ex.Message);
    }
}