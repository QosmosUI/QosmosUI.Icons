// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpWifiTetheringOff : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M2.81,2.81L1.39,4.22l2.69,2.69C2.78,8.6,2,10.71,2,13c0,2.76,1.12,5.26,2.93,7.07l1.42-1.42C4.9,17.21,4,15.21,4,13 c0-1.75,0.57-3.35,1.51-4.66l1.43,1.43C6.35,10.7,6,11.81,6,13c0,1.66,0.68,3.15,1.76,4.24l1.42-1.42C8.45,15.1,8,14.11,8,13 c0-0.63,0.15-1.23,0.41-1.76l1.61,1.61c0,0.05-0.02,0.1-0.02,0.15c0,0.55,0.23,1.05,0.59,1.41C10.95,14.77,11.45,15,12,15 c0.05,0,0.1-0.01,0.16-0.02l7.62,7.62l1.41-1.41L2.81,2.81z M17.7,14.87C17.89,14.28,18,13.65,18,13c0-3.31-2.69-6-6-6 c-0.65,0-1.28,0.1-1.87,0.3l1.71,1.71C11.89,9,11.95,9,12,9c2.21,0,4,1.79,4,4c0,0.05,0,0.11-0.01,0.16L17.7,14.87z M12,5 c4.42,0,8,3.58,8,8c0,1.22-0.27,2.37-0.77,3.4l1.49,1.49C21.53,16.45,22,14.78,22,13c0-5.52-4.48-10-10-10 c-1.78,0-3.44,0.46-4.89,1.28l1.48,1.48C9.63,5.27,10.78,5,12,5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
