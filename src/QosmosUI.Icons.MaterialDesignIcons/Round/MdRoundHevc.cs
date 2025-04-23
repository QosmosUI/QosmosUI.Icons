// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHevc : ComponentBase
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
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M6.25,9C5.84,9,5.5,9.34,5.5,9.75V11h-1V9.75C4.5,9.34,4.16,9,3.75,9S3,9.34,3,9.75v4.5C3,14.66,3.34,15,3.75,15 s0.75-0.34,0.75-0.75V12.5h1v1.75C5.5,14.66,5.84,15,6.25,15S7,14.66,7,14.25v-4.5C7,9.34,6.66,9,6.25,9z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M10.75,10.5c0.41,0,0.75-0.34,0.75-0.75C11.5,9.34,11.16,9,10.75,9H9c-0.55,0-1,0.45-1,1v4c0,0.55,0.45,1,1,1h1.75 c0.41,0,0.75-0.34,0.75-0.75c0-0.41-0.34-0.75-0.75-0.75H9.5v-1h1.25c0.41,0,0.75-0.34,0.75-0.75c0-0.41-0.34-0.75-0.75-0.75H9.5 v-0.5H10.75z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M15.63,9c-0.36,0-0.67,0.26-0.73,0.62l-0.65,3.88L13.6,9.62C13.54,9.26,13.23,9,12.87,9c-0.46,0-0.8,0.41-0.73,0.86 l0.65,3.91c0.12,0.71,0.73,1.23,1.46,1.23s1.34-0.52,1.46-1.23l0.65-3.91C16.43,9.41,16.08,9,15.63,9z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M19.5,10.5c0,0.28,0.22,0.5,0.5,0.5h0.5c0.28,0,0.5-0.22,0.5-0.5V10c0-0.55-0.45-1-1-1h-2c-0.55,0-1,0.45-1,1v4 c0,0.55,0.45,1,1,1h2c0.55,0,1-0.45,1-1v-0.5c0-0.28-0.22-0.5-0.5-0.5H20c-0.28,0-0.5,0.22-0.5,0.5h-1v-3H19.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
