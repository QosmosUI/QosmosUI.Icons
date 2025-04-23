// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiCloudOn : ComponentBase
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
		builder.AddAttribute(14, "id", "Cloud_On");
		builder.AddAttribute(15, "data-name", "Cloud On");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M21.917,13.484a4.381,4.381,0,0,0-5.19-4.26,6.281,6.281,0,0,0-11.75,2.19,3.237,3.237,0,0,0-2.66,2,3.433,3.433,0,0,0,.82,3.74c1.12,1.03,2.54.89,3.94.89h10.15a4.514,4.514,0,0,0,4.69-4.32Zm-4.65,3.56c-1.19.01-2.38,0-3.56,0-2.75,0-5.49.06-8.23,0a2.383,2.383,0,0,1-2.33-1.73,2.333,2.333,0,0,1,2.28-2.94.515.515,0,0,0,.5-.5,5.3,5.3,0,0,1,10.11-1.81.5.5,0,0,0,.56.23,3.366,3.366,0,0,1,4.33,3.32A3.489,3.489,0,0,1,17.267,17.044Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
