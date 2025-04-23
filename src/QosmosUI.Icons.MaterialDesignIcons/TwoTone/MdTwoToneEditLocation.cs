// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneEditLocation : ComponentBase
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
		builder.AddAttribute(18, "d", "M14.11,14h-0.83H10H8v-2V8.74V7.91l0.59-0.59L11.91,4C8.61,4.05,6,6.6,6,10.2c0,2.34,1.95,5.44,6,9.14 c4.05-3.7,6-6.79,6-9.14c0-0.03,0-0.06,0-0.08l-3.3,3.3L14.11,14z");
		builder.AddAttribute(19, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M18.17,4.91L17.1,3.84l-5.55,5.55v1.08h1.08L18.17,4.91z M16,2.74l1.29-1.29c0.58-0.59,1.52-0.59,2.11-0.01 c0,0,0.01,0.01,0.01,0.01l1.15,1.15c0.59,0.59,0.59,1.54,0,2.12L19.88,5.4l-0.02,0.02L19.28,6l-6,6H10V8.74L16,2.74z M13.72,2.19 l-0.55,0.55L11.9,4.01C8.6,4.06,6,6.61,6,10.21c0,2.34,1.95,5.44,6,9.14c4.05-3.7,6-6.79,6-9.14v-0.1l1.8-1.8 c0.13,0.6,0.2,1.24,0.2,1.9c0,3.32-2.67,7.25-8,11.8c-5.33-4.55-8-8.48-8-11.8c0-4.98,3.8-8.2,8-8.2 C12.58,2.01,13.16,2.07,13.72,2.19z");
		builder.CloseElement();
		builder.OpenElement(22, "polygon");
		builder.AddAttribute(23, "opacity", ".3");
		builder.AddAttribute(24, "points", "18.17,4.91 17.1,3.84 11.55,9.39 11.55,10.47 12.63,10.47");
		builder.CloseElement();
		builder.CloseElement();
    }
}
