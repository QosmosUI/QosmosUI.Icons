// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiLayoutSidebarRight : ComponentBase
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
		builder.AddAttribute(15, "d", "M17 0v17h-5v-17h5zM9 17h1v-1h-1v1zM7.223 17h0.889v-1h-0.889v1zM1.889 17h0.889v-1h-0.889v1zM3.667 17h0.889v-1h-0.889v1zM5.445 17h0.889v-1h-0.889v1zM0 17h1v-1h-1v1zM0 9h1v-1h-1v1zM0 3h1v-1h-1v1zM0 11h1v-1h-1v1zM0 7h1v-1h-1v1zM0 13h1v-1h-1v1zM0 15h1v-1h-1v1zM0 5h1v-1h-1v1zM0 1h1v-1h-1v1zM8.111 0h-0.889v1h0.889v-1zM6.333 0h-0.889v1h0.889v-1zM2.777 0h-0.888v1h0.889v-1zM4.555 0h-0.888v1h0.889v-1zM9 1h1v-1h-1v1zM9 15h1v-1h-1v1zM9 13h1v-1h-1v1zM9 9h1v-1h-1v1zM9 11h1v-1h-1v1zM9 5h1v-1h-1v1zM9 7h1v-1h-1v1zM9 3h1v-1h-1v1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
