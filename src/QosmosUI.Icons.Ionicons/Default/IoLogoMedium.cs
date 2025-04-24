// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoLogoMedium : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "id", "boxes");
		builder.AddAttribute(15, "display", "none");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "id", "icons");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M28,28v456h456V28H28z M406.83,136.04l-24.46,23.45c-2.11,1.61-3.15,4.25-2.72,6.86v172.28c-0.44,2.61,0.61,5.26,2.72,6.86		l23.88,23.45v5.15H286.13v-5.15l24.74-24.02c2.43-2.43,2.43-3.15,2.43-6.86V198.81l-68.79,174.71h-9.3l-80.09-174.71v117.1		c-0.67,4.92,0.97,9.88,4.43,13.44l32.18,39.03v5.15h-91.24v-5.15l32.18-39.03c3.44-3.57,4.98-8.56,4.15-13.44V180.5		c0.38-3.76-1.05-7.48-3.86-10.01l-28.6-34.46v-5.15h88.81l68.65,150.55l60.35-150.55h84.66V136.04z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
