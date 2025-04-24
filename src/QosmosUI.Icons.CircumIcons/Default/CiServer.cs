// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiServer : ComponentBase
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
		builder.AddAttribute(14, "id", "Server");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.437,11H3.563a1.5,1.5,0,0,1-1.5-1.5V5.565a1.5,1.5,0,0,1,1.5-1.5H20.437a1.5,1.5,0,0,1,1.5,1.5v3.93A1.5,1.5,0,0,1,20.437,11ZM3.563,5.065a.5.5,0,0,0-.5.5v3.93a.5.5,0,0,0,.5.5H20.437a.5.5,0,0,0,.5-.5V5.565a.5.5,0,0,0-.5-.5Z");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M20.437,19.935H3.563a1.5,1.5,0,0,1-1.5-1.5v-3.93a1.5,1.5,0,0,1,1.5-1.5H20.437a1.5,1.5,0,0,1,1.5,1.5v3.93A1.5,1.5,0,0,1,20.437,19.935ZM3.563,14.005a.5.5,0,0,0-.5.5v3.93a.5.5,0,0,0,.5.5H20.437a.5.5,0,0,0,.5-.5v-3.93a.5.5,0,0,0-.5-.5Z");
		builder.CloseElement();
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "5.563");
		builder.AddAttribute(22, "cy", "7.53");
		builder.AddAttribute(23, "r", "0.5");
		builder.CloseElement();
		builder.OpenElement(24, "circle");
		builder.AddAttribute(25, "cx", "7.563");
		builder.AddAttribute(26, "cy", "7.53");
		builder.AddAttribute(27, "r", "0.5");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M13.452,8.03a.5.5,0,0,1,0-1h5a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.OpenElement(30, "circle");
		builder.AddAttribute(31, "cx", "5.563");
		builder.AddAttribute(32, "cy", "16.47");
		builder.AddAttribute(33, "r", "0.5");
		builder.CloseElement();
		builder.OpenElement(34, "circle");
		builder.AddAttribute(35, "cx", "7.563");
		builder.AddAttribute(36, "cy", "16.47");
		builder.AddAttribute(37, "r", "0.5");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "d", "M13.452,16.97a.5.5,0,0,1,0-1h5a.5.5,0,0,1,0,1Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
