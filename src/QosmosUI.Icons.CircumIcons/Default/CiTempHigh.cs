// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiTempHigh : ComponentBase
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
		builder.AddAttribute(14, "id", "Temp_High");
		builder.AddAttribute(15, "data-name", "Temp High");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M14.863,13.4V4.939a2.929,2.929,0,0,0-.84-2.03,2.859,2.859,0,0,0-2.23-.82,2.948,2.948,0,0,0-2.66,3l.01,8.28a4.755,4.755,0,0,0,1.9,8.46,5.093,5.093,0,0,0,.95.09,4.759,4.759,0,0,0,4.76-4.75A4.684,4.684,0,0,0,14.863,13.4Zm-.48,6.66a3.783,3.783,0,0,1-3.15.78,3.7,3.7,0,0,1-2.92-2.98,3.745,3.745,0,0,1,1.43-3.69.962.962,0,0,0,.39-.77V5.089a1.968,1.968,0,0,1,1.73-2,.66.66,0,0,1,.14-.01,1.878,1.878,0,0,1,1.86,1.86V13.4a.962.962,0,0,0,.39.77,3.742,3.742,0,0,1,.13,5.89Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M13.893,17.169a1.89,1.89,0,0,1-3.78,0,1.858,1.858,0,0,1,1.39-1.81V5.4a.5.5,0,0,1,1,0v9.96A1.869,1.869,0,0,1,13.893,17.169Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
