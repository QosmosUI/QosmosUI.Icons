// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaChildCombatant : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 576 512";

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
		builder.AddAttribute(14, "d", "M176 128A64 64 0 1 0 176 0a64 64 0 1 0 0 128zm-8 352l0-128 16 0 0 128c0 17.7 14.3 32 32 32s32-14.3 32-32l0-179.5L260.9 321c9.4 15 29.2 19.4 44.1 10s19.4-29.2 10-44.1l-51.7-82.1c-17.6-27.9-48.3-44.9-81.2-44.9l-12.3 0c-33 0-63.7 16.9-81.2 44.9L36.9 287c-9.4 15-4.9 34.7 10 44.1s34.7 4.9 44.1-10L104 300.5 104 480c0 17.7 14.3 32 32 32s32-14.3 32-32zM448 0L432 0 416 0c-8.8 0-16 7.2-16 16s7.2 16 16 16l0 100.3c-9.6 5.5-16 15.9-16 27.7l0 32c-17.7 0-32 14.3-32 32l0 144c0 17.7 14.3 32 32 32l16 0 0 96c0 8.8 7.2 16 16 16l59.5 0c10.4 0 18-9.8 15.5-19.9L484 400l44 0c8.8 0 16-7.2 16-16l0-16c0-8.8-7.2-16-16-16l-48 0 0-26.7 53.1-17.7c6.5-2.2 10.9-8.3 10.9-15.2l0-84.5c0-8.8-7.2-16-16-16l-16 0c-8.8 0-16 7.2-16 16l0 56-16 5.3L480 160c0-11.8-6.4-22.2-16-27.7L464 16c0-8.8-7.2-16-16-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
