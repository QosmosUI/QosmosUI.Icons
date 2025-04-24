// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaFonticons : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 Z M 7 7 L 25 7 L 25 25 L 7 25 Z M 19.71875 8.90625 L 19.03125 10.1875 L 17.78125 10.1875 L 17.625 10.625 L 18.625 11.6875 L 18.21875 13.1875 C 18.21875 13.1875 18.507813 13.539063 18.53125 13.53125 C 18.554688 13.523438 19.9375 12.75 19.9375 12.75 L 21.3125 13.53125 L 21.6875 13.1875 L 21.25 11.6875 L 22.25 10.59375 L 22.03125 10.1875 L 20.8125 10.1875 L 20.125 8.90625 Z M 14.375 10.71875 C 10.871094 10.71875 10.96875 13.375 10.96875 13.375 L 10.96875 14.75 L 9.6875 14.75 L 9.6875 16.4375 L 10.9375 16.4375 L 10.9375 21.8125 L 9.6875 21.96875 L 9.6875 23.125 L 15.5625 23.125 C 15.546875 23.144531 15.5625 22 15.5625 22 L 13.46875 21.78125 L 13.46875 16.4375 L 15.96875 16.4375 L 16.46875 14.75 L 13.46875 14.75 L 13.46875 13 C 13.46875 13 13.636719 12.25 14.28125 12.25 C 14.925781 12.25 15.03125 12.84375 15.03125 12.84375 L 15.03125 13.34375 L 17.28125 13.03125 C 17.28125 13.03125 17.703125 10.71875 14.375 10.71875 Z M 17.8125 14.78125 L 17.4375 16.0625 L 18.625 16.40625 C 18.769531 16.445313 18.875 16.570313 18.875 16.71875 L 18.875 21.5 C 18.875 21.65625 18.75 21.78125 18.59375 21.8125 L 17.65625 22 L 17.65625 23.125 L 22.21875 23.125 L 22.21875 22.03125 L 21.6875 21.9375 C 21.53125 21.910156 21.40625 21.753906 21.40625 21.59375 L 21.40625 14.78125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
