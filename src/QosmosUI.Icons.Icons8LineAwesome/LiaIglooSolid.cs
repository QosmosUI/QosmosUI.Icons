// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaIglooSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 6 C 8.832 6 3 11.832 3 19 L 3 26 L 29 26 L 29 19 C 29 11.832 23.168 6 16 6 z M 16 8 C 16.337536 8 16.670119 8.0208671 17 8.0507812 L 17 12 L 7.5234375 12 C 9.5427682 9.5591694 12.592398 8 16 8 z M 19 8.4277344 C 21.171617 9.0450088 23.074062 10.304752 24.476562 12 L 19 12 L 19 8.4277344 z M 6.2148438 14 L 8 14 L 8 19 L 5 19 C 5 17.198678 5.4438908 15.50228 6.2148438 14 z M 10 14 L 22 14 L 22 19 L 20.578125 19 C 19.804692 17.23661 18.045613 16 16 16 C 13.954387 16 12.195308 17.23661 11.421875 19 L 10 19 L 10 14 z M 24 14 L 25.785156 14 C 26.556109 15.50228 27 17.198678 27 19 L 24 19 L 24 14 z M 16 18 C 17.654 18 19 19.346 19 21 L 19 24 L 13 24 L 13 21 C 13 19.346 14.346 18 16 18 z M 5 21 L 11 21 L 11 24 L 5 24 L 5 21 z M 21 21 L 27 21 L 27 24 L 21 24 L 21 21 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
