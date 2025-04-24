// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPrescriptionBottleAltSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 9.9277344 3 C 8.9747344 3 8.1174063 3.5308125 7.6914062 4.3828125 L 7.3828125 5 L 7 5 C 5.897 5 5 5.897 5 7 L 5 11 L 6 11 L 6 27 C 6 28.103 6.897 29 8 29 L 24 29 C 25.103 29 26 28.103 26 27 L 26 11 L 27 11 L 27 7 C 27 5.897 26.103 5 25 5 L 24.617188 5 L 24.308594 4.3828125 C 23.883594 3.5308125 23.026266 3 22.072266 3 L 9.9277344 3 z M 9.9277344 5 L 22.072266 5 C 22.263266 5 22.434531 5.1053906 22.519531 5.2753906 L 23.382812 7 L 25 7 L 25 9 L 7 9 L 7 7 L 8.6171875 7 L 9.4804688 5.2753906 C 9.5654687 5.1053906 9.7367344 5 9.9277344 5 z M 8 11 L 24 11 L 24 27 L 8 27 L 8 11 z M 15 14 L 15 18 L 11 18 L 11 20 L 15 20 L 15 24 L 17 24 L 17 20 L 21 20 L 21 18 L 17 18 L 17 14 L 15 14 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
