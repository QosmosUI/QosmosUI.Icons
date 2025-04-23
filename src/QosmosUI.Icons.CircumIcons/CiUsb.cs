// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiUsb : ComponentBase
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
		builder.AddAttribute(14, "id", "Usb");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.44,8.355H18.31v-.14a1.443,1.443,0,0,0-1.44-1.45H7.29a5.235,5.235,0,0,0,0,10.47h9.58a1.443,1.443,0,0,0,1.44-1.45v-.14h2.13a1.511,1.511,0,0,0,1.5-1.5V9.855A1.5,1.5,0,0,0,20.44,8.355Zm-3.13,7.43a.446.446,0,0,1-.44.45H7.29a4.235,4.235,0,0,1,0-8.47h9.58a.446.446,0,0,1,.44.45Zm3.63-1.64a.508.508,0,0,1-.5.5H18.31V9.355h2.13a.5.5,0,0,1,.5.5Z");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M6.29,13.444A1.446,1.446,0,1,1,7.738,12,1.447,1.447,0,0,1,6.29,13.444Zm0-1.892A.446.446,0,1,0,6.738,12,.446.446,0,0,0,6.29,11.552Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
