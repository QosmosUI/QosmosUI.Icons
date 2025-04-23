// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaBlenderSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 8 5 C 6.346 5 5 6.346 5 8 L 5 13 C 5 14.654 6.346 16 8 16 L 11.242188 16 L 11.869141 21.013672 C 10.276981 21.083943 9 22.390848 9 24 L 9 27 L 26 27 L 26 24 C 26 22.432317 24.786487 21.155867 23.251953 21.025391 L 26.957031 5 L 14 5 L 9.8671875 5 L 8 5 z M 8 7 L 10.117188 7 L 10.992188 14 L 8 14 C 7.449 14 7 13.551 7 13 L 7 8 C 7 7.449 7.449 7 8 7 z M 12.132812 7 L 14 7 L 24.441406 7 L 23.978516 9 L 19 9 L 19 11 L 23.517578 11 L 23.054688 13 L 19 13 L 19 15 L 22.591797 15 L 22.128906 17 L 19 17 L 19 19 L 21.667969 19 L 21.205078 21 L 13.882812 21 L 12.132812 7 z M 12 23 L 23 23 C 23.551 23 24 23.449 24 24 L 24 25 L 11 25 L 11 24 C 11 23.449 11.449 23 12 23 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
