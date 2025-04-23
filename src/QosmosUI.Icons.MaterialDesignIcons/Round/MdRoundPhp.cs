// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPhp : ComponentBase
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
		builder.AddAttribute(24, "d", "M6.5,10.5h-2v1h2V10.5z M20,10.5h-2v1h2V10.5z M13,12.5h-2v1.75c0,0.41-0.34,0.75-0.75,0.75S9.5,14.66,9.5,14.25v-4.5 C9.5,9.34,9.84,9,10.25,9S11,9.34,11,9.75V11h2V9.75C13,9.34,13.34,9,13.75,9s0.75,0.34,0.75,0.75v4.5c0,0.41-0.34,0.75-0.75,0.75 S13,14.66,13,14.25V12.5z M18,14.25c0,0.41-0.34,0.75-0.75,0.75s-0.75-0.34-0.75-0.75V10c0-0.55,0.45-1,1-1H20 c0.83,0,1.5,0.68,1.5,1.5v1c0,0.82-0.67,1.5-1.5,1.5h-2V14.25z M3,10c0-0.55,0.45-1,1-1h2.5C7.33,9,8,9.68,8,10.5v1 C8,12.32,7.33,13,6.5,13h-2v1.25C4.5,14.66,4.16,15,3.75,15S3,14.66,3,14.25V10z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
