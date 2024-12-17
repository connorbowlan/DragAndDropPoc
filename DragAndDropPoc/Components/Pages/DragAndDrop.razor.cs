using System.Diagnostics;
using Microsoft.AspNetCore.Components;

namespace DragAndDropPoc.Components.Pages;

public partial class DragAndDrop<TObject>
{
    private string? DraggedObjectType => DraggedObject?.GetType().Name;

    public TObject? DraggedObject;

    public List<TObject>? ObjectParent;

    [Parameter, EditorRequired]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool Debug { get; set; }

    public void SetDraggedObject(TObject @object)
    {
        DraggedObject = @object;

        if (Debug && Debugger.IsAttached)
        {
            StateHasChanged();
        }
    }

    public void SetDraggedParent(List<TObject> parent)
    {
        ObjectParent = parent;

        if (Debug && Debugger.IsAttached)
        {
            StateHasChanged();
        }
    }
}