// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaFlaskSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 17 0 C 16.449219 0 16 0.449219 16 1 C 16 1.550781 16.449219 2 17 2 C 17.550781 2 18 1.550781 18 1 C 18 0.449219 17.550781 0 17 0 Z M 14 3 C 13.449219 3 13 3.449219 13 4 L 10 4 L 10 6 L 11 6 L 11 13.65625 L 4.84375 21.59375 C 4.300781 22.292969 4 23.148438 4 24.03125 C 4 26.214844 5.785156 28 7.96875 28 L 24.03125 28 C 26.214844 28 28 26.214844 28 24.03125 C 28 23.148438 27.699219 22.292969 27.15625 21.59375 L 21 13.65625 L 21 6 L 22 6 L 22 4 L 15 4 C 15 3.449219 14.550781 3 14 3 Z M 13 6 L 19 6 L 19 14.34375 L 21.84375 18 L 10.15625 18 L 13 14.34375 Z M 17 10 C 16.449219 10 16 10.449219 16 11 C 16 11.550781 16.449219 12 17 12 C 17.550781 12 18 11.550781 18 11 C 18 10.449219 17.550781 10 17 10 Z M 8.59375 20 L 23.40625 20 L 25.59375 22.8125 C 25.863281 23.160156 26 23.59375 26 24.03125 C 26 25.136719 25.136719 26 24.03125 26 L 7.96875 26 C 6.863281 26 6 25.136719 6 24.03125 C 6 23.59375 6.136719 23.160156 6.40625 22.8125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
