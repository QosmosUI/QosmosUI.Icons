// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaEnvelopeOpenTextSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 10 5 L 10 6.9003906 L 4.0078125 10.802734 L 4.0078125 27 L 27.992188 27 L 27.992188 10.802734 L 22 6.8984375 L 22 5 L 10 5 z M 12 7 L 20 7 L 20 14.681641 L 16 17.273438 L 12 14.681641 L 12 7 z M 13 9 L 13 11 L 19 11 L 19 9 L 13 9 z M 10 9.2851562 L 10 13.386719 L 6.84375 11.341797 L 10 9.2851562 z M 22 9.2851562 L 25.15625 11.341797 L 22 13.386719 L 22 9.2851562 z M 13 12 L 13 14 L 19 14 L 19 12 L 13 12 z M 6.0078125 13.183594 L 16 19.65625 L 25.992188 13.183594 L 25.992188 25 L 6.0078125 25 L 6.0078125 13.183594 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
