// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiCloudOff : ComponentBase
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
		builder.AddAttribute(14, "id", "Cloud_Off");
		builder.AddAttribute(15, "data-name", "Cloud Off");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M20.8,16.577c-.41.49-1.12-.22-.7-.71a3.585,3.585,0,0,0,.37-4.04A3.266,3.266,0,0,0,16.6,10.3a.5.5,0,0,1-.56-.23,5.391,5.391,0,0,0-5.3-3.1c-.64.04-.64-.96,0-1a6.346,6.346,0,0,1,5.99,3.26,4.255,4.255,0,0,1,4.6,2.1A4.579,4.579,0,0,1,20.8,16.577Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M4.941,4.237a.5.5,0,0,0-.7.7l2.69,2.69a6.273,6.273,0,0,0-1.94,3.78,3.342,3.342,0,0,0-2.65,4.6,3.518,3.518,0,0,0,3.48,2.05h11.53c.58.57,1.14,1.14,1.71,1.71a.5.5,0,0,0,.71-.71Zm.3,12.81a2.352,2.352,0,0,1-2.16-2.25,2.309,2.309,0,0,1,2.35-2.42.515.515,0,0,0,.5-.5,5.377,5.377,0,0,1,1.71-3.54q4.35,4.365,8.71,8.72Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
