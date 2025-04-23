// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHtml : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M21,15c-0.55,0-1-0.45-1-1V9.75C20,9.34,20.34,9,20.75,9s0.75,0.34,0.75,0.75v3.75h1.75c0.41,0,0.75,0.34,0.75,0.75 c0,0.41-0.34,0.75-0.75,0.75H21z M16,10.49h1v3.76c0,0.41,0.34,0.75,0.75,0.75s0.75-0.34,0.75-0.75V10c0-0.55-0.45-1-1-1H13 c-0.55,0-1,0.45-1,1v4.25c0,0.41,0.34,0.75,0.75,0.75s0.75-0.34,0.75-0.75V10.5h1v2.75c0,0.41,0.34,0.75,0.75,0.75 S16,13.66,16,13.25V10.49z M5,9.75C5,9.34,4.66,9,4.25,9S3.5,9.34,3.5,9.75V11h-2V9.75C1.5,9.34,1.16,9,0.75,9S0,9.34,0,9.75v4.5 C0,14.66,0.34,15,0.75,15s0.75-0.34,0.75-0.75V12.5h2v1.75C3.5,14.66,3.84,15,4.25,15S5,14.66,5,14.25V9.75z M10.25,10.5 c0.41,0,0.75-0.34,0.75-0.75C11,9.34,10.66,9,10.25,9h-3.5C6.34,9,6,9.34,6,9.75c0,0.41,0.34,0.75,0.75,0.75h1v3.75 C7.75,14.66,8.09,15,8.5,15s0.75-0.34,0.75-0.75V10.5H10.25z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
