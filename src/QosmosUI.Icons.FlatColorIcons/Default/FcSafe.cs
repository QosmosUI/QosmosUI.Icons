// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcSafe : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "8");
		builder.AddAttribute(15, "y", "39");
		builder.AddAttribute(16, "fill", "#455A64");
		builder.AddAttribute(17, "width", "6");
		builder.AddAttribute(18, "height", "3");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "34");
		builder.AddAttribute(21, "y", "39");
		builder.AddAttribute(22, "fill", "#455A64");
		builder.AddAttribute(23, "width", "6");
		builder.AddAttribute(24, "height", "3");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "#78909C");
		builder.AddAttribute(27, "d", "M40,41H8c-2.2,0-4-1.8-4-4V11c0-2.2,1.8-4,4-4h32c2.2,0,4,1.8,4,4v26C44,39.2,42.2,41,40,41z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill", "#90A4AE");
		builder.AddAttribute(30, "d", "M40,38H8c-0.6,0-1-0.4-1-1V11c0-0.6,0.4-1,1-1h32c0.6,0,1,0.4,1,1v26C41,37.6,40.6,38,40,38z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "fill", "#37474F");
		builder.AddAttribute(33, "d", "M29,14c-5.5,0-10,4.5-10,10c0,5.5,4.5,10,10,10s10-4.5,10-10C39,18.5,34.5,14,29,14z M29,31 c-3.9,0-7-3.1-7-7c0-3.9,3.1-7,7-7s7,3.1,7,7C36,27.9,32.9,31,29,31z");
		builder.CloseElement();
		builder.OpenElement(34, "g");
		builder.AddAttribute(35, "fill", "#B0BEC5");
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M35.3,19.1l0.4-0.4c0.4-0.4,0.4-1,0-1.4s-1-0.4-1.4,0l-0.4,0.4C34.4,18.1,34.9,18.6,35.3,19.1z");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M22.7,19.1c0.4-0.5,0.9-1,1.4-1.4l-0.4-0.4c-0.4-0.4-1-0.4-1.4,0s-0.4,1,0,1.4L22.7,19.1z");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M21,24c0-0.3,0-0.7,0.1-1h-0.6c-0.6,0-1,0.4-1,1s0.4,1,1,1h0.6C21,24.7,21,24.3,21,24z");
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M29,16c0.3,0,0.7,0,1,0.1v-0.6c0-0.6-0.4-1-1-1s-1,0.4-1,1v0.6C28.3,16,28.7,16,29,16z");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "d", "M35.3,28.9c-0.4,0.5-0.9,1-1.4,1.4l0.4,0.4c0.2,0.2,0.5,0.3,0.7,0.3s0.5-0.1,0.7-0.3c0.4-0.4,0.4-1,0-1.4 L35.3,28.9z");
		builder.CloseElement();
		builder.OpenElement(46, "path");
		builder.AddAttribute(47, "d", "M22.7,28.9l-0.4,0.4c-0.4,0.4-0.4,1,0,1.4c0.2,0.2,0.5,0.3,0.7,0.3s0.5-0.1,0.7-0.3l0.4-0.4 C23.6,29.9,23.1,29.4,22.7,28.9z");
		builder.CloseElement();
		builder.OpenElement(48, "path");
		builder.AddAttribute(49, "d", "M37.5,23h-0.6c0,0.3,0.1,0.7,0.1,1s0,0.7-0.1,1h0.6c0.6,0,1-0.4,1-1S38.1,23,37.5,23z");
		builder.CloseElement();
		builder.OpenElement(50, "path");
		builder.AddAttribute(51, "d", "M29,32c-0.3,0-0.7,0-1-0.1v0.6c0,0.6,0.4,1,1,1s1-0.4,1-1v-0.6C29.7,32,29.3,32,29,32z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(52, "path");
		builder.AddAttribute(53, "fill", "#455A64");
		builder.AddAttribute(54, "d", "M12,20c-1.1,0-2,0.9-2,2v8c0,1.1,0.9,2,2,2s2-0.9,2-2v-8C14,20.9,13.1,20,12,20z");
		builder.CloseElement();
		builder.OpenElement(55, "path");
		builder.AddAttribute(56, "fill", "#CFD8DC");
		builder.AddAttribute(57, "d", "M12,18c-1.1,0-2,0.9-2,2v8c0,1.1,0.9,2,2,2s2-0.9,2-2v-8C14,18.9,13.1,18,12,18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
