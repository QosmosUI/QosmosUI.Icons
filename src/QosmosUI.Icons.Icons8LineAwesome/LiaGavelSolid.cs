// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaGavelSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 15.96875 1.59375 L 15.25 2.28125 L 8.25 9.3125 L 7.53125 10 L 11.96875 14.4375 L 12.65625 13.71875 L 13 13.375 L 15.09375 15.46875 L 3.28125 27.28125 L 4.71875 28.71875 L 16.53125 16.90625 L 18.59375 18.96875 L 18.25 19.3125 L 17.53125 20 L 21.96875 24.4375 L 22.65625 23.71875 L 30.375 16 L 29.65625 15.3125 L 26.65625 12.28125 L 25.96875 11.59375 L 25.25 12.28125 L 24.96875 12.5625 L 19.375 7 L 20.375 6 L 19.65625 5.3125 L 16.65625 2.28125 Z M 15.96875 4.40625 L 17.5625 6 L 11.96875 11.59375 L 10.375 10 Z M 18 8.4375 L 23.5625 14 L 20 17.5625 L 14.4375 12 Z M 25.96875 14.40625 L 27.5625 16 L 21.96875 21.59375 L 20.375 20 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
