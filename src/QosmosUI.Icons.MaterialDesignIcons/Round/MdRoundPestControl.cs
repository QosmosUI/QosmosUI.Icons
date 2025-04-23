// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPestControl : ComponentBase
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
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M21,14L21,14c0-0.55-0.45-1-1-1h-2.07c-0.05-0.39-0.12-0.77-0.22-1.14l1.72-0.99c0.48-0.28,0.64-0.89,0.37-1.37l0,0 c-0.28-0.48-0.89-0.64-1.37-0.37L16.92,10c-0.28-0.48-0.62-0.91-0.99-1.29C15.97,8.48,16,8.25,16,8c0-0.8-0.24-1.55-0.65-2.18 l0.94-0.94c0.39-0.39,0.39-1.02,0-1.41l0,0c-0.39-0.39-1.02-0.39-1.41,0l-1.02,1.02c-1.68-0.89-3.1-0.33-3.73,0L9.12,3.46 c-0.39-0.39-1.02-0.39-1.41,0l0,0c-0.39,0.39-0.39,1.02,0,1.41l0.94,0.94C8.24,6.45,8,7.2,8,8c0,0.25,0.03,0.48,0.07,0.72 C7.7,9.1,7.36,9.53,7.08,10L5.57,9.13C5.09,8.86,4.48,9.02,4.21,9.5l0,0c-0.28,0.48-0.11,1.09,0.37,1.37l1.72,0.99 c-0.1,0.37-0.17,0.75-0.22,1.14H4c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h2.07c0.05,0.39,0.12,0.77,0.22,1.14l-1.72,0.99 c-0.48,0.28-0.64,0.89-0.37,1.37l0,0c0.28,0.48,0.89,0.64,1.37,0.37L7.08,18c1.08,1.81,2.88,3,4.92,3s3.84-1.19,4.92-3l1.51,0.87 c0.48,0.28,1.09,0.11,1.37-0.37l0,0c0.28-0.48,0.11-1.09-0.37-1.37l-1.72-0.99c0.1-0.37,0.17-0.75,0.22-1.14H20 C20.55,15,21,14.55,21,14z M12,17L12,17c-0.55,0-1-0.45-1-1v-4c0-0.55,0.45-1,1-1h0c0.55,0,1,0.45,1,1v4C13,16.55,12.55,17,12,17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
