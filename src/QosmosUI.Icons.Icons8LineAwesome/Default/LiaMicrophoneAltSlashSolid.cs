// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaMicrophoneAltSlashSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 3.7207031 2.2792969 L 2.2792969 3.7207031 L 11.861328 13.302734 L 13.289062 14.728516 L 17.261719 18.701172 L 18.703125 20.144531 L 28.279297 29.720703 L 29.720703 28.279297 L 20.396484 18.955078 L 21.84375 17.9375 C 25.30575 17.5205 28 14.57 28 11 C 28 7.145 24.855 4 21 4 C 17.422 4 14.4695 6.7145 14.0625 10.1875 L 13.054688 11.613281 L 3.7207031 2.2792969 z M 21 6 C 23.773 6 26 8.227 26 11 C 26 12.016 25.7035 12.965 25.1875 13.75 L 18.25 6.8125 C 19.035 6.2965 19.984 6 21 6 z M 16.8125 8.25 L 23.75 15.1875 C 22.965 15.7025 22.016 16 21 16 C 18.227 16 16 13.773 16 11 C 16 9.984 16.2975 9.035 16.8125 8.25 z M 10.722656 14.912109 L 6 21.59375 L 5.53125 22.28125 L 6.09375 22.875 L 6.90625 23.6875 L 4.28125 26.28125 L 5.71875 27.71875 L 8.28125 25.125 L 9.65625 26.5 L 10.375 26 L 17.089844 21.279297 L 15.650391 19.841797 L 9.90625 23.90625 L 8.125 22.0625 L 12.152344 16.34375 L 10.722656 14.912109 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
