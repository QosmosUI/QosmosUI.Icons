// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMarkEmailRead : ComponentBase
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
		builder.OpenElement(14, "g");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "fill", "none");
		builder.AddAttribute(17, "height", "24");
		builder.AddAttribute(18, "width", "24");
		builder.AddAttribute(19, "x", "0");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M18.05,21.29c-0.39,0.39-1.02,0.39-1.41,0l-2.12-2.12c-0.39-0.39-0.39-1.02,0-1.41h0c0.39-0.39,1.02-0.39,1.41,0 l1.41,1.41l3.54-3.54c0.39-0.39,1.02-0.39,1.41,0l0,0c0.39,0.39,0.39,1.02,0,1.41L18.05,21.29z M12.08,20H4c-1.1,0-2-0.9-2-2V6 c0-1.1,0.9-2,2-2h16c1.1,0,2,0.9,2,2v6.68C21.09,12.25,20.08,12,19,12c-3.87,0-7,3.13-7,7C12,19.34,12.03,19.67,12.08,20z M11.47,12.67c0.32,0.2,0.74,0.2,1.06,0l7.07-4.42C19.85,8.09,20,7.82,20,7.53c0-0.67-0.73-1.07-1.3-0.72L12,11L5.3,6.81 C4.73,6.46,4,6.86,4,7.53c0,0.29,0.15,0.56,0.4,0.72L11.47,12.67z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
