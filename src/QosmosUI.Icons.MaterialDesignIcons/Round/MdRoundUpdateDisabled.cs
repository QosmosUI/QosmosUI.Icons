// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundUpdateDisabled : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M20.49,20.49L3.51,3.51c-0.39-0.39-1.02-0.39-1.41,0l0,0c-0.39,0.39-0.39,1.02,0,1.41l2.31,2.31 C3.57,8.56,3.05,10.09,3,11.74C2.86,16.83,6.94,21,12,21c1.76,0,3.39-0.52,4.78-1.39l2.29,2.29c0.39,0.39,1.02,0.39,1.41,0l0,0 C20.88,21.51,20.88,20.88,20.49,20.49z M10.72,18.89c-2.78-0.49-5.04-2.71-5.58-5.47c-0.34-1.72-0.03-3.36,0.72-4.73l9.46,9.46 C13.98,18.87,12.4,19.18,10.72,18.89z M13,8v2.17l-2-2V8c0-0.55,0.45-1,1-1S13,7.45,13,8z M20.72,14.23 c-0.23,0.92-0.61,1.77-1.1,2.55l-1.47-1.47c0.27-0.5,0.49-1.03,0.63-1.59C18.89,13.3,19.29,13,19.73,13h0 C20.38,13,20.88,13.61,20.72,14.23z M7.24,4.41c1.46-0.93,3.18-1.45,5-1.41c2.65,0.07,5,1.28,6.6,3.16l1.31-1.31 C20.46,4.54,21,4.76,21,5.21V9.5c0,0.28-0.22,0.5-0.5,0.5h-4.29c-0.45,0-0.67-0.54-0.35-0.85l1.55-1.55C16.12,6.02,14.18,5,12,5 c-1.2,0-2.33,0.31-3.32,0.85L7.24,4.41z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
