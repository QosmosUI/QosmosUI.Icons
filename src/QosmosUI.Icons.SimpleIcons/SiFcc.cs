// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiFcc : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M21.412 17.587A7.89 7.89 0 0 1 10.268 6.414a7.867 7.867 0 0 1 11.144 0 8 8 0 0 1 .839.996L24 6.116a10.03 10.03 0 0 0-8.16-4.196c-5.19 0-9.458 3.942-9.996 9.002h-3.82V4.328H6.78L8.508 1.92H0v20.16l2.024-1.488V13.08h3.82c.538 5.059 4.806 9 9.996 9A10.03 10.03 0 0 0 24 17.884l-1.749-1.296a8 8 0 0 1-.84.999m-5.57-9.205a3.61 3.61 0 0 1 2.97 1.572l1.752-1.296a5.77 5.77 0 0 0-4.723-2.456c-3.194 0-5.782 2.595-5.782 5.798s2.588 5.796 5.782 5.797a5.77 5.77 0 0 0 4.723-2.455l-1.751-1.296a3.61 3.61 0 1 1-2.972-5.664");
		builder.CloseElement();
		builder.CloseElement();
    }
}
