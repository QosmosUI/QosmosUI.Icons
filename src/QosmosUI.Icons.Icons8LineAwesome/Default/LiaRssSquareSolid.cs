// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaRssSquareSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 Z M 7 7 L 25 7 L 25 25 L 7 25 Z M 12 10 C 11.316406 10 10.644531 10.054688 10 10.1875 L 10 12.25 C 10.640625 12.082031 11.308594 12 12 12 C 16.410156 12 20 15.589844 20 20 C 20 20.691406 19.914063 21.359375 19.75 22 L 21.8125 22 C 21.945313 21.355469 22 20.683594 22 20 C 22 14.484375 17.515625 10 12 10 Z M 12 14 C 11.296875 14 10.628906 14.121094 10 14.34375 L 10 16.5625 C 10.589844 16.21875 11.269531 16 12 16 C 14.207031 16 16 17.792969 16 20 C 16 20.730469 15.78125 21.410156 15.4375 22 L 17.65625 22 C 17.878906 21.371094 18 20.703125 18 20 C 18 16.691406 15.308594 14 12 14 Z M 12 18 C 10.894531 18 10 18.894531 10 20 C 10 21.105469 10.894531 22 12 22 C 13.105469 22 14 21.105469 14 20 C 14 18.894531 13.105469 18 12 18 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
