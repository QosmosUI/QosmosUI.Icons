// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPaperclipSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 21 4 C 19.609375 4 18.242188 4.539063 17.1875 5.59375 L 7.8125 14.96875 C 4.839844 17.941406 4.839844 22.777344 7.8125 25.75 C 10.785156 28.722656 15.621094 28.722656 18.59375 25.75 L 24.84375 19.5 L 23.4375 18.09375 L 17.1875 24.34375 C 14.980469 26.550781 11.425781 26.550781 9.21875 24.34375 C 7.011719 22.136719 7.011719 18.582031 9.21875 16.375 L 18.59375 7 C 19.9375 5.65625 22.09375 5.65625 23.4375 7 C 24.78125 8.34375 24.78125 10.5 23.4375 11.84375 L 14.0625 21.21875 C 13.582031 21.699219 12.824219 21.699219 12.34375 21.21875 C 11.863281 20.738281 11.863281 19.980469 12.34375 19.5 L 20.9375 10.90625 L 19.53125 9.5 L 10.9375 18.09375 C 9.691406 19.339844 9.691406 21.378906 10.9375 22.625 C 12.183594 23.871094 14.222656 23.871094 15.46875 22.625 L 24.84375 13.25 C 26.953125 11.140625 26.953125 7.703125 24.84375 5.59375 C 23.789063 4.539063 22.390625 4 21 4 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
