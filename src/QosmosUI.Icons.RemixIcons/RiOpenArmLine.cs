// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiOpenArmLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M18.0004 17V22H16.0004V17C16.0004 12.5487 18.6444 8.71498 22.4475 6.98352L23.2753 8.8047C20.1637 10.2213 18.0004 13.3581 18.0004 17ZM8.00045 17V22H6.00045V17C6.00045 13.3581 3.83723 10.2213 0.725586 8.8047L1.55339 6.98352C5.35651 8.71498 8.00045 12.5487 8.00045 17ZM12.0004 12C9.23902 12 7.00045 9.76142 7.00045 7C7.00045 4.23858 9.23902 2 12.0004 2C14.7619 2 17.0004 4.23858 17.0004 7C17.0004 9.76142 14.7619 12 12.0004 12ZM12.0004 10C13.6573 10 15.0004 8.65685 15.0004 7C15.0004 5.34315 13.6573 4 12.0004 4C10.3436 4 9.00045 5.34315 9.00045 7C9.00045 8.65685 10.3436 10 12.0004 10Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
