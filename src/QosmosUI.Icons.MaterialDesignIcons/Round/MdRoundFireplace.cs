// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFireplace : ComponentBase
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
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M20,2H4C2.9,2,2,2.9,2,4v16c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V4C22,2.9,21.1,2,20,2z M20,19c0,0.55-0.45,1-1,1h-1v-1 c0-0.55-0.45-1-1-1h-1.15c0.71-0.85,1.15-1.89,1.15-3c0-1.89-1.09-2.84-1.85-3.36c-1.86-1.27-2.23-2.78-2.25-3.72 c-0.01-0.4-0.43-0.63-0.77-0.43c-5.8,3.43-5.15,7-5.13,7.51c0.03,0.96,0.49,2.07,1.24,3H7c-0.55,0-1,0.45-1,1v1H5 c-0.55,0-1-0.45-1-1V5c0-0.55,0.45-1,1-1h14c0.55,0,1,0.45,1,1V19z M13.2,13.74c-0.08-0.46-0.07-0.85,0.08-1.28 c0.54,1.21,2.15,1.64,1.98,3.18c-0.19,1.69-2.11,2.37-3.39,1.32c0.76-0.24,1.4-1.04,1.53-1.63C13.52,14.78,13.29,14.29,13.2,13.74z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
