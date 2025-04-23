// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdNotAccessible : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M14,11.05l-3.42-3.42c0.32-0.34,0.74-0.57,1.23-0.61c0.48-0.04,0.84,0.07,1.2,0.26c0.19,0.1,0.39,0.22,0.63,0.46l1.29,1.43 c0.98,1.08,2.53,1.85,4.07,1.83v2C17.25,12.99,15.29,12.12,14,11.05z M12,6c1.1,0,2-0.9,2-2s-0.9-2-2-2c-1.1,0-2,0.9-2,2 S10.9,6,12,6z M2.81,2.81L1.39,4.22L10,12.83V15c0,1.1,0.9,2,2,2h2.17l5.61,5.61l1.41-1.41L2.81,2.81z M10,20c-1.66,0-3-1.34-3-3 c0-1.31,0.84-2.41,2-2.83V12.1c-2.28,0.46-4,2.48-4,4.9c0,2.76,2.24,5,5,5c2.42,0,4.44-1.72,4.9-4h-2.07 C12.42,19.16,11.31,20,10,20z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
