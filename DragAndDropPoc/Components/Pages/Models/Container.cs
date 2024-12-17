namespace DragAndDropPoc.Components.Pages.Models;

public class Container(string name)
{

    public Guid Id = Guid.NewGuid();

    public List<Container> ChildContainers { get; set; } = [];

    public List<Item> Items { get; set; } = [];

    public string Name { get; set; } = name;

}