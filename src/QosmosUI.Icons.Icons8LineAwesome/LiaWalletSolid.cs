// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaWalletSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 22.96875 4 C 22.816406 4.003906 22.65625 4.023438 22.5 4.0625 L 6.25 8.34375 C 4.9375 8.6875 4 9.890625 4 11.25 L 4 25 C 4 26.644531 5.355469 28 7 28 L 25 28 C 26.644531 28 28 26.644531 28 25 L 28 12 C 28 10.355469 26.644531 9 25 9 L 11.625 9 L 23 6 L 23 8 L 25 8 L 25 6 C 25 4.875 24.042969 3.984375 22.96875 4 Z M 7 11 L 25 11 C 25.566406 11 26 11.433594 26 12 L 26 25 C 26 25.566406 25.566406 26 25 26 L 7 26 C 6.433594 26 6 25.566406 6 25 L 6 12 C 6 11.433594 6.433594 11 7 11 Z M 22.5 17 C 21.671875 17 21 17.671875 21 18.5 C 21 19.328125 21.671875 20 22.5 20 C 23.328125 20 24 19.328125 24 18.5 C 24 17.671875 23.328125 17 22.5 17 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
