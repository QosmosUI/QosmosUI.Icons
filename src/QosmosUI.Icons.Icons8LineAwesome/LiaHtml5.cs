// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaHtml5 : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5.21875 4 L 5.3125 5.09375 L 7.0625 24.875 L 7.125 25.5625 L 7.78125 25.75 L 15.71875 27.96875 L 15.96875 28.03125 L 16.25 27.96875 L 24.1875 25.78125 L 24.84375 25.59375 L 24.90625 24.90625 L 26.6875 5.09375 L 26.78125 4.03125 L 25.6875 4.03125 L 6.3125 4 Z M 7.40625 6 L 24.59375 6.03125 L 22.96875 24.03125 L 16 25.96875 L 9 24.03125 Z M 9.8125 9 L 10.46875 16.46875 L 19.03125 16.46875 L 18.75 19.6875 L 16 20.4375 L 15.96875 20.4375 L 13.21875 19.6875 L 13.0625 17.625 L 10.5625 17.625 L 10.90625 21.59375 L 15.96875 23 L 16 23 L 21.0625 21.59375 L 21.75 14 L 12.71875 14 L 12.5 11.46875 L 21.96875 11.46875 L 22.1875 9 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
