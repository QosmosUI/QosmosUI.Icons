// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineHive : ComponentBase
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
		builder.AddAttribute(20, "d", "M21.5,9l-2.25-4h-3.31l-1.69-3h-4.5L8.06,5H4.75L2.5,9l1.69,3L2.5,15l2.25,4h3.31l1.69,3h4.5l1.69-3h3.31l2.25-4l-1.69-3 L21.5,9z M19.21,9l-1.12,2h-2.14l-1.12-2l1.12-2h2.14L19.21,9z M10.94,14l-1.12-2l1.12-2h2.12l1.12,2l-1.12,2H10.94z M13.08,4 l1.12,1.98L13.06,8h-2.12L9.8,5.98L10.92,4H13.08z M5.92,7h2.14l1.12,2l-1.12,2H5.92L4.79,9L5.92,7z M4.79,15l1.12-2h2.14l1.12,2 l-1.12,2H5.92L4.79,15z M10.92,20L9.8,18.02L10.94,16h2.12l1.13,2.02L13.08,20H10.92z M18.08,17h-2.14l-1.12-2l1.12-2h2.14l1.12,2 L18.08,17z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
