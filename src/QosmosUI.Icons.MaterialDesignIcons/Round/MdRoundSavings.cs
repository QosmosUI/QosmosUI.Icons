// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSavings : ComponentBase
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
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M19.83,7.5l-2.27-2.27c0.07-0.42,0.18-0.81,0.32-1.15c0.11-0.26,0.15-0.56,0.09-0.87C17.84,2.49,17.14,1.99,16.4,2 c-1.59,0.03-3,0.81-3.9,2l-5,0C4.46,4,2,6.46,2,9.5c0,2.25,1.37,7.48,2.08,10.04C4.32,20.4,5.11,21,6.01,21L8,21c1.1,0,2-0.9,2-2v0 h2v0c0,1.1,0.9,2,2,2l2.01,0c0.88,0,1.66-0.58,1.92-1.43l1.25-4.16l2.14-0.72c0.41-0.14,0.68-0.52,0.68-0.95V8.5c0-0.55-0.45-1-1-1 H19.83z M12,9H9C8.45,9,8,8.55,8,8v0c0-0.55,0.45-1,1-1h3c0.55,0,1,0.45,1,1v0C13,8.55,12.55,9,12,9z M16,11c-0.55,0-1-0.45-1-1 c0-0.55,0.45-1,1-1s1,0.45,1,1C17,10.55,16.55,11,16,11z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
