// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiPen : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Pen");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M20.235,11.284a2.3,2.3,0,0,0-3.01-.149L15.444,5.744a2.484,2.484,0,0,0-2.1-1.7l-8.581-.93A1.5,1.5,0,0,0,3.115,4.765l.93,8.579a2.479,2.479,0,0,0,1.7,2.1l5.39,1.77a2.258,2.258,0,0,0-.51,1.43,2.257,2.257,0,0,0,2.25,2.25,2.263,2.263,0,0,0,1.591-.661l5.77-5.769a2.249,2.249,0,0,0,0-3.181Zm-14.18,3.21a1.5,1.5,0,0,1-1.02-1.26l-.9-8.39,4.01,4.01a1.188,1.188,0,0,0,.281,1.221,1.167,1.167,0,1,0,1.649-1.651,1.143,1.143,0,0,0-1.209-.269l-4.02-4.02,8.39.9a1.476,1.476,0,0,1,1.259,1.02l1.931,5.86-4.51,4.51Zm11.709-2.51a1.25,1.25,0,0,1,2.13.891,1.237,1.237,0,0,1-.369.88l-5.771,5.77a1.277,1.277,0,0,1-1.769,0,1.253,1.253,0,0,1,0-1.76Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
