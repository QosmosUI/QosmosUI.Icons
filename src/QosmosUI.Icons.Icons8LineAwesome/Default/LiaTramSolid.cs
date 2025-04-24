// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaTramSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 10.75 2 L 8.5625 3.09375 L 9.4375 4.90625 L 11.25 4 L 20.75 4 L 22.5625 4.90625 L 23.4375 3.09375 L 21.25 2 Z M 15 5 L 15 6 L 12 6 C 8.699219 6 6 8.699219 6 12 L 6 24 C 6 25.644531 7.355469 27 9 27 L 7 29 L 9.34375 29 L 11.34375 27 L 20.65625 27 L 22.65625 29 L 25 29 L 23 27 C 24.644531 27 26 25.644531 26 24 L 26 12 C 26 8.699219 23.300781 6 20 6 L 17 6 L 17 5 Z M 12 8 L 20 8 C 22.21875 8 24 9.78125 24 12 L 24 16 L 8 16 L 8 12 C 8 9.78125 9.78125 8 12 8 Z M 8 18 L 24 18 L 24 24 C 24 24.566406 23.566406 25 23 25 L 9 25 C 8.433594 25 8 24.566406 8 24 Z M 11.5 20 C 10.671875 20 10 20.671875 10 21.5 C 10 22.328125 10.671875 23 11.5 23 C 12.328125 23 13 22.328125 13 21.5 C 13 20.671875 12.328125 20 11.5 20 Z M 20.5 20 C 19.671875 20 19 20.671875 19 21.5 C 19 22.328125 19.671875 23 20.5 23 C 21.328125 23 22 22.328125 22 21.5 C 22 20.671875 21.328125 20 20.5 20 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
