// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaVoicemailSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 8 9 C 4.144531 9 1 12.144531 1 16 C 1 19.855469 4.144531 23 8 23 L 24 23 C 27.855469 23 31 19.855469 31 16 C 31 12.144531 27.855469 9 24 9 C 20.144531 9 17 12.144531 17 16 C 17 17.957031 17.820313 19.726563 19.125 21 L 12.875 21 C 14.179688 19.726563 15 17.957031 15 16 C 15 12.144531 11.855469 9 8 9 Z M 8 11 C 10.773438 11 13 13.226563 13 16 C 13 18.773438 10.773438 21 8 21 C 5.226563 21 3 18.773438 3 16 C 3 13.226563 5.226563 11 8 11 Z M 24 11 C 26.773438 11 29 13.226563 29 16 C 29 18.773438 26.773438 21 24 21 C 21.226563 21 19 18.773438 19 16 C 19 13.226563 21.226563 11 24 11 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
