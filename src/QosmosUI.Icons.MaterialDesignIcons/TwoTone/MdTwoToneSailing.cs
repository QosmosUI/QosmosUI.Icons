// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneSailing : ComponentBase
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
		builder.AddAttribute(18, "d", "M9,11.5H6.83L9,8.38V11.5z M15.38,5.24c1.42,1.52,2.88,3.72,3.41,6.26h-3.68c0.21-1.1,0.39-2.46,0.39-4 C15.5,6.71,15.45,5.95,15.38,5.24z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M11,13.5V2L3,13.5H11z M9,11.5H6.83L9,8.38V11.5z M21,13.5C21,6.5,14.5,1,12.5,1c0,0,1,3,1,6.5s-1,6-1,6H21z M15.38,5.24 c1.42,1.52,2.88,3.72,3.41,6.26h-3.68c0.21-1.1,0.39-2.46,0.39-4C15.5,6.71,15.45,5.95,15.38,5.24z M22,15H2 c0.31,1.53,1.16,2.84,2.33,3.73C4.98,18.46,5.55,18.01,6,17.5C6.73,18.34,7.8,19,9,19s2.27-0.66,3-1.5c0.73,0.84,1.8,1.5,3,1.5 s2.26-0.66,3-1.5c0.45,0.51,1.02,0.96,1.67,1.23C20.84,17.84,21.69,16.53,22,15z M22,23v-2h-1c-1.04,0-2.08-0.35-3-1 c-1.83,1.3-4.17,1.3-6,0c-1.83,1.3-4.17,1.3-6,0c-0.91,0.65-1.96,1-3,1H2l0,2h1c1.03,0,2.05-0.25,3-0.75c1.89,1,4.11,1,6,0 c1.89,1,4.11,1,6,0h0c0.95,0.5,1.97,0.75,3,0.75H22z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
