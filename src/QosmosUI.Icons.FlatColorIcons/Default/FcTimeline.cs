// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcTimeline : ComponentBase
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
		builder.AddAttribute(14, "fill", "#3F51B5");
		builder.AddAttribute(15, "d", "M42,29H20.8c-0.5,0-1-0.2-1.4-0.6l-3.7-3.7c-0.4-0.4-0.4-1,0-1.4l3.7-3.7c0.4-0.4,0.9-0.6,1.4-0.6H42 c0.6,0,1,0.4,1,1v8C43,28.6,42.6,29,42,29z");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "9");
		builder.AddAttribute(18, "y", "6");
		builder.AddAttribute(19, "fill", "#CFD8DC");
		builder.AddAttribute(20, "width", "2");
		builder.AddAttribute(21, "height", "36");
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#90A4AE");
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "10");
		builder.AddAttribute(26, "cy", "10");
		builder.AddAttribute(27, "r", "3");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "10");
		builder.AddAttribute(30, "cy", "24");
		builder.AddAttribute(31, "r", "3");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "10");
		builder.AddAttribute(34, "cy", "38");
		builder.AddAttribute(35, "r", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "fill", "#448AFF");
		builder.AddAttribute(38, "d", "M34,43H20.8c-0.5,0-1-0.2-1.4-0.6l-3.7-3.7c-0.4-0.4-0.4-1,0-1.4l3.7-3.7c0.4-0.4,0.9-0.6,1.4-0.6H34 c0.6,0,1,0.4,1,1v8C35,42.6,34.6,43,34,43z");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "fill", "#00BCD4");
		builder.AddAttribute(41, "d", "M35,15H20.8c-0.5,0-1-0.2-1.4-0.6l-3.7-3.7c-0.4-0.4-0.4-1,0-1.4l3.7-3.7C19.8,5.2,20.3,5,20.8,5H35 c0.6,0,1,0.4,1,1v8C36,14.6,35.6,15,35,15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
