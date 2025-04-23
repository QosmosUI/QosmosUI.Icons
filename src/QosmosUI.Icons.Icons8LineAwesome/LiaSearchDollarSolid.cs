// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaSearchDollarSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 19 3 C 13.489 3 9 7.489 9 13 C 9 15.395 9.839 17.5875 11.25 19.3125 L 3.28125 27.28125 L 4.71875 28.720703 L 12.6875 20.751953 C 14.4115 22.161953 16.605 23 19 23 C 24.511 23 29 18.511 29 13 C 29 7.489 24.511 3 19 3 z M 19 5 C 23.43 5 27 8.57 27 13 C 27 17.43 23.43 21 19 21 C 14.57 21 11 17.43 11 13 C 11 8.57 14.57 5 19 5 z M 18 8 L 18 9.0625 C 16.875 9.2505 16 10.204953 16 11.376953 C 16 12.130953 16.41775 12.82025 17.09375 13.15625 L 20 14.625 C 20 14.848 19.848 15 19.625 15 L 18.375 15 C 18.152 15 18 14.848 18 14.625 L 18 14 L 16 14 L 16 14.625 C 16 15.797 16.875 16.7495 18 16.9375 L 18 18 L 20 18 L 20 16.9375 C 21.125 16.7495 22 15.795047 22 14.623047 C 22 13.869047 21.58225 13.18375 20.90625 12.84375 L 18 11.375 C 18 11.152 18.152 11 18.375 11 L 19.625 11 C 19.848 11 20 11.152 20 11.375 L 20 12 L 22 12 L 22 11.375 C 22 10.203 21.125 9.2505 20 9.0625 L 20 8 L 18 8 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
