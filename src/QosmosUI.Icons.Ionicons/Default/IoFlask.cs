// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoFlask : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M452.32,365,327.4,167.12A48.07,48.07,0,0,1,320,141.48V64h15.56c8.61,0,16-6.62,16.43-15.23A16,16,0,0,0,336,32H176.45c-8.61,0-16,6.62-16.43,15.23A16,16,0,0,0,176,64h16v77.48a47.92,47.92,0,0,1-7.41,25.63L59.68,365a74,74,0,0,0-2.5,75.84C70.44,465.19,96.36,480,124.13,480H387.87c27.77,0,53.69-14.81,66.95-39.21A74,74,0,0,0,452.32,365ZM211.66,184.2A79.94,79.94,0,0,0,224,141.48V68a4,4,0,0,1,4-4h56a4,4,0,0,1,4,4v73.48a79.94,79.94,0,0,0,12.35,42.72l57.8,91.53A8,8,0,0,1,351.37,288H160.63a8,8,0,0,1-6.77-12.27Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
