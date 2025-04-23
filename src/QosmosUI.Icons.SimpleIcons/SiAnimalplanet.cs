// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAnimalplanet : ComponentBase
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
		builder.AddAttribute(15, "d", "m18.814 5.94-.494.858c2.605.509 4.118 1.618 4.118 2.917 0 .865-.649 1.696-1.762 1.696-1.699 0-2.949-2.673-2.949-2.673-.356-.011-.993-.026-.993-.026s-1.822-2.342-4.595-3.168v3.798c.244.205.559.499.855.863-1.252-.757-2.552-1.317-4.847-1.317-2.496 0-5.547 1.007-7.242 3.763l.178.322c.773-.873 1.968-1.402 2.006-1.416C1.424 13.012.469 15.427 0 16.998l1.456 1.457a10.687 10.687 0 0 1 8.055-3.588c2.77 0 5.582 1.157 7.534 3.157l1.577-1.579c-1.324-2.263-2.924-3.861-2.972-3.909.068.031 1.487.85 3.975.85 2.312 0 4.375-1.285 4.375-3.203 0-2.292-1.965-3.745-5.186-4.243");
		builder.CloseElement();
		builder.CloseElement();
    }
}
