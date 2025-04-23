// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaPersonMilitaryToPerson : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M71 12.5c-8.6 1-15 8.2-15 16.8c0 9.3 7.5 16.8 16.7 16.9l111.4 0c8.8-.1 15.9-7.2 15.9-16L200 16c0-9.5-8.3-17-17.8-15.9L71 12.5zM189.5 78.1l-122.9 0C64.9 83.8 64 89.8 64 96c0 35.3 28.7 64 64 64s64-28.7 64-64c0-6.2-.9-12.2-2.5-17.9zM32 256l0 32c0 17.7 14.3 32 32 32l128 0c1.8 0 3.5-.1 5.2-.4L53 208.6C40.1 220.3 32 237.2 32 256zm190.2 42.5c1.1-3.3 1.8-6.8 1.8-10.5l0-32c0-35.3-28.7-64-64-64l-64 0c-3.7 0-7.4 .3-10.9 .9L222.2 298.5zM384 160a64 64 0 1 0 0-128 64 64 0 1 0 0 128zm-32 32c-35.3 0-64 28.7-64 64l0 32c0 17.7 14.3 32 32 32l128 0c17.7 0 32-14.3 32-32l0-32c0-35.3-28.7-64-64-64l-64 0zM215.8 450.1c5.2-4.6 8.2-11.1 8.2-18.1s-3-13.5-8.2-18.1l-64-56c-7.1-6.2-17.1-7.7-25.7-3.8S112 366.6 112 376l0 32-88 0c-13.3 0-24 10.7-24 24s10.7 24 24 24l88 0 0 32c0 9.4 5.5 18 14.1 21.9s18.6 2.4 25.7-3.8l64-56zM288 431.9c0 6.9 2.9 13.5 8.1 18.1l64 56.4c7.1 6.2 17.1 7.8 25.7 3.9s14.1-12.4 14.1-21.9l0-32.4 88 0c13.3 0 24-10.7 24-24s-10.7-24-24-24l-88 0 0-32c0-9.4-5.5-18-14.1-21.9s-18.6-2.4-25.7 3.8l-64 56c-5.2 4.5-8.2 11.1-8.2 18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
