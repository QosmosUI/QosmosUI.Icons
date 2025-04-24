// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiElasticcloud : ComponentBase
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
		builder.AddAttribute(15, "d", "M13.318 0c-6.628 0-12 5.372-12 12 0 2.008.495 3.9 1.368 5.563a14.299 14.299 0 0 1 5.09-3.664c.307-.13.624-.22.948-.28A4.842 4.842 0 0 1 8.443 12a4.875 4.875 0 0 1 7.494-4.11 2.218 2.218 0 0 0 2.055.164 12.047 12.047 0 0 0 4.69-3.554A11.975 11.975 0 0 0 13.318 0zM9.426 15.77c-.266.01-.531.069-.783.175a12.044 12.044 0 0 0-4.69 3.555c2.2 2.742 5.576 4.5 9.365 4.5 3.789 0 7.165-1.758 9.364-4.5a12.048 12.048 0 0 0-4.69-3.555 2.217 2.217 0 0 0-2.055.165 4.845 4.845 0 0 1-2.62.765 4.846 4.846 0 0 1-2.618-.765 2.193 2.193 0 0 0-1.273-.34z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
