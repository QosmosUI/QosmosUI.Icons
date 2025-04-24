// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiCloud : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Cloud");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M17.1,19.4H9.646a7.492,7.492,0,0,1-7.588-7.046h0A7.4,7.4,0,0,1,9.452,4.6a7.434,7.434,0,0,1,7.136,5.447,4.731,4.731,0,0,1,4.092,1.441,4.664,4.664,0,0,1,1.26,3.529A4.789,4.789,0,0,1,17.1,19.4ZM3.057,12.309A6.493,6.493,0,0,0,9.646,18.4H17.1a3.787,3.787,0,0,0,3.839-3.453,3.7,3.7,0,0,0-4.5-3.86l-.2.046-.269-.127a.617.617,0,0,1-.273-.392A6.422,6.422,0,0,0,9.452,5.6a6.4,6.4,0,0,0-6.395,6.711Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
