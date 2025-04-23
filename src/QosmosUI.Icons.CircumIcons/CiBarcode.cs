// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiBarcode : ComponentBase
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
		builder.AddAttribute(14, "id", "Barcode");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M8.066,4.065H3.648a1.732,1.732,0,0,0-.963.189A1.368,1.368,0,0,0,2.066,5.48v4.585a.5.5,0,0,0,1,0V5.785a1.794,1.794,0,0,1,.014-.518c.077-.236.319-.2.514-.2H8.066a.5.5,0,0,0,0-1Z");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M2.063,13.937v4.418a1.733,1.733,0,0,0,.189.963,1.369,1.369,0,0,0,1.227.619H8.063a.5.5,0,0,0,0-1H3.783a1.831,1.831,0,0,1-.518-.014c-.236-.077-.2-.319-.2-.514V13.937a.5.5,0,0,0-1,0Z");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M15.934,19.935h4.418a1.732,1.732,0,0,0,.963-.189,1.368,1.368,0,0,0,.619-1.226V13.935a.5.5,0,0,0-1,0v4.28a1.794,1.794,0,0,1-.014.518c-.077.236-.319.2-.514.2H15.934a.5.5,0,0,0,0,1Z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M21.937,10.063V5.645a1.733,1.733,0,0,0-.189-.963,1.369,1.369,0,0,0-1.227-.619H15.937a.5.5,0,0,0,0,1h4.28a1.831,1.831,0,0,1,.518.014c.236.077.2.319.2.514v4.472a.5.5,0,0,0,1,0Z");
		builder.CloseElement();
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "10.999");
		builder.AddAttribute(27, "y", "7.643");
		builder.AddAttribute(28, "width", "1");
		builder.AddAttribute(29, "height", "8.709");
		builder.AddAttribute(30, "rx", "0.5");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "14.249");
		builder.AddAttribute(33, "y", "7.643");
		builder.AddAttribute(34, "width", "1");
		builder.AddAttribute(35, "height", "8.709");
		builder.AddAttribute(36, "rx", "0.5");
		builder.CloseElement();
		builder.OpenElement(37, "rect");
		builder.AddAttribute(38, "x", "16.499");
		builder.AddAttribute(39, "y", "7.643");
		builder.AddAttribute(40, "width", "1");
		builder.AddAttribute(41, "height", "8.709");
		builder.AddAttribute(42, "rx", "0.5");
		builder.CloseElement();
		builder.OpenElement(43, "rect");
		builder.AddAttribute(44, "x", "6.499");
		builder.AddAttribute(45, "y", "7.643");
		builder.AddAttribute(46, "width", "1");
		builder.AddAttribute(47, "height", "8.709");
		builder.AddAttribute(48, "rx", "0.5");
		builder.CloseElement();
		builder.OpenElement(49, "rect");
		builder.AddAttribute(50, "x", "8.499");
		builder.AddAttribute(51, "y", "7.643");
		builder.AddAttribute(52, "width", "1.5");
		builder.AddAttribute(53, "height", "8.709");
		builder.AddAttribute(54, "rx", "0.75");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
