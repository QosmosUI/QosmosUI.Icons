// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaBullhornSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 28 3.03125 L 26.40625 4.1875 C 26.40625 4.1875 24.417969 5.664063 21.5625 7.125 C 18.707031 8.585938 14.988281 10 11.71875 10 L 2 10 L 2 19.125 L 2.03125 19.28125 L 4.03125 26.28125 L 4.25 27 L 10.3125 27 L 9.96875 25.71875 L 8.34375 20 L 11.71875 20 C 14.945313 20 18.664063 21.441406 21.53125 22.90625 C 24.398438 24.371094 26.40625 25.8125 26.40625 25.8125 L 28 26.96875 L 28 17.8125 C 29.15625 17.394531 30 16.292969 30 15 C 30 13.707031 29.15625 12.605469 28 12.1875 Z M 26 6.75 L 26 23.21875 C 25.171875 22.660156 24.515625 22.152344 22.4375 21.09375 C 19.5 19.59375 15.707031 18.074219 12 18 L 12 12 C 15.742188 11.925781 19.539063 10.375 22.46875 8.875 C 24.542969 7.8125 25.179688 7.308594 26 6.75 Z M 4 12 L 10 12 L 10 18 L 4 18 Z M 4.34375 20 L 6.25 20 L 7.65625 25 L 5.75 25 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
