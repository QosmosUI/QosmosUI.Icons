// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAppRegistration : ComponentBase
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
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "12");
		builder.AddAttribute(22, "cy", "6");
		builder.AddAttribute(23, "r", "2");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "6");
		builder.AddAttribute(26, "cy", "18");
		builder.AddAttribute(27, "r", "2");
		builder.CloseElement();
		builder.OpenElement(28, "circle");
		builder.AddAttribute(29, "cx", "6");
		builder.AddAttribute(30, "cy", "12");
		builder.AddAttribute(31, "r", "2");
		builder.CloseElement();
		builder.OpenElement(32, "circle");
		builder.AddAttribute(33, "cx", "6");
		builder.AddAttribute(34, "cy", "6");
		builder.AddAttribute(35, "r", "2");
		builder.CloseElement();
		builder.OpenElement(36, "circle");
		builder.AddAttribute(37, "cx", "18");
		builder.AddAttribute(38, "cy", "6");
		builder.AddAttribute(39, "r", "2");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "d", "M11,18.07v1.43c0,0.28,0.22,0.5,0.5,0.5h1.4c0.13,0,0.26-0.05,0.35-0.15l5.83-5.83l-2.12-2.12l-5.81,5.81 C11.05,17.81,11,17.94,11,18.07z");
		builder.CloseElement();
		builder.OpenElement(42, "path");
		builder.AddAttribute(43, "d", "M12.03,14L14,12.03V12c0-1.1-0.9-2-2-2s-2,0.9-2,2s0.9,2,2,2H12.03z");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "d", "M20.85,11.56l-1.41-1.41c-0.2-0.2-0.51-0.2-0.71,0l-1.06,1.06l2.12,2.12l1.06-1.06C21.05,12.07,21.05,11.76,20.85,11.56z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
