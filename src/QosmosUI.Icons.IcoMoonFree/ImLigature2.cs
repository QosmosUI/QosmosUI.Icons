// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImLigature2 : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 16 16";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M13.364 14.335c-0.183 0-1.307-0.206-1.375-0.458-0.161-0.619-0.183-1.284-0.183-2.040v-8.453c0-1.261 0.252-1.994 0.252-1.994-0.023-0.115-0.138-0.367-0.275-0.367h-0.069c-0.069 0-0.871 0.504-1.605 0.504-0.596-0-0.967-0.527-1.655-0.527-2.892 0-4.249 2.349-4.249 5.672v0.173c0 0.069-0.046 0.138-0.115 0.138h-0.94c-0.115 0-0.344 0.642-0.344 0.94 0 0.092 0.023 0.137 0.069 0.137h1.215c0.069 0 0.115 0.092 0.115 0.16 0 2.040-0.023 4.052-0.023 4.052 0 0.321-0.023 1.031-0.16 1.605-0.069 0.252-1.123 0.458-1.398 0.458-0.115 0-0.115 0.55 0 0.665 0.94-0.046 1.559-0.115 2.499-0.115 0.871 0 1.536 0.069 2.453 0.115 0.046-0.138 0.046-0.665-0.069-0.665-0.183 0-1.307-0.206-1.375-0.458-0.16-0.619-0.16-1.284-0.183-2.040v-3.639c0-0.069 0.069-0.138 0.138-0.138h2.361c0.16-0.321 0.275-0.711 0.275-0.917 0-0.138 0-0.16-0.115-0.16h-2.544c-0.046 0-0.115-0.069-0.115-0.115v-0.825c0-2.040 0.836-3.837 2.234-3.837 0.99 0 1.854 0.642 1.854 3.093 0 0 0 0 0 0 0.003 0.063 0.005 0.114 0.005 0.148v6.825c0 0.321-0.023 1.031-0.16 1.605-0.069 0.252-1.123 0.458-1.398 0.458-0.115 0-0.115 0.55 0 0.665 0.94-0.046 1.559-0.115 2.499-0.115 0.871 0 1.536 0.069 2.453 0.115 0.046-0.137 0.046-0.665-0.069-0.665z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
