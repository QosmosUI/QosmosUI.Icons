// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiLayoutSidebarLeft : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 0h5v17h-5v-17zM7 17h1v-1h-1v1zM14.222 17h0.889v-1h-0.889v1zM12.444 17h0.889v-1h-0.889v1zM8.889 17h0.889v-1h-0.889v1zM10.667 17h0.889v-1h-0.889v1zM16 17h1v-1h-1v1zM16 3h1v-1h-1v1zM16 15h1v-1h-1v1zM16 7h1v-1h-1v1zM16 5h1v-1h-1v1zM16 9h1v-1h-1v1zM16 11h1v-1h-1v1zM16 13h1v-1h-1v1zM16 0v1h1v-1h-1zM14.223 1h0.889v-1h-0.889v1zM12.445 1h0.889v-1h-0.889v1zM10.667 1h0.889v-1h-0.889v1zM8.889 1h0.889v-1h-0.889v1zM7 1h1v-1h-1v1zM7 15h1v-1h-1v1zM7 13h1v-1h-1v1zM7 7h1v-1h-1v1zM7 11h1v-1h-1v1zM7 5h1v-1h-1v1zM7 3h1v-1h-1v1zM7 9h1v-1h-1v1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
