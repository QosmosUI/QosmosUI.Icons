// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaDrum : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M501.2 76.1c11.1-7.3 14.2-22.1 6.9-33.2s-22.1-14.2-33.2-6.9L370.2 104.5C335.8 98.7 297 96 256 96C114.6 96 0 128 0 208L0 368c0 31.3 27.4 58.8 72 78.7L72 344c0-13.3 10.7-24 24-24s24 10.7 24 24l0 119.4c33 8.9 71.1 14.5 112 16.1L232 376c0-13.3 10.7-24 24-24s24 10.7 24 24l0 103.5c40.9-1.6 79-7.2 112-16.1L392 344c0-13.3 10.7-24 24-24s24 10.7 24 24l0 102.7c44.6-19.9 72-47.4 72-78.7l0-160c0-41.1-30.2-69.5-78.8-87.4l67.9-44.5zM307.4 145.6l-64.6 42.3c-11.1 7.3-14.2 22.1-6.9 33.2s22.1 14.2 33.2 6.9l111.1-72.8c14.7 3.2 27.9 7 39.4 11.5C458.4 181.8 464 197.4 464 208c0 .8-2.7 17.2-46 35.9C379.1 260.7 322 272 256 272s-123.1-11.3-162-28.1C50.7 225.2 48 208.8 48 208c0-10.6 5.6-26.2 44.4-41.3C130.6 151.9 187.8 144 256 144c18 0 35.1 .5 51.4 1.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
