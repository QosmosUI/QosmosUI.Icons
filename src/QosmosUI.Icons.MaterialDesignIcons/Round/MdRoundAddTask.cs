// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAddTask : ComponentBase
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
		builder.AddAttribute(18, "d", "M21.29,5.89l-10,10c-0.39,0.39-1.02,0.39-1.41,0l-2.83-2.83c-0.39-0.39-0.39-1.02,0-1.41l0,0c0.39-0.39,1.02-0.39,1.41,0 l2.12,2.12l9.29-9.29c0.39-0.39,1.02-0.39,1.41,0v0C21.68,4.87,21.68,5.5,21.29,5.89z M12,20c-4.71,0-8.48-4.09-7.95-8.9 c0.39-3.52,3.12-6.41,6.61-6.99c1.81-0.3,3.53,0.02,4.99,0.78c0.39,0.2,0.86,0.13,1.17-0.18l0,0c0.48-0.48,0.36-1.29-0.24-1.6 C15.11,2.36,13.45,1.95,11.68,2c-5.14,0.16-9.41,4.34-9.67,9.47C1.72,17.24,6.3,22,12,22c1.2,0,2.34-0.21,3.41-0.6 c0.68-0.25,0.87-1.13,0.35-1.65l0,0c-0.27-0.27-0.68-0.37-1.04-0.23C13.87,19.83,12.95,20,12,20z M19,15h-2c-0.55,0-1,0.45-1,1v0 c0,0.55,0.45,1,1,1h2v2c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-2h2c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h-2v-2c0-0.55-0.45-1-1-1 h0c-0.55,0-1,0.45-1,1V15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
