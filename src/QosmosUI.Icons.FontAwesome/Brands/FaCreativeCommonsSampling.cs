// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaCreativeCommonsSampling : ComponentBase
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
		builder.AddAttribute(14, "d", "M247.6 8C389.4 8 496 118.1 496 256c0 147.1-118.5 248-248.4 248C113.6 504 0 394.5 0 256 0 123.1 104.7 8 247.6 8zm.8 44.7C130.2 52.7 44.7 150.6 44.7 256c0 109.8 91.2 202.8 203.7 202.8 103.2 0 202.8-81.1 202.8-202.8.1-113.8-90.2-203.3-202.8-203.3zm3.6 53.2c2.8-.3 11.5 1 11.5 11.5l6.6 107.2 4.9-59.3c0-6 4.7-10.6 10.6-10.6 5.9 0 10.6 4.7 10.6 10.6 0 2.5-.5-5.7 5.7 81.5l5.8-64.2c.3-2.9 2.9-9.3 10.2-9.3 3.8 0 9.9 2.3 10.6 8.9l11.5 96.5 5.3-12.8c1.8-4.4 5.2-6.6 10.2-6.6h58v21.3h-50.9l-18.2 44.3c-3.9 9.9-19.5 9.1-20.8-3.1l-4-31.9-7.5 92.6c-.3 3-3 9.3-10.2 9.3-3 0-9.8-2.1-10.6-9.3 0-1.9.6 5.8-6.2-77.9l-5.3 72.2c-1.1 4.8-4.8 9.3-10.6 9.3-2.9 0-9.8-2-10.6-9.3 0-1.9.5 6.7-5.8-87.7l-5.8 94.8c0 6.3-3.6 12.4-10.6 12.4-5.2 0-10.6-4.1-10.6-12l-5.8-87.7c-5.8 92.5-5.3 84-5.3 85.9-1.1 4.8-4.8 9.3-10.6 9.3-3 0-9.8-2.1-10.6-9.3 0-.7-.4-1.1-.4-2.6l-6.2-88.6L182 348c-.7 6.5-6.7 9.3-10.6 9.3-5.8 0-9.6-4.1-10.6-8.9L149.7 272c-2 4-3.5 8.4-11.1 8.4H87.2v-21.3H132l13.7-27.9c4.4-9.9 18.2-7.2 19.9 2.7l3.1 20.4 8.4-97.9c0-6 4.8-10.6 10.6-10.6.5 0 10.6-.2 10.6 12.4l4.9 69.1 6.6-92.6c0-10.1 9.5-10.6 10.2-10.6.6 0 10.6.7 10.6 10.6l5.3 80.6 6.2-97.9c.1-1.1-.6-10.3 9.9-11.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
