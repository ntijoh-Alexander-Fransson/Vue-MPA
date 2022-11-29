namespace TodoApi.Models;

public class TodoItem
{
    public long Id {get; set;}
    public string? Name {get; set;}
    public bool Done {get; set;}
    public bool Hidden {get; set;}
}