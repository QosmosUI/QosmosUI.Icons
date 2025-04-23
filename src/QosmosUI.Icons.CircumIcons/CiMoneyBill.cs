// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiMoneyBill : ComponentBase
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
		builder.AddAttribute(14, "id", "Money_Bill");
		builder.AddAttribute(15, "data-name", "Money Bill");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M19.44,5.78H4.56a2.507,2.507,0,0,0-2.5,2.5v7.44a2.514,2.514,0,0,0,2.5,2.5H19.44a2.507,2.507,0,0,0,2.5-2.5V8.28A2.5,2.5,0,0,0,19.44,5.78ZM3.06,8.28a1.5,1.5,0,0,1,1.5-1.5H6.04A3.521,3.521,0,0,1,3.06,9.76Zm1.5,8.94a1.511,1.511,0,0,1-1.5-1.5V14.24a3.521,3.521,0,0,1,2.98,2.98Zm16.38-1.5a1.5,1.5,0,0,1-1.5,1.5H17.96a3.521,3.521,0,0,1,2.98-2.98Zm0-2.49a4.528,4.528,0,0,0-3.99,3.99H7.05a4.528,4.528,0,0,0-3.99-3.99V10.77A4.528,4.528,0,0,0,7.05,6.78h9.9a4.528,4.528,0,0,0,3.99,3.99Zm0-3.47a3.521,3.521,0,0,1-2.98-2.98h1.48a1.5,1.5,0,0,1,1.5,1.5Z");
		builder.CloseElement();
		builder.OpenElement(19, "circle");
		builder.AddAttribute(20, "cx", "12.002");
		builder.AddAttribute(21, "cy", "11.998");
		builder.AddAttribute(22, "r", "2");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
