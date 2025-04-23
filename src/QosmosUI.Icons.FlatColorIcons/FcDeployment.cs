// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcDeployment : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#B0BEC5");
		builder.AddAttribute(15, "d", "M37,42H5V32h32c2.8,0,5,2.2,5,5v0C42,39.8,39.8,42,37,42z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#37474F");
		builder.AddAttribute(18, "d", "M10,34c-1.7,0-3,1.3-3,3s1.3,3,3,3s3-1.3,3-3S11.7,34,10,34z M10,38c-0.6,0-1-0.4-1-1c0-0.6,0.4-1,1-1 s1,0.4,1,1C11,37.6,10.6,38,10,38z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#37474F");
		builder.AddAttribute(21, "d", "M19,34c-1.7,0-3,1.3-3,3s1.3,3,3,3s3-1.3,3-3S20.7,34,19,34z M19,38c-0.6,0-1-0.4-1-1c0-0.6,0.4-1,1-1 s1,0.4,1,1C20,37.6,19.6,38,19,38z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#37474F");
		builder.AddAttribute(24, "d", "M37,34c-1.7,0-3,1.3-3,3s1.3,3,3,3s3-1.3,3-3S38.7,34,37,34z M37,38c-0.6,0-1-0.4-1-1c0-0.6,0.4-1,1-1 s1,0.4,1,1C38,37.6,37.6,38,37,38z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#37474F");
		builder.AddAttribute(27, "d", "M28,34c-1.7,0-3,1.3-3,3s1.3,3,3,3s3-1.3,3-3S29.7,34,28,34z M28,38c-0.6,0-1-0.4-1-1c0-0.6,0.4-1,1-1 s1,0.4,1,1C29,37.6,28.6,38,28,38z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#FF9800");
		builder.AddAttribute(30, "d", "M35,31H11c-1.1,0-2-0.9-2-2V7c0-1.1,0.9-2,2-2h24c1.1,0,2,0.9,2,2v22C37,30.1,36.1,31,35,31z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "fill", "#8A5100");
		builder.AddAttribute(33, "d", "M26.5,13h-7c-0.8,0-1.5-0.7-1.5-1.5v0c0-0.8,0.7-1.5,1.5-1.5h7c0.8,0,1.5,0.7,1.5,1.5v0 C28,12.3,27.3,13,26.5,13z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "fill", "#607D8B");
		builder.AddAttribute(36, "d", "M37,31H5v2h32c2.2,0,4,1.8,4,4s-1.8,4-4,4H5v2h32c3.3,0,6-2.7,6-6S40.3,31,37,31z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
