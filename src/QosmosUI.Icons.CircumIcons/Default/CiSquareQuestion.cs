// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiSquareQuestion : ComponentBase
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
		builder.AddAttribute(14, "id", "Square_Question");
		builder.AddAttribute(15, "data-name", "Square Question");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M11.41,12.461a1.555,1.555,0,0,1,.341-.6,2.68,2.68,0,0,1,.535-.417,2.2,2.2,0,0,0,.363-.285,1.218,1.218,0,0,0,.256-.364A1.083,1.083,0,0,0,13,10.344a.927.927,0,0,0-.142-.518.946.946,0,0,0-.374-.338,1.135,1.135,0,0,0-.519-.119,1.188,1.188,0,0,0-.5.107.934.934,0,0,0-.389.335.884.884,0,0,0-.111.224.515.515,0,0,1-.483.359h0a.506.506,0,0,1-.479-.675,1.653,1.653,0,0,1,.178-.348,1.789,1.789,0,0,1,.748-.634,2.609,2.609,0,0,1,2.113.015,1.733,1.733,0,0,1,.721.642,1.766,1.766,0,0,1,.257.959,1.833,1.833,0,0,1-.118.678,1.674,1.674,0,0,1-.334.536,2.289,2.289,0,0,1-.52.417,2.245,2.245,0,0,0-.462.37,1.1,1.1,0,0,0-.256.454,2.344,2.344,0,0,0-.045.283.486.486,0,0,1-.483.429h0a.484.484,0,0,1-.483-.53A2.928,2.928,0,0,1,11.41,12.461Z");
		builder.CloseElement();
		builder.OpenElement(20, "circle");
		builder.AddAttribute(21, "cx", "11.792");
		builder.AddAttribute(22, "cy", "14.894");
		builder.AddAttribute(23, "r", "0.587");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M18.438,20.938H5.563a2.5,2.5,0,0,1-2.5-2.5V5.564a2.5,2.5,0,0,1,2.5-2.5H18.438a2.5,2.5,0,0,1,2.5,2.5V18.438A2.5,2.5,0,0,1,18.438,20.938ZM5.563,4.064a1.5,1.5,0,0,0-1.5,1.5V18.438a1.5,1.5,0,0,0,1.5,1.5H18.438a1.5,1.5,0,0,0,1.5-1.5V5.564a1.5,1.5,0,0,0-1.5-1.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
