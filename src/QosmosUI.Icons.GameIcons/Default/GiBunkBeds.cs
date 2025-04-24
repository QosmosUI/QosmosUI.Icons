// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBunkBeds : ComponentBase
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
		builder.AddAttribute(14, "d", "M25 41v446h30V41zm56.8 40.15c-.1 14.49 1.03 25.35 3.31 32.75 2.77 8.9 6.33 12.9 12.45 16 11.34 5.7 35.34 5.3 70.54 5.1.8-8.5-.5-15.1-3.2-20.4-3.5-6.8-9.4-12.2-18.1-16.86-15.4-8.19-39.1-12.83-65-16.59zM457 105v382h30V105zM73 153v46h238v-46zm256 0v46h110v-46zm-18 64v158h18v-46h110v-18H329v-46h110v-18H329v-30zM81.79 321.3c-.1 14.4 1.03 25.3 3.3 32.6 2.78 9 6.33 13 12.46 16 11.35 5.7 35.35 5.3 70.55 5.1.8-8.5-.5-15-3.2-20.3-3.4-6.8-9.4-12.2-18.1-16.8-15.4-8.2-39.1-12.8-65.01-16.6zM73 393v46h238v-46zm256 0v46h110v-46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
