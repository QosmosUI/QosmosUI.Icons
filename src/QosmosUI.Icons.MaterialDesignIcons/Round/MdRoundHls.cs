// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHls : ComponentBase
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
		builder.AddAttribute(24, "d", "M10.75,9C10.34,9,10,9.34,10,9.75V14c0,0.55,0.45,1,1,1h2.25c0.41,0,0.75-0.34,0.75-0.75s-0.34-0.75-0.75-0.75H11.5V9.75 C11.5,9.34,11.16,9,10.75,9z M19.04,10.5c0.1,0.29,0.38,0.5,0.71,0.5c0.41,0,0.75-0.34,0.75-0.75V10c0-0.55-0.45-1-1-1h-3 c-0.55,0-1,0.45-1,1v1.5c0,0.55,0.45,1,1,1H19v1h-2.04v0c-0.1-0.29-0.38-0.5-0.71-0.5c-0.41,0-0.75,0.34-0.75,0.75V14 c0,0.55,0.45,1,1,1h3c0.55,0,1-0.45,1-1v-1.5c0-0.55-0.45-1-1-1H17v-1L19.04,10.5z M8,9.75C8,9.34,7.66,9,7.25,9S6.5,9.34,6.5,9.75 V11h-2V9.75C4.5,9.34,4.16,9,3.75,9S3,9.34,3,9.75v4.5C3,14.66,3.34,15,3.75,15s0.75-0.34,0.75-0.75V12.5h2v1.75 C6.5,14.66,6.84,15,7.25,15S8,14.66,8,14.25V9.75z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
