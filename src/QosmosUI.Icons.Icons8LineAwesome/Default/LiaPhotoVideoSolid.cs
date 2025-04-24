// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaPhotoVideoSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 10 2 L 10 9 L 12 9 L 12 4 L 14 4 L 14 5 L 16 5 L 16 4 L 25 4 L 25 5 L 27 5 L 27 4 L 29 4 L 29 16 L 27 16 L 27 15 L 25 15 L 25 18 L 31 18 L 31 2 L 10 2 z M 14 7 L 14 9 L 16 9 L 16 7 L 14 7 z M 25 7 L 25 9 L 27 9 L 27 7 L 25 7 z M 2 11 L 2 29 L 23 29 L 23 11 L 2 11 z M 25 11 L 25 13 L 27 13 L 27 11 L 25 11 z M 4 13 L 21 13 L 21 22.78125 L 18.40625 20.1875 L 17.6875 19.5 L 14.875 22.3125 L 10.59375 18 L 9.90625 17.28125 L 4 23.1875 L 4 13 z M 15.5 15 C 14.671 15 14 15.671 14 16.5 C 14 17.329 14.671 18 15.5 18 C 16.329 18 17 17.329 17 16.5 C 17 15.671 16.329 15 15.5 15 z M 9.9042969 20.125 L 14.904297 25.125 L 15.59375 24.40625 L 17.6875 22.3125 L 21 25.625 L 21 27 L 4 27 L 4 26.03125 L 9.9042969 20.125 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
