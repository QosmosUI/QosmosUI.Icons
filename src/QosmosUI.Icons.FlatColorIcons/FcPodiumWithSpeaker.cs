// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcPodiumWithSpeaker : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "fill", "#FFB74D");
		builder.AddAttribute(15, "cx", "24");
		builder.AddAttribute(16, "cy", "11");
		builder.AddAttribute(17, "r", "6");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "fill", "#607D8B");
		builder.AddAttribute(20, "d", "M36,26.1c0,0-3.3-7.1-12-7.1s-12,7.1-12,7.1V30h24V26.1z");
		builder.CloseElement();
		builder.OpenElement(21, "polygon");
		builder.AddAttribute(22, "fill", "#B0BEC5");
		builder.AddAttribute(23, "points", "41,25 7,25 6,29 11,32 9,29 39,29 37,32 42,29");
		builder.CloseElement();
		builder.OpenElement(24, "polygon");
		builder.AddAttribute(25, "fill", "#78909C");
		builder.AddAttribute(26, "points", "9,29 39,29 35,41 13,41");
		builder.CloseElement();
		builder.CloseElement();
    }
}
