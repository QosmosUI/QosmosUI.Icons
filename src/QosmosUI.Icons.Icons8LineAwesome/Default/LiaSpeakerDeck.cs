// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaSpeakerDeck : ComponentBase
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
		builder.AddAttribute(14, "d", "M 8 8 C 5.243 8 3 10.243 3 13 C 3 15.757 5.243 18 8 18 L 14 18 C 14.551 18 15 18.448 15 19 C 15 19.552 14.551 20 14 20 L 5 20 C 3.896 20 3 20.896 3 22 C 3 23.104 3.896 24 5 24 L 14 24 C 16.757 24 19 21.757 19 19 C 19 16.243 16.757 14 14 14 L 8 14 C 7.449 14 7 13.552 7 13 C 7 12.448 7.449 12 8 12 L 15 12 C 16.104 12 17 11.104 17 10 C 17 8.896 16.104 8 15 8 L 8 8 z M 18.445312 8 C 18.789313 8.59 19 9.268 19 10 C 19 10.734 18.783453 11.409 18.439453 12 L 24 12 C 24.552 12 25 12.448 25 13 L 25 19 C 25 19.552 24.552 20 24 20 L 20.919922 20 C 20.695922 21.556 19.963672 22.949 18.888672 24 L 25 24 C 27.209 24 29 22.209 29 20 L 29 12 C 29 9.791 27.209 8 25 8 L 18.445312 8 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
