// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaOpencart : ComponentBase
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
		builder.AddAttribute(14, "d", "M 1 5.25 C 3.933594 10.816406 9.117188 11.683594 15.40625 11.8125 C 19.117188 11.890625 27.28125 11.574219 27.28125 13.5625 C 27.28125 15.054688 21.84375 19.730469 21.84375 20.6875 C 21.84375 20.6875 25.613281 17.5 27.71875 15.625 C 29.824219 13.75 31 12.640625 31 11.53125 C 31 9.273438 22.269531 9.6875 15.21875 9.6875 C 8.167969 9.6875 4.3125 8.351563 1 5.25 Z M 8.875 22.53125 C 7.707031 22.53125 6.75 23.457031 6.75 24.625 C 6.75 25.792969 7.707031 26.75 8.875 26.75 C 10.042969 26.75 10.96875 25.792969 10.96875 24.625 C 10.96875 23.457031 10.042969 22.53125 8.875 22.53125 Z M 18.625 22.53125 C 17.457031 22.53125 16.53125 23.457031 16.53125 24.625 C 16.53125 25.792969 17.457031 26.75 18.625 26.75 C 19.792969 26.75 20.75 25.792969 20.75 24.625 C 20.75 23.457031 19.792969 22.53125 18.625 22.53125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
