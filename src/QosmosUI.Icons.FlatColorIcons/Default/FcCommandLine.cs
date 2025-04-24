// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcCommandLine : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "fill", "#CFD8DC");
		builder.AddAttribute(16, "d", "M41,6H7C6.4,6,6,6.4,6,7v35h36V7C42,6.4,41.6,6,41,6z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "rect");
		builder.AddAttribute(18, "x", "8");
		builder.AddAttribute(19, "y", "13");
		builder.AddAttribute(20, "fill", "#263238");
		builder.AddAttribute(21, "width", "32");
		builder.AddAttribute(22, "height", "27");
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "fill", "#76FF03");
		builder.AddAttribute(26, "d", "M22,27.6c-0.1,1.1-0.4,1.9-1,2.5c-0.6,0.6-1.4,0.9-2.5,0.9c-1.1,0-2-0.4-2.6-1.1c-0.6-0.7-0.9-1.8-0.9-3.1		v-1.6c0-1.3,0.3-2.4,0.9-3.1c0.6-0.7,1.5-1.1,2.6-1.1c1.1,0,1.9,0.3,2.5,0.9c0.6,0.6,0.9,1.4,1,2.6h-2c0-0.7-0.1-1.2-0.3-1.4		c-0.2-0.3-0.6-0.4-1.1-0.4c-0.5,0-0.9,0.2-1.2,0.6c-0.2,0.4-0.3,1-0.4,1.8v1.8c0,1,0.1,1.6,0.3,2c0.2,0.4,0.6,0.5,1.1,0.5		c0.5,0,0.9-0.1,1.1-0.4c0.2-0.3,0.3-0.7,0.3-1.4H22z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "fill", "#76FF03");
		builder.AddAttribute(29, "d", "M24,24c0-0.3,0.1-0.5,0.3-0.7c0.2-0.2,0.4-0.3,0.7-0.3c0.3,0,0.5,0.1,0.7,0.3c0.2,0.2,0.3,0.4,0.3,0.7		c0,0.3-0.1,0.5-0.3,0.7S25.3,25,25,25c-0.3,0-0.5-0.1-0.7-0.3S24,24.3,24,24z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "fill", "#76FF03");
		builder.AddAttribute(32, "d", "M24,30c0-0.3,0.1-0.5,0.3-0.7c0.2-0.2,0.4-0.3,0.7-0.3c0.3,0,0.5,0.1,0.7,0.3c0.2,0.2,0.3,0.4,0.3,0.7		c0,0.3-0.1,0.5-0.3,0.7S25.3,31,25,31c-0.3,0-0.5-0.1-0.7-0.3S24,30.3,24,30z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "fill", "#76FF03");
		builder.AddAttribute(35, "d", "M28,21h2l3,10h-2L28,21z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(36, "g");
		builder.OpenElement(37, "circle");
		builder.AddAttribute(38, "fill", "#90A4AE");
		builder.AddAttribute(39, "cx", "13.5");
		builder.AddAttribute(40, "cy", "9.5");
		builder.AddAttribute(41, "r", "1.5");
		builder.CloseElement();
		builder.OpenElement(42, "circle");
		builder.AddAttribute(43, "fill", "#90A4AE");
		builder.AddAttribute(44, "cx", "9.5");
		builder.AddAttribute(45, "cy", "9.5");
		builder.AddAttribute(46, "r", "1.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
