using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;
using QosmosUI.Icons.Docs.Extensions;

namespace QosmosUI.Icons.Docs.Components.Sidebar;

public partial class SidebarNavLink : ComponentBase
{
    [Inject]
    [NotNull]
    private NavigationManager? Navigation { get; set; }

    [Parameter]
    [NotNull]
    public string? To { get; set; }

    [Parameter]
    public bool IsNew { get; set; }

    [Parameter]
    [NotNull]
    public RenderFragment? ChildContent { get; set; }

    private string AdditionalClasses =>
        Navigation.IsMatch(To) ? "bg-accent text-accent-foreground font-medium" : "text-muted-foreground font-normal";
}

