// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiSession : ComponentBase
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
		builder.AddAttribute(15, "d", "m19.431 12.193-4.53-2.51h3.071a4.847 4.847 0 0 0 4.842-4.841A4.848 4.848 0 0 0 17.972 0H7.252a6.073 6.073 0 0 0-6.066 6.066 6.566 6.566 0 0 0 3.383 5.741l4.53 2.51H6.028a4.847 4.847 0 0 0-4.842 4.841A4.848 4.848 0 0 0 6.028 24h10.72a6.073 6.073 0 0 0 6.066-6.066 6.568 6.568 0 0 0-3.383-5.741zm-14.136-1.7a5.065 5.065 0 0 1-2.607-4.309C2.627 3.61 4.79 1.5 7.367 1.5h10.508c1.797 0 3.345 1.378 3.434 3.173a3.345 3.345 0 0 1-3.337 3.51H11.92a.67.67 0 0 0-.67.67l-.001 4.94zM16.633 22.5H6.124c-1.797 0-3.345-1.378-3.434-3.173a3.345 3.345 0 0 1 3.337-3.51h6.053c.37 0 .67-.3.67-.67v-4.94l5.954 3.3a5.065 5.065 0 0 1 2.608 4.309c.06 2.575-2.103 4.684-4.679 4.684");
		builder.CloseElement();
		builder.CloseElement();
    }
}
