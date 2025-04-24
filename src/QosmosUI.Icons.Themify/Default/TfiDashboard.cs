// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiDashboard : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M17 11.5v0.5h-6.168v-1h5.152c-0.112-1.692-0.789-3.231-1.842-4.434l-0.806 0.806-0.707-0.707 0.802-0.802c-1.202-1.053-2.74-1.726-4.431-1.839v2.976h-1v-2.976c-1.691 0.113-3.229 0.786-4.43 1.839l0.796 0.796-0.707 0.707-0.8-0.8c-1.053 1.203-1.731 2.742-1.842 4.434h5.171v1h-6.188v-0.5c0-4.687 3.813-8.5 8.5-8.5s8.5 3.813 8.5 8.5zM10.5 11.5c0 1.103-0.897 2-2 2s-2-0.897-2-2c0-0.644 0.311-1.21 0.784-1.577l-2.082-3.63 0.867-0.497 2.141 3.733c0.095-0.014 0.19-0.029 0.29-0.029 1.103 0 2 0.897 2 2zM9.5 11.5c0-0.551-0.449-1-1-1s-1 0.449-1 1 0.449 1 1 1 1-0.449 1-1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
