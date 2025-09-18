using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

[Route("person")]
[ApiController]
public class PersonController : ControllerBase
{
    [HttpGet("GetAllUser")]
    public List<PersonDTO> GetAllUser()
    {
        string jsonData = System.IO.File.ReadAllText("./JSON/jsonDB.json");
        if (jsonData.Length != 0)
        {
            System.Console.WriteLine("datei ist nicht leer");
            List<PersonDTO> users = JsonSerializer.Deserialize<List<PersonDTO>>(jsonData)!;
            return users;
        }
        else
        {
            System.Console.WriteLine("datei ist leer");
            List<PersonDTO> users = new List<PersonDTO>();
            return users;
        }
    }
}