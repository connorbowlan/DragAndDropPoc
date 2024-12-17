namespace DragAndDropPoc.Components.Pages.Models;

public class Item(string name)
{

    public Guid Id = Guid.NewGuid();

    public string Name { get; set; } = name;

}