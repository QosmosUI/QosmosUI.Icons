// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiHelpdesk : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 10.71l6.12-5.31H12c-2.16 0-4.32.06-6.36.21-.84.06-1.5.69-1.56 1.53-.12 1.26-.18 2.85-.18 4.41v.87c0 1.59.06 3.15.18 4.41.09.81.75 1.47 1.56 1.5a90 90 0 0012.72 0c.81-.03 1.5-.69 1.56-1.5.09-1.2.15-2.67.18-4.17L24 9.3V12.66c0 1.59-.06 3.18-.18 4.47a5.57 5.57 0 01-5.19 5.1c-2.13.18-4.38.27-6.63.27s-4.5-.09-6.63-.24a5.57 5.57 0 01-5.19-5.1C.06 15.81 0 14.13 0 12.45v-.87C0 9.9.06 8.22.18 6.84a5.57 5.57 0 015.19-5.1C7.5 1.59 9.75 1.5 12 1.5h12v3.9L12 15.81l-5.61-4.86L9.33 8.4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
