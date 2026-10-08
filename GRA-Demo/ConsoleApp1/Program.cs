using ConsoleApp1.APIHandler;

APIHandler aPIHandler = new APIHandler();

string url = "http://localhost:5197/users";

var user = new
{
    UserName = "David",
    Designation = "Developer",
    TeamName = "Team D"
};

KeyValuePair<int, string> r = await aPIHandler.PostAsync(url, user);

Console.WriteLine($"This is the status code: {r.Key}");
Console.WriteLine($"This is the response: {r.Value}");

Console.ReadLine();

