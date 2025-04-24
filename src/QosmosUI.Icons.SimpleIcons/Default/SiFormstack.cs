// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiFormstack : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M19,4.035h1.4c0.331,0,0.6,0.269,0.6,0.6v14.73c0,0.331-0.269,0.6-0.6,0.6H19V4.035z M22,6.026h1.4 c0.331,0,0.6,0.269,0.6,0.6v10.747c0,0.331-0.269,0.6-0.6,0.6H22V6.026z M0.6,2.044h16.8c0.331,0,0.6,0.269,0.6,0.6v18.712 c0,0.331-0.269,0.6-0.6,0.6H0.6c-0.331,0-0.6-0.269-0.6-0.6V2.644C0,2.313,0.269,2.044,0.6,2.044z M4.2,5.23 c-0.11,0-0.2,0.09-0.2,0.2v7.35c0,0.045,0.015,0.089,0.044,0.125c0.069,0.086,0.195,0.101,0.281,0.032l9.228-7.35 c0.048-0.038,0.075-0.096,0.075-0.156c0-0.11-0.09-0.2-0.2-0.2L4.2,5.23z M4,17.185c0,0.04,0.012,0.08,0.035,0.113 c0.062,0.091,0.187,0.114,0.278,0.052l7.576-5.184c0.054-0.037,0.087-0.099,0.087-0.165c0-0.11-0.09-0.2-0.2-0.2H6.89 c-0.045,0-0.088,0.015-0.123,0.042l-2.69,2.102C4.028,13.983,4,14.041,4,14.103L4,17.185z M4.086,18.342 C4.032,18.379,4,18.441,4,18.506v0.087c0,0.106,0.086,0.192,0.192,0.192H7c0.11,0,0.2-0.09,0.2-0.2v-2.022 c0-0.041-0.012-0.081-0.036-0.114c-0.063-0.091-0.188-0.113-0.278-0.05L4.086,18.342z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
