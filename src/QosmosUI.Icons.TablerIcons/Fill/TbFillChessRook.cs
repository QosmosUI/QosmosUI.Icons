// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillChessRook : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M14 3a1 1 0 0 1 .993 .883l.007 .117v2h1.652l.362 -2.164a1 1 0 0 1 1.034 -.836l.116 .013a1 1 0 0 1 .836 1.035l-.013 .116l-.5 3a1 1 0 0 1 -.865 .829l-.122 .007h-1.383l.877 7.89a1 1 0 0 1 -.877 1.103l-.117 .007h-8a1 1 0 0 1 -1 -.993l.006 -.117l.877 -7.89h-1.383a1 1 0 0 1 -.96 -.718l-.026 -.118l-.5 -3a1 1 0 0 1 1.947 -.442l.025 .114l.361 2.164h1.653v-2a1 1 0 0 1 1.993 -.117l.007 .117v2h2v-2a1 1 0 0 1 1 -1z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M18 18h-12a1 1 0 0 0 -1 1a2 2 0 0 0 2 2h10a2 2 0 0 0 1.987 -1.768l.011 -.174a1 1 0 0 0 -.998 -1.058z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
