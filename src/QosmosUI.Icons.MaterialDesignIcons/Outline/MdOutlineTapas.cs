// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineTapas : ComponentBase
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
		builder.AddAttribute(18, "d", "M22,10V1h-8v9c0,1.86,1.28,3.41,3,3.86V21h-2v2h6v-2h-2v-7.14C20.72,13.41,22,11.86,22,10z M20,3v3h-4V3H20z M16,10V8h4v2 c0,1.1-0.9,2-2,2S16,11.1,16,10z M10,9H8V8h2c1.38,0,2.5-1.12,2.5-2.5C12.5,4.12,11.38,3,10,3H8V1H6v2H4C2.62,3,1.5,4.12,1.5,5.5 C1.5,6.88,2.62,8,4,8h2v1H4c-1.38,0-2.5,1.12-2.5,2.5C1.5,12.88,2.62,14,4,14h2v9h2v-9h2c1.38,0,2.5-1.12,2.5-2.5 C12.5,10.12,11.38,9,10,9z M4,6C3.72,6,3.5,5.78,3.5,5.5S3.72,5,4,5h6c0.28,0,0.5,0.22,0.5,0.5S10.28,6,10,6H4z M10,12H4 c-0.28,0-0.5-0.22-0.5-0.5S3.72,11,4,11h6c0.28,0,0.5,0.22,0.5,0.5S10.28,12,10,12z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
