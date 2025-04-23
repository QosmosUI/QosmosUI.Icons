// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiSliderVertical : ComponentBase
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
		builder.AddAttribute(14, "id", "Slider_Vertical");
		builder.AddAttribute(15, "data-name", "Slider Vertical");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M8.5,5.13V2.55a.5.5,0,0,0-.5-.5.508.508,0,0,0-.5.5V5.13A2,2,0,0,0,6,7.06v1A2,2,0,0,0,7.5,9.99V21.45a.5.5,0,0,0,1,0V9.99A2,2,0,0,0,10,8.06v-1A2,2,0,0,0,8.5,5.13ZM9,8.06a1,1,0,1,1-2,0v-1a1.006,1.006,0,0,1,.98-1H8a1,1,0,0,1,1,1Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M16.5,14.01V2.55a.5.5,0,0,0-1,0V14.01A2,2,0,0,0,14,15.94v1a2,2,0,0,0,1.5,1.93v2.58a.5.5,0,0,0,.5.5.508.508,0,0,0,.5-.5V18.87A2,2,0,0,0,18,16.94v-1A2,2,0,0,0,16.5,14.01Zm.5,2.93a1.006,1.006,0,0,1-.98,1H16a1,1,0,0,1-1-1v-1a1,1,0,1,1,2,0Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
