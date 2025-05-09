// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundKayaking : ComponentBase
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
		builder.AddAttribute(18, "d", "M2,22c0-0.55,0.45-1,1-1h0c0.87,0,1.73-0.24,2.53-0.7c0.29-0.16,0.65-0.17,0.94,0c1.59,0.9,3.48,0.9,5.06,0 c0.29-0.16,0.65-0.16,0.94,0c1.59,0.9,3.48,0.9,5.06,0c0.29-0.16,0.65-0.16,0.94,0C19.27,20.76,20.13,21,21,21h0c0.55,0,1,0.45,1,1 s-0.45,1-1,1h0c-1.03,0-2.06-0.25-3-0.75h0c-1.92,1.02-4.18,1-6.09-0.05c-1.79,0.87-3.92,0.98-5.58-0.14C5.3,22.69,4.15,23,3,23h0 C2.45,23,2,22.55,2,22z M12,5.5c-1.1,0-2,0.9-2,2s0.9,2,2,2s2-0.9,2-2S13.1,5.5,12,5.5z M21.47,18.45c-0.42,0.14-0.9,0.28-1.41,0.42 c-0.53-0.15-1.03-0.43-1.45-0.77c-0.35-0.29-0.87-0.29-1.23,0C16.72,18.63,15.9,19,15,19s-1.72-0.37-2.39-0.91 c-0.35-0.28-0.87-0.28-1.22,0C10.72,18.63,9.9,19,9,19s-1.72-0.37-2.39-0.91c-0.35-0.29-0.87-0.28-1.23,0 c-0.43,0.35-0.92,0.62-1.45,0.77c-0.51-0.14-0.98-0.28-1.4-0.42c-0.92-0.3-0.92-1.6,0-1.9c1.21-0.39,2.79-0.82,4.6-1.13l1.35-4.17 c0.31-0.95,1.32-1.47,2.27-1.16c0.09,0.03,0.19,0.07,0.27,0.11l0,0l2.47,1.3l2.84-1.5l1.65-3.71l-0.36-0.93 c-0.1-0.25-0.09-0.52,0.02-0.76l0.74-1.68c0.22-0.51,0.82-0.73,1.32-0.51l1.37,0.61c0.5,0.23,0.73,0.82,0.5,1.32l-0.75,1.68 c-0.11,0.24-0.31,0.43-0.56,0.53L19.36,6.9l-3.72,8.34c2.33,0.3,4.35,0.84,5.82,1.31C22.39,16.85,22.4,18.15,21.47,18.45z M15.02,12.96l-0.59,0.31c-0.58,0.31-1.28,0.31-1.86,0l-0.81-0.43l-0.71,2.17C11.36,15.01,11.68,15,12,15c0.71,0,1.4,0.03,2.07,0.08 L15.02,12.96z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
