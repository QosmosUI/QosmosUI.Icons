using Microsoft.AspNetCore.Components;

namespace QosmosUI.Icons.Docs.Components.Breadcrumb;

public partial class Breadcrumb : ComponentBase
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}

