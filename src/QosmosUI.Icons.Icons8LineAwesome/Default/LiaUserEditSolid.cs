// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaUserEditSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 13 3 C 9.144531 3 6 6.144531 6 10 C 6 12.410156 7.230469 14.550781 9.09375 15.8125 C 5.527344 17.34375 3 20.882813 3 25 L 5 25 C 5 20.570313 8.570313 17 13 17 C 15.144531 17 17.0625 17.878906 18.5 19.25 L 13.78125 23.96875 L 13.71875 24.28125 L 13.03125 27.8125 L 12.71875 29.28125 L 14.1875 28.96875 L 17.71875 28.28125 L 18.03125 28.21875 L 28.125 18.125 C 29.285156 16.964844 29.285156 15.035156 28.125 13.875 C 27.542969 13.292969 26.769531 13 26 13 C 25.246094 13 24.484375 13.285156 23.90625 13.84375 L 19.9375 17.8125 C 19.066406 16.976563 18.035156 16.292969 16.90625 15.8125 C 18.769531 14.550781 20 12.410156 20 10 C 20 6.144531 16.855469 3 13 3 Z M 13 5 C 15.773438 5 18 7.226563 18 10 C 18 12.773438 15.773438 15 13 15 C 10.226563 15 8 12.773438 8 10 C 8 7.226563 10.226563 5 13 5 Z M 26 15 C 26.253906 15 26.519531 15.082031 26.71875 15.28125 C 27.117188 15.679688 27.117188 16.289063 26.71875 16.6875 L 17.03125 26.375 L 15.25 26.75 L 15.625 24.96875 L 25.3125 15.28125 C 25.511719 15.082031 25.746094 15 26 15 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
