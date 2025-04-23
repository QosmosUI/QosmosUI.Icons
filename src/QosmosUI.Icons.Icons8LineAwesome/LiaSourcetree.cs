// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaSourcetree : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 4 C 10.486 4 6 8.486 6 14 C 6 17.983 8.383 21.57725 12 23.15625 L 12 28 L 20 28 L 20 23.15625 C 23.617 21.57725 26 17.983 26 14 C 26 8.486 21.514 4 16 4 z M 16 6 C 20.411 6 24 9.589 24 14 C 24 17.377 21.856016 20.404156 18.666016 21.535156 L 18 21.769531 L 18 26 L 14 26 L 14 21.769531 L 13.333984 21.533203 C 10.143984 20.403203 8 17.377 8 14 C 8 9.589 11.589 6 16 6 z M 16 10 C 13.794 10 12 11.794 12 14 C 12 16.206 13.794 18 16 18 C 18.206 18 20 16.206 20 14 C 20 11.794 18.206 10 16 10 z M 16 12 C 17.103 12 18 12.897 18 14 C 18 15.103 17.103 16 16 16 C 14.897 16 14 15.103 14 14 C 14 12.897 14.897 12 16 12 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
