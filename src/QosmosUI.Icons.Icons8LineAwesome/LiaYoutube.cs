// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaYoutube : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 6 C 12.234375 6 8.90625 6.390625 6.875 6.6875 C 5.195313 6.933594 3.839844 8.199219 3.53125 9.875 C 3.269531 11.300781 3 13.386719 3 16 C 3 18.613281 3.269531 20.699219 3.53125 22.125 C 3.839844 23.800781 5.195313 25.070313 6.875 25.3125 C 8.914063 25.609375 12.253906 26 16 26 C 19.746094 26 23.085938 25.609375 25.125 25.3125 C 26.804688 25.070313 28.160156 23.800781 28.46875 22.125 C 28.730469 20.695313 29 18.605469 29 16 C 29 13.394531 28.734375 11.304688 28.46875 9.875 C 28.160156 8.199219 26.804688 6.933594 25.125 6.6875 C 23.09375 6.390625 19.765625 6 16 6 Z M 16 8 C 19.632813 8 22.878906 8.371094 24.84375 8.65625 C 25.6875 8.78125 26.347656 9.417969 26.5 10.25 C 26.742188 11.570313 27 13.527344 27 16 C 27 18.46875 26.742188 20.429688 26.5 21.75 C 26.347656 22.582031 25.691406 23.222656 24.84375 23.34375 C 22.871094 23.628906 19.609375 24 16 24 C 12.390625 24 9.125 23.628906 7.15625 23.34375 C 6.3125 23.222656 5.652344 22.582031 5.5 21.75 C 5.257813 20.429688 5 18.476563 5 16 C 5 13.519531 5.257813 11.570313 5.5 10.25 C 5.652344 9.417969 6.308594 8.78125 7.15625 8.65625 C 9.117188 8.371094 12.367188 8 16 8 Z M 13 10.28125 L 13 21.71875 L 14.5 20.875 L 21.5 16.875 L 23 16 L 21.5 15.125 L 14.5 11.125 Z M 15 13.71875 L 18.96875 16 L 15 18.28125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
