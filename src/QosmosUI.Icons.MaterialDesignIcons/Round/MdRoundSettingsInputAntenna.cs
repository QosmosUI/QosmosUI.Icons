// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSettingsInputAntenna : ComponentBase
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
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M12,5c-3.48,0-6.37,2.54-6.91,5.87c-0.1,0.59,0.39,1.13,1,1.13c0.49,0,0.9-0.36,0.98-0.85C7.48,8.79,9.53,7,12,7 s4.52,1.79,4.93,4.15c0.08,0.49,0.49,0.85,0.98,0.85c0.61,0,1.09-0.54,0.99-1.13C18.37,7.54,15.48,5,12,5z M13,14.29 c1.07-0.48,1.76-1.66,1.41-2.99c-0.22-0.81-0.87-1.47-1.68-1.7C11.04,9.12,9.5,10.38,9.5,12c0,1.02,0.62,1.9,1.5,2.29v3.3 l-2.71,2.7c-0.39,0.39-0.39,1.02,0,1.41c0.39,0.39,1.02,0.39,1.41,0l2.3-2.3l2.3,2.3c0.39,0.39,1.02,0.39,1.41,0s0.39-1.02,0-1.41 L13,17.59V14.29z M12,1C6.3,1,1.61,5.34,1.05,10.9C1,11.49,1.46,12,2.05,12c0.51,0,0.94-0.38,0.99-0.88C3.48,6.56,7.33,3,12,3 s8.52,3.56,8.96,8.12c0.05,0.5,0.48,0.88,0.99,0.88c0.59,0,1.06-0.51,1-1.1C22.39,5.34,17.7,1,12,1z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
