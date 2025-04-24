// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoSkull : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M402,76.94C362.61,37.63,310.78,16,256,16h-.37A208,208,0,0,0,48,224V324.67A79.62,79.62,0,0,0,98.29,399L122,408.42a15.92,15.92,0,0,1,9.75,11.72l10,50.13A32.09,32.09,0,0,0,173.12,496H184a8,8,0,0,0,8-8V448.45c0-8.61,6.62-16,15.23-16.43A16,16,0,0,1,224,448v40a8,8,0,0,0,8,8h0a8,8,0,0,0,8-8V448.45c0-8.61,6.62-16,15.23-16.43A16,16,0,0,1,272,448v40a8,8,0,0,0,8,8h0a8,8,0,0,0,8-8V448.45c0-8.61,6.62-16,15.23-16.43A16,16,0,0,1,320,448v40a8,8,0,0,0,8,8h10.88a32.09,32.09,0,0,0,31.38-25.72l10-50.14A16,16,0,0,1,390,408.42L413.71,399A79.62,79.62,0,0,0,464,324.67v-99C464,169.67,442,116.86,402,76.94ZM171.66,335.88a56,56,0,1,1,52.22-52.22A56,56,0,0,1,171.66,335.88ZM281,397.25A16.37,16.37,0,0,1,271.7,400H240.3a16.37,16.37,0,0,1-9.28-2.75,16,16,0,0,1-6.6-16.9l15.91-47.6C243,326,247.25,321,254,320.13c8.26-1,14,2.87,17.61,12.22l16,48A16,16,0,0,1,281,397.25Zm66.68-61.37a56,56,0,1,1,52.22-52.22A56,56,0,0,1,347.66,335.88Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
