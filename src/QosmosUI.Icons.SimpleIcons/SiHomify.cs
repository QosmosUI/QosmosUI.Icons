// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiHomify : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M20.383 10.561a1.727 1.727 0 0 1 0 .055l-.004.048c-.088 2.33-.057 11.357-.057 11.823.002 1.078-.826 1.943-1.596 1.283l-6.98-5.53a373.72 373.72 0 0 1-4.742 4.925c-.977.946-1.786-1.327-1.045-1.808.066-.042 2.223-1.95 4.61-4.05L5.4 13.214c-.446-.356-.618-.946-.363-1.261a.46.46 0 0 1 .328-.127.47.47 0 0 1 .164.037c1.596.722 3.962 2.492 6.314 4.329 2.45-2.15 4.805-4.191 5.116-4.364.38-.214.48.354.354.516-.131.166-2.169 2.326-4.408 4.678 2.204 1.732 4.294 3.389 5.614 4.137l.217-10.62c-.17-.206-5.332-7.163-5.892-7.746-.892.78-5.566 6.112-5.802 6.342 1.067.11 5.597.382 8.452.684.721.07 1.2.606-.346.59l-11.105-.015a.44.44 0 0 1-.394-.267.415.415 0 0 1 .094-.457C3.8 9.613 11.782.748 12.454.184A.702.702 0 0 1 12.935 0a.732.732 0 0 1 .483.227c.083.077 4.292 5.94 6.344 8.802.492.678.617 1.137.621 1.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
