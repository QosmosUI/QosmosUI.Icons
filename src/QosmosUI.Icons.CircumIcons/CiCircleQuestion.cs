// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiCircleQuestion : ComponentBase
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
		builder.AddAttribute(14, "id", "Circle_Question");
		builder.AddAttribute(15, "data-name", "Circle Question");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M11.411,12.459a1.547,1.547,0,0,1,.341-.6,2.644,2.644,0,0,1,.535-.417,2.2,2.2,0,0,0,.363-.286,1.2,1.2,0,0,0,.256-.363A1.084,1.084,0,0,0,13,10.341a.923.923,0,0,0-.142-.517.938.938,0,0,0-.374-.338,1.123,1.123,0,0,0-.519-.119,1.173,1.173,0,0,0-.495.107.934.934,0,0,0-.389.335.884.884,0,0,0-.111.224.516.516,0,0,1-.483.359h0a.506.506,0,0,1-.479-.675,1.661,1.661,0,0,1,.178-.349,1.8,1.8,0,0,1,.748-.634,2.437,2.437,0,0,1,1.031-.215,2.4,2.4,0,0,1,1.082.231,1.737,1.737,0,0,1,.721.641,1.772,1.772,0,0,1,.257.96,1.841,1.841,0,0,1-.118.678,1.685,1.685,0,0,1-.334.536,2.289,2.289,0,0,1-.52.417,2.277,2.277,0,0,0-.462.369,1.113,1.113,0,0,0-.256.455,2.344,2.344,0,0,0-.045.283.487.487,0,0,1-.483.429h0a.484.484,0,0,1-.483-.531A2.931,2.931,0,0,1,11.411,12.459Z");
		builder.CloseElement();
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "11.793");
		builder.AddAttribute(22, "cy", "14.891");
		builder.AddAttribute(23, "r", "0.587");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12,21.931A9.934,9.934,0,1,1,21.934,12,9.945,9.945,0,0,1,12,21.931ZM12,3.064A8.934,8.934,0,1,0,20.934,12,8.943,8.943,0,0,0,12,3.064Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
