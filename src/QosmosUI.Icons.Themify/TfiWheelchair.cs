// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiWheelchair : ComponentBase
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
		builder.AddAttribute(15, "d", "M10.901 12.85l0.977 0.213c-0.505 2.318-2.511 3.937-4.878 3.937-2.757 0-5-2.243-5-5 0-2.27 1.531-4.259 3.725-4.836l0.254 0.967c-1.754 0.462-2.979 2.053-2.979 3.869 0 2.206 1.794 4 4 4 1.893 0 3.497-1.295 3.901-3.15zM16 15.121v1h-1.868l-0.955-4.118h-6.158l-0.544-8.082c-0.847-0.233-1.475-1.001-1.475-1.921 0-1.103 0.897-2 2-2s2 0.897 2 2c0 0.938-0.65 1.72-1.521 1.936l0.27 4.011 3.632-0.901 0.24 0.971-3.805 0.943 0.138 2.042h6.018l0.955 4.118h1.073zM7 3c0.552 0 1-0.449 1-1s-0.448-1-1-1-1 0.449-1 1 0.448 1 1 1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
