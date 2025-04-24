// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiBurger : ComponentBase
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
		builder.AddAttribute(14, "id", "Burger");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M19.325,11.015a7.344,7.344,0,0,0-14.66,0,2.014,2.014,0,0,0-1.6,1.96v.16a2.016,2.016,0,0,0,1.64,1.97l.27,2.45a2.593,2.593,0,0,0,2.59,2.32h8.87a2.593,2.593,0,0,0,2.59-2.32l.27-2.45a2.016,2.016,0,0,0,1.64-1.97v-.16A2,2,0,0,0,19.325,11.015ZM12,5.125a6.365,6.365,0,0,1,6.34,5.85H5.665A6.362,6.362,0,0,1,12,5.125Zm6.04,12.32a1.6,1.6,0,0,1-1.6,1.43H7.565a1.6,1.6,0,0,1-1.6-1.43l-.26-2.31H18.3Zm1.9-4.31a1,1,0,0,1-1,1H5.065a1,1,0,0,1-1-1v-.16a1,1,0,0,1,1-1h13.87a1,1,0,0,1,1,1Z");
		builder.CloseElement();
		builder.OpenElement(18, "circle");
		builder.AddAttribute(19, "cx", "12");
		builder.AddAttribute(20, "cy", "6.622");
		builder.AddAttribute(21, "r", "0.5");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "8.323");
		builder.AddAttribute(24, "cy", "8.323");
		builder.AddAttribute(25, "r", "0.5");
		builder.CloseElement();
		builder.OpenElement(26, "circle");
		builder.AddAttribute(27, "cx", "15.676");
		builder.AddAttribute(28, "cy", "8.323");
		builder.AddAttribute(29, "r", "0.5");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
