// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoPasskeyFill : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M9.496 2a5.25 5.25 0 0 0-2.519 9.857A9.006 9.006 0 0 0 .5 20.228a.751.751 0 0 0 .728.772h5.257c3.338.001 6.677.002 10.015 0a.5.5 0 0 0 .5-.5v-4.669a.95.95 0 0 0-.171-.551 9.02 9.02 0 0 0-4.814-3.423A5.25 5.25 0 0 0 9.496 2Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M23.625 10.313c0 1.31-.672 2.464-1.691 3.134a.398.398 0 0 0-.184.33v.886a.372.372 0 0 1-.11.265l-.534.534a.188.188 0 0 0 0 .265l.534.534c.071.07.11.166.11.265v.347a.374.374 0 0 1-.11.265l-.534.534a.188.188 0 0 0 0 .265l.534.534a.37.37 0 0 1 .11.265v.431a.379.379 0 0 1-.097.253l-1.2 1.319a.781.781 0 0 1-1.156 0l-1.2-1.319a.379.379 0 0 1-.097-.253v-5.39a.398.398 0 0 0-.184-.33 3.75 3.75 0 1 1 5.809-3.134ZM21 9.75a1.125 1.125 0 1 0-2.25 0 1.125 1.125 0 0 0 2.25 0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
