// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaIdCardAltSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 15 5 C 13.90625 5 13 5.90625 13 7 L 13 8 L 4 8 L 4 26 L 28 26 L 28 8 L 19 8 L 19 7 C 19 5.90625 18.09375 5 17 5 Z M 15 7 L 17 7 L 17 9 L 15 9 Z M 6 10 L 13 10 L 13 11 L 19 11 L 19 10 L 26 10 L 26 24 L 6 24 Z M 16 12 C 13.800781 12 12 13.800781 12 16 C 12 17.117188 12.46875 18.128906 13.214844 18.855469 C 11.878906 19.757813 11 21.28125 11 23 L 13 23 C 13 21.332031 14.332031 20 16 20 C 17.667969 20 19 21.332031 19 23 L 21 23 C 21 21.28125 20.121094 19.757813 18.785156 18.855469 C 19.53125 18.128906 20 17.117188 20 16 C 20 13.800781 18.199219 12 16 12 Z M 16 14 C 17.117188 14 18 14.882813 18 16 C 18 17.117188 17.117188 18 16 18 C 14.882813 18 14 17.117188 14 16 C 14 14.882813 14.882813 14 16 14 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
