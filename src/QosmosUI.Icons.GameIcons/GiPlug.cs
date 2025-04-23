// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPlug : ComponentBase
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
		builder.AddAttribute(14, "d", "M382.957 22.023c-2.618.033-5.138.96-7.26 3.082l-67.88 67.883 22.627 22.627 67.882-67.883c5.657-5.657 2.83-14.142-2.828-19.8-3.535-3.534-8.177-5.964-12.54-5.91zm-131.71 37.023l-21.92 21.92 203.648 203.647 21.92-21.92-11.315-11.315L262.56 70.36 251.25 59.047zm-23.335 45.96l-55.86 55.863v90.508l-22.628 22.63c-11.314 11.313-11.315 33.94.092 45.347l45.164 45.162c11.314 11.314 33.94 11.314 45.254 0l22.627-22.63h90.51l55.862-55.86-181.02-181.02zm245.555 7.527c-2.62.033-5.138.96-7.26 3.082l-67.88 67.883 22.626 22.626 67.883-67.882c5.657-5.657 2.83-14.142-2.828-19.8-3.536-3.535-8.177-5.965-12.54-5.91zM148.08 349.25l-128 128 12.727 12.728 128-128-12.727-12.727z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
