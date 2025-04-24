// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaRingSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 26 7 L 25.699219 6.699219 C 24 4.800781 21.5 4.199219 21.5 4.199219 C 18.5 3.300781 13.800781 5.300781 9.601563 9.398438 C 6.101563 12.699219 4 16.699219 4 19.699219 C 4 20.101563 4.101563 20.5 4.101563 20.898438 C 4.300781 22.898438 5.601563 25 6.699219 26 C 8.101563 27.398438 9.898438 28.101563 11.898438 28.101563 C 15.199219 28.101563 19.101563 26.199219 22.699219 22.800781 C 28.300781 17.300781 29.699219 10.800781 26 7 Z M 10 21.699219 C 10 20.398438 11.398438 17.699219 14.398438 14.699219 C 17.300781 11.800781 20.300781 11 21.699219 10.699219 C 21 12.601563 19.5 14.898438 17.300781 17.101563 C 15.199219 19.101563 12.800781 20.699219 10.699219 21.5 C 10.5 21.601563 10.199219 21.601563 10 21.699219 Z M 11 10.800781 C 14.300781 7.5 17.800781 5.898438 20 5.898438 C 20.699219 5.898438 21.300781 6.101563 21.699219 6.5 C 22.101563 6.898438 22.300781 7.699219 22.199219 8.601563 C 21 8.699219 16.898438 9.398438 13 13.300781 C 10.5 15.800781 7.898438 19.398438 8.101563 21.898438 C 7.5 21.898438 6.898438 21.699219 6.601563 21.398438 C 6.398438 21.199219 6.199219 20.898438 6.101563 20.5 C 6.101563 20.5 6 20 6 19.699219 C 6.101563 17.199219 8 13.699219 11 10.800781 Z M 21.300781 21.300781 C 16.5 26.101563 11 27.398438 8.101563 24.601563 C 7.898438 24.398438 7.699219 24.199219 7.5 23.898438 C 7.699219 24 8 24 8.300781 24 C 9.199219 24 10.300781 23.800781 11.398438 23.398438 C 13.800781 22.5 16.398438 20.800781 18.699219 18.5 C 22.199219 15 24.199219 11 24.199219 8.101563 L 24.300781 8.199219 L 24.601563 8.398438 C 27.398438 11.300781 26 16.699219 21.300781 21.300781 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
