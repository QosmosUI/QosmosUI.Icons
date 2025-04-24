// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiTireIron : ComponentBase
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
		builder.AddAttribute(14, "d", "M180 34.39c-9.2.1-18.2 2.89-26.1 7.41-11.2 6.44-20.6 16.6-24 29.44L24.92 468.6l17.42 4.6L147.3 75.86c1.9-6.99 7.8-14.01 15.6-18.46 7.7-4.45 16.9-6.08 24-4.19l76.2 20.31 14.7 25.1 72.1 19.18L365 60.76l-72.1-19.19-3.2 1.86-22 12.69-76.2-20.29c-3.2-.86-6.5-1.31-9.7-1.42H180zM327 157.5c-88.4 0-160 71.6-160 160 0 88.5 71.6 160.1 160 160.1 88.5 0 160.1-71.6 160.1-160.1 0-88.4-71.6-160-160.1-160zm-.3 74a86.06 86.06 0 0 1 .3 0 86.06 86.06 0 0 1 86.1 86 86.06 86.06 0 0 1-86.1 86.1 86.06 86.06 0 0 1-86-86.1 86.06 86.06 0 0 1 85.7-86z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
