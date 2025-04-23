// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineDirtyLens : ComponentBase
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
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M20,5h-3.17L15,3H9L7.17,5H4C2.9,5,2,5.9,2,7v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V7C22,5.9,21.1,5,20,5z M20,19h-7.02 c-0.22-0.84-0.52-1.76-0.13-2.33c0.81-1.12,2.67,1.77,3.81-0.09c0.77-1.57-1.58-1.29-1.64-2.12c-0.05-0.84,3.68,0.17,3.04-1.66 c-0.61-1.73-2.42,0.48-2.76-0.53c-0.58-1.74,4.7-1.68,2.85-4.01c-1.76-2.22-2.47,2.85-4.41,2.33c-1.34-0.36-1.01-2.88-2.65-2.44 c-1.88,0.51,1.03,2.2,0,2.86c-0.96,0.63-1.72-0.92-2.51-1.19c-0.2-0.07-0.69-0.05-0.91,0.19c-0.78,0.86,0.28,1.16,0.25,1.91 c-0.02,0.75-1.59,0.49-1.51,1.49c0.12,1.6,2.18,0.45,2.4,1.24c0.55,1.98-1.89,2.15-0.5,3.27c1.53,0.71,1.91-1.94,2.8-1.35 c0.58,0.38,0.3,1.45,0.16,2.43H4V7h4.05l1.83-2h4.24l1.83,2H20V19z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M17.28,17.15c0,0.48,0.39,0.86,0.86,0.86c0.48,0,0.86-0.38,0.86-0.86s-0.39-0.86-0.86-0.86 C17.66,16.29,17.28,16.67,17.28,17.15z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
