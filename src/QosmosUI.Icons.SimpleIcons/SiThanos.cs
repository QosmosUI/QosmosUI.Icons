// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiThanos : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 0v24h16.998A7.002 7.002 0 0 0 24 16.998V0Zm18.707 15.129h.896v.895h-.896zm-.281-3.857h1.455v1.456h-1.455Zm-.224-3.801h1.903v1.905h-1.903Zm-3.073 11.234h.895v.896h-.896zm-.28-3.902h1.456v1.457h-1.456zm-.224-3.755h1.906v1.904h-1.904Zm.224-1.897V7.696h1.456V9.15Zm-6.874 9.554h.896v.896h-.896Zm-.28-3.856h1.456v1.454H7.695Zm.28-2.401v-.896h.896v.896zm-.28-4.752h1.456V9.15H7.695ZM4.4 18.706h.897v.895h-.897Zm0-3.577h.897v.895h-.897Zm-.28-3.857h1.455v1.456H4.12Zm-.224-3.801h1.904v1.905H3.895Zm-.837-4.413H20.94v3.577h-7.153v14.307h-3.576V6.635H3.058Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
