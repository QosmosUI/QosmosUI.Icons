// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRockingChair : ComponentBase
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
		builder.AddAttribute(14, "d", "M83.17 26.07c-11.25.51-21.18 2.68-32.21 4.71C63.09 96.45 76.78 159.4 100.2 219.5c88.3-13.2 182.1-25 259.8-34.1 2.2 8.5 10.4 14.6 22.2 14.6 13.6 0 26.4-8.3 24.7-18-2.6-14.5-17.9-19.1-29.4-17.7l-251.7 33.1C104.2 141.1 89.34 83.79 83.17 26.07zM362.9 202.9l-18.1 2.1 19.9 74.5c-61 14.2-123.1 24.6-187.1 29.5-13.8-25.5-26.5-51.3-37.8-77.4l-32.6 5c14.4 33.9 32.2 66.7 55 98.6 27.9 6.1 24 5 27.9 5.4 76.7-8.8 133-16.9 202.2-34.3-13.2-32.5-20.3-69.3-29.4-103.4zm37.4 119.9l-17.7 4.5 41.3 85c5.4-2.3 10.8-4.9 16.2-7.7zm-242 32.2l-15 76.7c5.6 1.9 11.3 3.7 17.2 5.4l15.7-80zM36.02 405.1l-8.42 16c139.9 73.9 290.2 98.2 456.8-.3l-9.2-15.4c-161.4 95.3-302.5 72-439.18-.3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
