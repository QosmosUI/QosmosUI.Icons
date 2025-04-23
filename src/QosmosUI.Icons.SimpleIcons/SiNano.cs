// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiNano : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M22.2864 6.8576c-.9453 0-1.7135.7665-1.7135 1.7136 0 1.2843-.4275 1.7136-1.7136 1.7136-.9453 0-1.7135.7664-1.7135 1.7135 0 1.2843-.4276 1.7136-1.7136 1.7136-.9453 0-1.7135.7664-1.7135 1.7135 0 .9454.7665 1.7136 1.7135 1.7136.9454 0 1.7136-.7665 1.7136-1.7136 0-1.2843.4275-1.7135 1.7135-1.7135.9454 0 1.7136-.7665 1.7136-1.7136 0-1.2843.4275-1.7135 1.7135-1.7135.9454 0 1.7136-.7666 1.7136-1.7136 0-.9454-.7682-1.7136-1.7136-1.7136zm-13.717.0017c-.9453 0-1.7135.7665-1.7135 1.7136 0 1.2843-.4275 1.7136-1.7135 1.7136-.9454 0-1.7136.7664-1.7136 1.7135 0 .947.77 1.7135 1.7153 1.7135S6.8576 12.9471 6.8576 12c0-1.2843.4293-1.7135 1.7136-1.7135s1.7136.4275 1.7136 1.7135c0 .947.7698 1.7135 1.7152 1.7135.9453 0 1.7135-.7664 1.7135-1.7135 0-.9454-.7664-1.7135-1.7169-1.7135-1.2843 0-1.7135-.4276-1.7135-1.7136 0-.9453-.7683-1.7136-1.7136-1.7136zm-6.8559 6.856A1.7136 1.7136 0 0 0 0 15.4287a1.7136 1.7136 0 0 0 1.7135 1.7136 1.7136 1.7136 0 0 0 1.7136-1.7136 1.7136 1.7136 0 0 0-1.7135-1.7136Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
