// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundTungsten : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M12,19L12,19c-0.56,0-1,0.45-1,1V21c0,0.55,0.45,1,1,1H12c0.55,0,1-0.45,1-1V20C13,19.45,12.55,19,12,19z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M5.99,17.09L5.28,17.8c-0.39,0.39-0.39,1.02,0,1.41c0.39,0.39,1.02,0.39,1.41,0l0.71-0.71c0.39-0.39,0.39-1.02,0-1.41 C7.02,16.71,6.38,16.71,5.99,17.09z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M5,12c0-0.55-0.45-1-1-1H3c-0.55,0-1,0.45-1,1V12c0,0.55,0.45,1,1,1H4C4.55,13,5,12.55,5,12L5,12z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M21,11H20c-0.55,0-1,0.45-1,1V12c0,0.55,0.45,1,1,1H21c0.55,0,1-0.45,1-1V12C22,11.45,21.55,11,21,11z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M18.01,17.09c-0.39-0.39-1.02-0.39-1.41,0c-0.39,0.39-0.39,1.02,0,1.41l0.71,0.71c0.39,0.39,1.02,0.39,1.41,0 c0.39-0.39,0.39-1.02,0-1.41L18.01,17.09z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M15,8.02V5c0-1.1-0.9-2-2-2h-2C9.9,3,9,3.9,9,5v3.02c-1.43,1.08-2.28,2.9-1.91,4.91c0.36,1.95,1.9,3.55,3.84,3.95 C14.16,17.56,17,15.11,17,12C17,10.37,16.21,8.94,15,8.02z M13,7.1C12.68,7.04,12.34,7,12,7s-0.68,0.04-1,0.1V5h2V7.1z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
