// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdCloudySnowing : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M5,18c0,0.55,0.45,1,1,1s1-0.45,1-1s-0.45-1-1-1S5,17.45,5,18z M17,18c0,0.55,0.45,1,1,1s1-0.45,1-1s-0.45-1-1-1 S17,17.45,17,18z M8,22c0,0.55,0.45,1,1,1s1-0.45,1-1s-0.45-1-1-1S8,21.45,8,22z M11,18c0,0.55,0.45,1,1,1s1-0.45,1-1s-0.45-1-1-1 S11,17.45,11,18z M14,22c0,0.55,0.45,1,1,1s1-0.45,1-1s-0.45-1-1-1S14,21.45,14,22z M17.5,16h-10C4.47,16,2,13.53,2,10.5 c0-2.76,2.09-5.09,4.78-5.44C7.83,3.18,9.82,2,12,2c2.97,0,5.45,2.18,5.92,5.02C20.21,7.23,22,9.16,22,11.5 C22,13.98,19.98,16,17.5,16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
