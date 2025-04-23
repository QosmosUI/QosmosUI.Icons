// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoTonePointOfSale : ComponentBase
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
		builder.AddAttribute(19, "d", "M9.5,16h-1C8.22,16,8,15.78,8,15.5C8,15.22,8.22,15,8.5,15h1c0.28,0,0.5,0.22,0.5,0.5 C10,15.78,9.78,16,9.5,16z M10,13.5c0-0.28-0.22-0.5-0.5-0.5h-1C8.22,13,8,13.22,8,13.5C8,13.78,8.22,14,8.5,14h1 C9.78,14,10,13.78,10,13.5z M10,11.5c0-0.28-0.22-0.5-0.5-0.5h-1C8.22,11,8,11.22,8,11.5C8,11.78,8.22,12,8.5,12h1 C9.78,12,10,11.78,10,11.5z M13,15.5c0-0.28-0.22-0.5-0.5-0.5h-1c-0.28,0-0.5,0.22-0.5,0.5c0,0.28,0.22,0.5,0.5,0.5h1 C12.78,16,13,15.78,13,15.5z M13,13.5c0-0.28-0.22-0.5-0.5-0.5h-1c-0.28,0-0.5,0.22-0.5,0.5c0,0.28,0.22,0.5,0.5,0.5h1 C12.78,14,13,13.78,13,13.5z M13,11.5c0-0.28-0.22-0.5-0.5-0.5h-1c-0.28,0-0.5,0.22-0.5,0.5c0,0.28,0.22,0.5,0.5,0.5h1 C12.78,12,13,11.78,13,11.5z M16,15.5c0-0.28-0.22-0.5-0.5-0.5h-1c-0.28,0-0.5,0.22-0.5,0.5c0,0.28,0.22,0.5,0.5,0.5h1 C15.78,16,16,15.78,16,15.5z M16,13.5c0-0.28-0.22-0.5-0.5-0.5h-1c-0.28,0-0.5,0.22-0.5,0.5c0,0.28,0.22,0.5,0.5,0.5h1 C15.78,14,16,13.78,16,13.5z M16,11.5c0-0.28-0.22-0.5-0.5-0.5h-1c-0.28,0-0.5,0.22-0.5,0.5c0,0.28,0.22,0.5,0.5,0.5h1 C15.78,12,16,11.78,16,11.5z M17,4H7v2h10V4z");
		builder.AddAttribute(20, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M17,2H7C5.9,2,5,2.9,5,4v2c0,1.1,0.9,2,2,2h10c1.1,0,2-0.9,2-2V4C19,2.9,18.1,2,17,2z M17,6H7V4h10V6z M20,22H4 c-1.1,0-2-0.9-2-2v-1h20v1C22,21.1,21.1,22,20,22z M18.53,10.19C18.21,9.47,17.49,9,16.7,9H7.3c-0.79,0-1.51,0.47-1.83,1.19L2,18 h20L18.53,10.19z M9.5,16h-1C8.22,16,8,15.78,8,15.5C8,15.22,8.22,15,8.5,15h1c0.28,0,0.5,0.22,0.5,0.5C10,15.78,9.78,16,9.5,16z M9.5,14h-1C8.22,14,8,13.78,8,13.5C8,13.22,8.22,13,8.5,13h1c0.28,0,0.5,0.22,0.5,0.5C10,13.78,9.78,14,9.5,14z M9.5,12h-1 C8.22,12,8,11.78,8,11.5C8,11.22,8.22,11,8.5,11h1c0.28,0,0.5,0.22,0.5,0.5C10,11.78,9.78,12,9.5,12z M12.5,16h-1 c-0.28,0-0.5-0.22-0.5-0.5c0-0.28,0.22-0.5,0.5-0.5h1c0.28,0,0.5,0.22,0.5,0.5C13,15.78,12.78,16,12.5,16z M12.5,14h-1 c-0.28,0-0.5-0.22-0.5-0.5c0-0.28,0.22-0.5,0.5-0.5h1c0.28,0,0.5,0.22,0.5,0.5C13,13.78,12.78,14,12.5,14z M12.5,12h-1 c-0.28,0-0.5-0.22-0.5-0.5c0-0.28,0.22-0.5,0.5-0.5h1c0.28,0,0.5,0.22,0.5,0.5C13,11.78,12.78,12,12.5,12z M15.5,16h-1 c-0.28,0-0.5-0.22-0.5-0.5c0-0.28,0.22-0.5,0.5-0.5h1c0.28,0,0.5,0.22,0.5,0.5C16,15.78,15.78,16,15.5,16z M15.5,14h-1 c-0.28,0-0.5-0.22-0.5-0.5c0-0.28,0.22-0.5,0.5-0.5h1c0.28,0,0.5,0.22,0.5,0.5C16,13.78,15.78,14,15.5,14z M15.5,12h-1 c-0.28,0-0.5-0.22-0.5-0.5c0-0.28,0.22-0.5,0.5-0.5h1c0.28,0,0.5,0.22,0.5,0.5C16,11.78,15.78,12,15.5,12z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
