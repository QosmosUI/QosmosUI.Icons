// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaVolumeUpSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 17 3.59375 L 15.28125 5.28125 L 9.5625 11 L 5 11 L 5 21 L 9.5625 21 L 15.28125 26.71875 L 17 28.40625 Z M 23.8125 8.1875 L 22.40625 9.59375 C 25.925781 13.113281 25.925781 18.761719 22.40625 22.28125 L 23.8125 23.71875 C 28.09375 19.4375 28.09375 12.46875 23.8125 8.1875 Z M 15 8.4375 L 15 23.5625 L 10.71875 19.28125 L 10.40625 19 L 7 19 L 7 13 L 10.40625 13 L 10.71875 12.71875 Z M 20.90625 11.09375 L 19.5 12.5 C 21.410156 14.410156 21.402344 17.574219 19.46875 19.59375 L 20.9375 21 C 23.601563 18.21875 23.59375 13.78125 20.90625 11.09375 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
