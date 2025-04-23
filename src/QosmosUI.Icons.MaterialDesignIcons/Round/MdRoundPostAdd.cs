// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPostAdd : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M18,12c-0.55,0-1,0.45-1,1v5.22c0,0.55-0.45,1-1,1H6c-0.55,0-1-0.45-1-1V8c0-0.55,0.45-1,1-1h5c0.55,0,1-0.45,1-1 c0-0.55-0.45-1-1-1H5C3.9,5,3,5.9,3,7v12c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2v-6C19,12.45,18.55,12,18,12z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M21.02,5H19V2.98C19,2.44,18.56,2,18.02,2h-0.03C17.44,2,17,2.44,17,2.98V5h-2.01C14.45,5,14.01,5.44,14,5.98 c0,0.01,0,0.02,0,0.03C14,6.56,14.44,7,14.99,7H17v2.01c0,0.54,0.44,0.99,0.99,0.98c0.01,0,0.02,0,0.03,0 c0.54,0,0.98-0.44,0.98-0.98V7h2.02C21.56,7,22,6.56,22,6.02V5.98C22,5.44,21.56,5,21.02,5z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M14,9H8c-0.55,0-1,0.45-1,1c0,0.55,0.45,1,1,1h6c0.55,0,1-0.45,1-1C15,9.45,14.55,9,14,9z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M14,12H8c-0.55,0-1,0.45-1,1c0,0.55,0.45,1,1,1h6c0.55,0,1-0.45,1-1C15,12.45,14.55,12,14,12z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M14,15H8c-0.55,0-1,0.45-1,1c0,0.55,0.45,1,1,1h6c0.55,0,1-0.45,1-1C15,15.45,14.55,15,14,15z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
