// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrClosedCaption : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M1,12 C1,5 2.5,4 12,4 C21.5,4 23,5 23,12 C23,19 21.5,20 12,20 C2.5,20 1,19 1,12 Z M5.25,14 C5.25,15.5 6,16 7.75,16 C9.5,16 10.25,15.5 10.25,14 L9.97861679,14 C9.97861671,15.25 8.97905547,16 7.75,16 C6.52094453,16 5.52138329,15.25 5.52138321,14 L5.52138321,10 C5.5,8.75 6.5,8 7.75,8 C9,8 10,8.75 9.97861679,10 L10.25,10 C10.25,8.75 9.2286998,8 7.75,8 C6.2713002,8 5.25,8.75 5.25,10 L5.25,14 Z M13.25,14 C13.25,15.5 14,16 15.75,16 C17.5,16 18.25,15.5 18.25,14 L17.9786168,14 C17.9786167,15.25 16.9790555,16 15.75,16 C14.5209445,16 13.5213833,15.25 13.5213832,14 L13.5213832,10 C13.5,8.75 14.5,8 15.75,8 C17,8 18,8.75 17.9786168,10 L18.25,10 C18.25,8.75 17.2286998,8 15.75,8 C14.2713002,8 13.25,8.75 13.25,10 L13.25,14 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
