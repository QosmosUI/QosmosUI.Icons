// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaClosedCaptioning : ComponentBase
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
		builder.AddAttribute(14, "d", "M 2 6 L 2 23.90625 L 30 23.90625 L 30 6 Z M 4 8 L 28 8 L 28 21.90625 L 4 21.90625 Z M 12 10 C 9.25 10 7 12.25 7 15 C 7 17.75 9.25 20 12 20 C 13.195313 20 14.277344 19.558594 15.125 18.875 L 13.875 17.3125 C 13.347656 17.738281 12.707031 18 12 18 C 10.332031 18 9 16.667969 9 15 C 9 13.332031 10.332031 12 12 12 C 12.707031 12 13.347656 12.261719 13.875 12.6875 L 15.125 11.125 C 14.277344 10.441406 13.195313 10 12 10 Z M 22 10 C 19.25 10 17 12.25 17 15 C 17 17.75 19.25 20 22 20 C 23.195313 20 24.277344 19.558594 25.125 18.875 L 23.875 17.3125 C 23.347656 17.738281 22.707031 18 22 18 C 20.332031 18 19 16.667969 19 15 C 19 13.332031 20.332031 12 22 12 C 22.707031 12 23.347656 12.261719 23.875 12.6875 L 25.125 11.125 C 24.277344 10.441406 23.195313 10 22 10 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
