using DragAndDropPoc.Components.Pages.Models;
using Microsoft.AspNetCore.Components.Web;

namespace DragAndDropPoc.Components.Pages;

public partial class Home2
{

    #region Private Fields

    private readonly Container _container1 = new("Container 1")
    {
        Items =
        [
            new Item("Item 1"),
            new Item("Item 2"),
            new Item("Item 3")
        ]
    };

    private readonly Container _container2 = new("Container 2")
    {
        Items =
        [
            new Item("Item 4"),
            new Item("Item 5"),
            new Item("Item 6")
        ]
    };

    private Item? _draggedItem;
    private Container? _draggedItemContainer;
    #endregion Private Fields

    #region Protected Methods

    protected override void OnInitialized()
    {
    }

    #endregion Protected Methods

    #region Private Methods

    private void HandleDragStart(Container container, Item item)
    {
        _draggedItemContainer = container;
        _draggedItem = item;

        StateHasChanged();
    }

    private void HandleDrop(Container targetContainer)
    {
        if (_draggedItem != null)
        {
            if (_draggedItemContainer != null)
            {
                if (_draggedItemContainer.Items.Contains(_draggedItem))
                {
                    _draggedItemContainer.Items.Remove(_draggedItem);
                }
            }

            targetContainer.Items.Add(_draggedItem);
        }

        _draggedItemContainer = null;
        _draggedItem = null;
    }

    #endregion Private Methods

    private string? GetCssClass(Container container)
    {
        if (_draggedItemContainer == container)
        {
            return "drag-active";
        }

        return null;
    }
}