// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundGrass : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M15.64,11.02c0.55-1.47,1.43-2.78,2.56-3.83c0.38-0.36,0.04-1-0.46-0.85c-3.32,0.98-5.75,4.05-5.74,7.69c0,0,0,0,0,0 C12.95,12.75,14.2,11.72,15.64,11.02z M11.42,8.85c-0.6-1.56-1.63-2.91-2.96-3.87C8.04,4.68,7.5,5.17,7.74,5.63 C8.54,7.15,9,8.88,9,10.71c0,0.21-0.03,0.41-0.04,0.61c0.43,0.24,0.83,0.52,1.22,0.82C10.39,10.96,10.83,9.85,11.42,8.85z M12,20H3 c-0.55,0-1-0.45-1-1s0.45-1,1-1h4.75c-0.57-2.19-2.04-4.02-4-5.06l0,0c-0.16-0.08-0.26-0.25-0.26-0.44c0-0.27,0.22-0.49,0.49-0.5 c0.01,0,0.02,0,0.02,0C8.42,12,12,15.58,12,20z M20.26,12.94L20.26,12.94c-1.96,1.04-3.44,2.87-4,5.06H21c0.55,0,1,0.45,1,1 s-0.45,1-1,1h-5h-2c0-0.68-0.07-1.35-0.2-2c-0.15-0.72-0.38-1.42-0.67-2.07C14.52,13.58,17.07,12,20,12c0.01,0,0.02,0,0.02,0 c0.27,0,0.49,0.23,0.49,0.5C20.52,12.69,20.41,12.85,20.26,12.94z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
