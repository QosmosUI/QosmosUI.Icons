// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxHeading : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M8.75432 2.0502C8.50579 2.0502 8.30432 2.25167 8.30432 2.5002C8.30432 2.74873 8.50579 2.9502 8.75432 2.9502H9.94997V7.05004H5.04997V2.9502H6.25432C6.50285 2.9502 6.70432 2.74873 6.70432 2.5002C6.70432 2.25167 6.50285 2.0502 6.25432 2.0502H2.75432C2.50579 2.0502 2.30432 2.25167 2.30432 2.5002C2.30432 2.74873 2.50579 2.9502 2.75432 2.9502H3.94997V12.0502H2.75432C2.50579 12.0502 2.30432 12.2517 2.30432 12.5002C2.30432 12.7487 2.50579 12.9502 2.75432 12.9502H6.25432C6.50285 12.9502 6.70432 12.7487 6.70432 12.5002C6.70432 12.2517 6.50285 12.0502 6.25432 12.0502H5.04997V7.95004H9.94997V12.0502H8.75432C8.50579 12.0502 8.30432 12.2517 8.30432 12.5002C8.30432 12.7487 8.50579 12.9502 8.75432 12.9502H12.2543C12.5028 12.9502 12.7043 12.7487 12.7043 12.5002C12.7043 12.2517 12.5028 12.0502 12.2543 12.0502H11.05V2.9502H12.2543C12.5028 2.9502 12.7043 2.74873 12.7043 2.5002C12.7043 2.25167 12.5028 2.0502 12.2543 2.0502H8.75432Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
