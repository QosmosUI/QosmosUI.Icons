// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaContao : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5.65625 5.46875 C 4.75 5.46875 4 6.1875 4 7.09375 L 4 24.90625 C 4 25.8125 4.75 26.53125 5.65625 26.53125 L 9.375 26.53125 C 7.777344 24.785156 7.054688 22.253906 7 22.03125 C 6.761719 21.082031 5.828125 16.929688 5.5 14.96875 C 5.367188 14.179688 5.28125 13.3125 5.28125 12.1875 C 5.28125 8.605469 7.144531 6.472656 8.34375 5.46875 Z M 22.15625 5.46875 C 23.769531 6.917969 24.65625 9.40625 24.65625 9.40625 L 18.25 10.75 C 18.25 10.75 17.304688 8.625 15.125 8.625 C 13.9375 8.625 11.78125 9.457031 11.78125 11.59375 C 11.78125 12.976563 12.265625 15.867188 12.90625 18.625 C 13.683594 21.964844 14.527344 23.71875 16.6875 23.71875 C 20.242188 23.71875 20.21875 20.1875 20.21875 20.1875 L 26.65625 18.75 C 26.65625 18.75 26.65625 19.394531 26.65625 20.3125 C 26.65625 23.421875 24.632813 25.851563 24 26.53125 L 26.34375 26.53125 C 27.25 26.53125 28 25.8125 28 24.90625 L 28 7.09375 C 28 6.1875 27.25 5.46875 26.34375 5.46875 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
