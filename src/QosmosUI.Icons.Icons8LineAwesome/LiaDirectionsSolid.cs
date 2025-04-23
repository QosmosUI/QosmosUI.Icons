// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaDirectionsSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 3 C 15.23 3 14.457 3.293 13.875 3.875 L 13.75 4.03125 L 4.03125 13.75 L 3.875 13.875 C 2.711 15.039 2.711 16.961 3.875 18.125 L 13.875 28.125 C 15.039 29.289 16.961 29.289 18.125 28.125 L 28.125 18.125 C 29.289 16.961 29.289 15.039 28.125 13.875 L 18.125 3.875 C 17.543 3.293 16.77 3 16 3 z M 16 5 C 16.254 5 16.51975 5.08225 16.71875 5.28125 L 26.71875 15.28125 C 27.11675 15.67925 27.11675 16.31975 26.71875 16.71875 L 16.71875 26.71875 C 16.32075 27.11675 15.68025 27.11675 15.28125 26.71875 L 5.28125 16.71875 C 4.88325 16.32075 4.88325 15.68025 5.28125 15.28125 L 15.28125 5.28125 C 15.48025 5.08225 15.746 5 16 5 z M 17 11 L 17 14 L 13 14 C 11.895 14 11 14.895 11 16 L 11 19 L 13 19 L 13 16 L 17 16 L 17 19 L 21 15 L 17 11 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
