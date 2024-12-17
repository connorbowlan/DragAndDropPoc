using System.Diagnostics;
using Microsoft.AspNetCore.Components;

namespace DragAndDropPoc.Components.Pages;

public partial class DragAndDropTracker
{
    private string? DraggedObjectType => DraggedObject?.GetType().Name;

    public object? DraggedObject;

    public List<object>? ObjectParent;

    [Parameter, EditorRequired]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool Debug { get; set; }

    public void SetDraggedObject(object @object)
    {
        DraggedObject = @object;

        if (Debug && Debugger.IsAttached)
        {
            StateHasChanged();
        }
    }

    public void SetDraggedParent(List<object> parent)
    {
        ObjectParent = parent;

        if (Debug && Debugger.IsAttached)
        {
            StateHasChanged();
        }
    }
}