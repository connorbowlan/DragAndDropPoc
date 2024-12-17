using Microsoft.AspNetCore.Components;

namespace DragAndDropPoc.Components.Pages;

public partial class Draggable
{
    private void HandleDragStart()
    {
        if (Object != null)
        {
            DragAndDropTracker?.SetDraggedObject(Object);
        }
    }

    [Parameter, EditorRequired]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool StopPropagation { get; set; }

    [CascadingParameter]
    public DragAndDropTracker? DragAndDropTracker { get; set; }

    [Parameter]
    public List<object>? Parent { get; set; }

    [Parameter, EditorRequired]
    public object? Object { get; set; }
}