// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiBag1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Bag_1");
		builder.AddAttribute(15, "data-name", "Bag 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.37,17.65a16.777,16.777,0,0,0-2.01-5.54,17.037,17.037,0,0,0-3.74-4.55l-.1-.08a.121.121,0,0,1-.02-.15l1.49-2.59a1.12,1.12,0,0,0,0-1.12,1.092,1.092,0,0,0-.97-.55H8.98a1.1,1.1,0,0,0-.97.55,1.12,1.12,0,0,0,0,1.12l1.5,2.59a.124.124,0,0,1-.03.15l-.09.08A17.327,17.327,0,0,0,3.63,17.65a4.051,4.051,0,0,0-.04.48,2.8,2.8,0,0,0,2.8,2.8H17.62a2.782,2.782,0,0,0,2.13-.99A2.834,2.834,0,0,0,20.37,17.65ZM8.88,4.24a.1.1,0,0,1,0-.12.106.106,0,0,1,.1-.05h6.04a.143.143,0,0,1,.11.05.163.163,0,0,1,0,.12l-1.59,2.8H10.46Zm5.09,4.08a16.436,16.436,0,0,1,5.42,9.5,1.817,1.817,0,0,1-.4,1.47,1.786,1.786,0,0,1-1.37.64H6.39a1.805,1.805,0,0,1-1.8-1.8,1.628,1.628,0,0,1,.03-.31,16.286,16.286,0,0,1,5.42-9.5l.32-.28h3.28Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
