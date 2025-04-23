// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaCreativeCommonsNcJp : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 496 512";

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
		builder.AddAttribute(14, "d", "M247.7 8C103.6 8 0 124.8 0 256c0 136.4 111.8 248 247.7 248C377.9 504 496 403.2 496 256 496 117.2 388.5 8 247.7 8zm.6 450.7c-112 0-203.6-92.5-203.6-202.7 0-21.1 3-41.2 9-60.3l127 56.5h-27.9v38.6h58.1l5.7 11.8v18.7h-63.8V360h63.8v56h61.7v-56h64.2v-35.7l81 36.1c-1.5 2.2-57.1 98.3-175.2 98.3zm87.6-137.3h-57.6v-18.7l2.9-5.6 54.7 24.3zm6.5-51.4v-17.8h-38.6l63-116H301l-43.4 96-23-10.2-39.6-85.7h-65.8l27.3 51-81.9-36.5c27.8-44.1 82.6-98.1 173.7-98.1 112.8 0 203 90 203 203.4 0 21-2.7 40.6-7.9 59l-101-45.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
