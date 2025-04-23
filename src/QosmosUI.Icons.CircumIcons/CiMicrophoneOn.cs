// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiMicrophoneOn : ComponentBase
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
		builder.AddAttribute(14, "id", "Microphone_On");
		builder.AddAttribute(15, "data-name", "Microphone On");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M11.989,2.065a4.507,4.507,0,0,0-4.5,4.5v5.76a4.5,4.5,0,0,0,9,0V6.565A4.507,4.507,0,0,0,11.989,2.065Zm0,13.76a3.5,3.5,0,0,1-3.5-3.5V6.565a3.5,3.5,0,0,1,6.94-.62h-1.87a.5.5,0,0,0-.5.5.5.5,0,0,0,.5.5h1.93v2h-1.93a.5.5,0,0,0-.5.5.508.508,0,0,0,.5.5h1.93v2h-1.94a.508.508,0,0,0-.5.5.515.515,0,0,0,.5.5h1.88A3.492,3.492,0,0,1,11.989,15.825Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M12.489,18.925v2.01h3.5a.5.5,0,0,1,0,1h-8a.5.5,0,0,1,0-1h3.5v-1.99a6.055,6.055,0,0,1-2.74-.88,6.291,6.291,0,0,1-2.97-5.14c-.03-1.04,0-2.09,0-3.13a.5.5,0,0,1,1,0c0,1.04-.03,2.09,0,3.13A5.212,5.212,0,0,0,17.2,12.7c.01-.96,0-1.93,0-2.9a.5.5,0,0,1,1,0,26.322,26.322,0,0,1-.08,3.97A6.235,6.235,0,0,1,12.489,18.925Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
