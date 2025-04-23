// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneTireRepair : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M19,8c-0.55,0-1-0.45-1-1c0-0.28,0.11-0.53,0.29-0.71c0.4-0.4,2.46-1.04,2.46-1.04s-0.64,2.06-1.04,2.46 C19.53,7.89,19.28,8,19,8z M20,13v5c0,1.65-1.35,3-3,3s-3-1.35-3-3v-2c0-0.55-0.45-1-1-1s-1,0.45-1,1v3c0,1.1-0.9,2-2,2H4 c-1.1,0-2-0.9-2-2V5c0-1.1,0.9-2,2-2h6c1.1,0,2,0.9,2,2v8.17c0.31-0.11,0.65-0.17,1-0.17c1.65,0,3,1.35,3,3v2c0,0.55,0.45,1,1,1 s1-0.45,1-1v-5h-1l0-1.42c-1.77-0.77-3-2.53-3-4.58c0-2.76,2.24-5,5-5s5,2.24,5,5c0,2.05-1.23,3.81-3,4.58L21,13H20z M22,7 c0-1.66-1.34-3-3-3s-3,1.34-3,3s1.34,3,3,3S22,8.66,22,7z M10,7L8,9V6.17L9.17,5H4.83L6,6.17V9L4,7v2.17l2,2V14l-2-2v2.17l2,2V19 l-2-2v2h6v-2l-2,2v-2.83l2-2V12l-2,2v-2.83l2-2V7z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M10,7L8,9V6.17L9.17,5H4.83L6,6.17V9L4,7v2.17l2,2V14l-2-2v2.17l2,2V19l-2-2v2h6v-2l-2,2v-2.83l2-2V12l-2,2 v-2.83l2-2V7z M19,4c-1.66,0-3,1.34-3,3s1.34,3,3,3s3-1.34,3-3S20.66,4,19,4z M19.71,7.71C19.53,7.89,19.28,8,19,8 c-0.55,0-1-0.45-1-1c0-0.28,0.11-0.53,0.29-0.71c0.4-0.4,2.46-1.04,2.46-1.04S20.11,7.31,19.71,7.71z");
		builder.AddAttribute(23, "opacity", ".3");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
