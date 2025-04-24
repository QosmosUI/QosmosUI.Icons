// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaSchoolSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 L 3 7 L 3 9 L 16 6 L 29 9 L 29 7 Z M 10 10 C 6.773438 10 3.625 11.3125 3.625 11.3125 L 3 11.59375 L 3 27 L 14.28125 27 C 14.628906 27.597656 15.261719 28 16 28 C 16.738281 28 17.371094 27.597656 17.71875 27 L 29 27 L 29 11.59375 L 28.375 11.3125 C 28.375 11.3125 25.226563 10 22 10 C 19.082031 10 16.519531 10.980469 16 11.1875 C 15.480469 10.980469 12.917969 10 10 10 Z M 10 12 C 11.933594 12 14 12.625 15 12.96875 L 15 24.09375 C 13.886719 23.726563 12.058594 23.21875 10 23.21875 C 7.898438 23.21875 6.1875 23.703125 5 24.09375 L 5 12.96875 C 5.769531 12.691406 7.800781 12 10 12 Z M 22 12 C 24.199219 12 26.230469 12.691406 27 12.96875 L 27 24.09375 C 25.8125 23.703125 24.101563 23.21875 22 23.21875 C 19.941406 23.21875 18.113281 23.726563 17 24.09375 L 17 12.96875 C 18 12.625 20.066406 12 22 12 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
