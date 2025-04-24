// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcDam : ComponentBase
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
		builder.AddAttribute(14, "fill", "#81D4FA");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "x", "24");
		builder.AddAttribute(17, "y", "28");
		builder.AddAttribute(18, "width", "18");
		builder.AddAttribute(19, "height", "14");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "6");
		builder.AddAttribute(22, "y", "10");
		builder.AddAttribute(23, "width", "12");
		builder.AddAttribute(24, "height", "32");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(25, "g");
		builder.AddAttribute(26, "fill", "#1976D2");
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M16,8h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2H8c0,1.1-0.9,2-2,2v2c1.2,0,2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4 s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4v-2C16.9,10,16,9.1,16,8z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M16,14h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2H8c0,1.1-0.9,2-2,2v2c1.2,0,2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4 s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4v-2C16.9,16,16,15.1,16,14z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M16,20h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2H8c0,1.1-0.9,2-2,2v2c1.2,0,2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4 s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4v-2C16.9,22,16,21.1,16,20z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M16,26h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2H8c0,1.1-0.9,2-2,2v2c1.2,0,2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4 s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4v-2C16.9,28,16,27.1,16,26z");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M16,32h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2H8c0,1.1-0.9,2-2,2v2c1.2,0,2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4 s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4v-2C16.9,34,16,33.1,16,32z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M16,38h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2H8c0,1.1-0.9,2-2,2v2c1.2,0,2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4 s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4v-2C16.9,40,16,39.1,16,38z");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M40,32h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2h-2c0,1.1-0.9,2-2,2v2 c1.2,0,2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4v-2 C40.9,34,40,33.1,40,32z");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M40,26h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2h-2c0,1.1-0.9,2-2,2v2 c1.2,0,2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4v-2 C40.9,28,40,27.1,40,26z");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M40,38h-2c0,1.1-0.9,2-2,2s-2-0.9-2-2h-2c0,1.1-0.9,2-2,2v2c1.2,0,2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4 s2.3-0.5,3-1.4c0.7,0.8,1.8,1.4,3,1.4v-2C40.9,40,40,39.1,40,38z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "fill", "#455A64");
		builder.AddAttribute(47, "d", "M25.1,9.2L31.5,42H18V6h3.2C23.1,6,24.8,7.4,25.1,9.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
