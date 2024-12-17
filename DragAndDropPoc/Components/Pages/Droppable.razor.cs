using Microsoft.AspNetCore.Components;

namespace DragAndDropPoc.Components.Pages;

public partial class Droppable<TObject>
{
    private void HandleDrop()
    {
        if (Objects == null)
        {
            return;
        }

        if (DragAndDrop?.ObjectParent is not List<TObject> parent)
        {
            return;
        }

        if (DragAndDrop.DraggedObject is not TObject tObject)
        {
            return;
        }

        parent.Remove(tObject);

        if (Objects.Contains(tObject))
        {
            return;
        }

        Objects.Add(tObject);
    }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [CascadingParameter]
    public DragAndDrop<TObject>? DragAndDrop { get; set; }

    [Parameter, EditorRequired]
    public List<TObject>? Objects { get; set; }
}