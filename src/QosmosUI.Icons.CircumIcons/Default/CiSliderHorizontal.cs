// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiSliderHorizontal : ComponentBase
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
		builder.AddAttribute(14, "id", "Slider_Horizontal");
		builder.AddAttribute(15, "data-name", "Slider Horizontal");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M21.45,7.5H9.99A2,2,0,0,0,8.06,6h-1A2,2,0,0,0,5.13,7.5H2.55a.5.5,0,0,0-.5.5.508.508,0,0,0,.5.5H5.13A2,2,0,0,0,7.06,10h1A2,2,0,0,0,9.99,8.5H21.45A.5.5,0,0,0,21.45,7.5ZM8.06,9h-1a1.006,1.006,0,0,1-1-.98V8a1,1,0,0,1,1-1h1a1,1,0,1,1,0,2Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M21.45,15.5H18.87A2,2,0,0,0,16.94,14h-1a2,2,0,0,0-1.93,1.5H2.55a.5.5,0,0,0,0,1H14.01A2,2,0,0,0,15.94,18h1a2,2,0,0,0,1.93-1.5h2.58a.5.5,0,0,0,.5-.5A.508.508,0,0,0,21.45,15.5Zm-3.51.5a1,1,0,0,1-1,1h-1a1,1,0,1,1,0-2h1a1.006,1.006,0,0,1,1,.98Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
