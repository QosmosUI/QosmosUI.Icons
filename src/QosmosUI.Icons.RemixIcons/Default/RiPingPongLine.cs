// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiPingPongLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.5 2C16.7467 2 21 6.25329 21 11.5C21 13.0291 20.6387 14.4739 19.9969 15.7536L22.4602 18.2175C22.8507 18.608 22.8507 19.2412 22.4602 19.6317L19.6317 22.4602C19.2412 22.8507 18.608 22.8507 18.2175 22.4602L15.7536 19.9969C14.4739 20.6387 13.0291 21 11.5 21C6.25329 21 2 16.7467 2 11.5C2 6.25329 6.25329 2 11.5 2ZM16.8033 15.3877L15.3891 16.8019L18.9246 20.3375L20.3388 18.9233L16.8033 15.3877ZM18.6669 9.28305L9.28305 18.6669C9.98371 18.8834 10.7282 19 11.5 19C12.4671 19 13.3914 18.817 14.2403 18.4836L13.2678 17.5104C12.8772 17.1199 12.8772 16.4867 13.2678 16.0962L16.0962 13.2678C16.4867 12.8772 17.1199 12.8772 17.5104 13.2678L18.4836 14.2403C18.817 13.3914 19 12.4671 19 11.5C19 10.7282 18.8834 9.98371 18.6669 9.28305ZM11.5 4C7.35786 4 4 7.35786 4 11.5C4 14.1135 5.3368 16.4148 7.36394 17.7574L17.7574 7.36394C16.4148 5.3368 14.1135 4 11.5 4Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
