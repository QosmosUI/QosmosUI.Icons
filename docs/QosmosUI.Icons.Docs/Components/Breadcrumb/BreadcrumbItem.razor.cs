using Microsoft.AspNetCore.Components;

namespace QosmosUI.Icons.Docs.Components.Breadcrumb;

public partial class BreadcrumbItem : ComponentBase
{
    [Parameter]
    public string? Title { get; set; }

    [Parameter]
    public string? Href { get; set; }
}

