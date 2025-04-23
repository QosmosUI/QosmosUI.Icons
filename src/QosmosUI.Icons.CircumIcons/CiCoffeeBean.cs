// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiCoffeeBean : ComponentBase
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
		builder.AddAttribute(14, "id", "Coffee_Bean");
		builder.AddAttribute(15, "data-name", "Coffee Bean");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M19.151,4.868a6.744,6.744,0,0,0-5.96-1.69,12.009,12.009,0,0,0-6.54,3.47,11.988,11.988,0,0,0-3.48,6.55,6.744,6.744,0,0,0,1.69,5.95,6.406,6.406,0,0,0,4.63,1.78,11.511,11.511,0,0,0,7.87-3.56C21.3,13.428,22.1,7.818,19.151,4.868Zm-14.99,8.48a11.041,11.041,0,0,1,3.19-5.99,10.976,10.976,0,0,1,5.99-3.19,8.016,8.016,0,0,1,1.18-.09,5.412,5.412,0,0,1,3.92,1.49.689.689,0,0,1,.11.13,6.542,6.542,0,0,1-2.12,1.23,7.666,7.666,0,0,0-2.96,1.93,7.666,7.666,0,0,0-1.93,2.96,6.589,6.589,0,0,1-1.71,2.63,6.7,6.7,0,0,1-2.63,1.71,7.478,7.478,0,0,0-2.35,1.36A6.18,6.18,0,0,1,4.161,13.348Zm12.49,3.31c-3.55,3.55-8.52,4.35-11.08,1.79a1.538,1.538,0,0,1-.12-.13,6.677,6.677,0,0,1,2.13-1.23,7.862,7.862,0,0,0,2.96-1.93,7.738,7.738,0,0,0,1.93-2.96,6.589,6.589,0,0,1,1.71-2.63,6.589,6.589,0,0,1,2.63-1.71,7.6,7.6,0,0,0,2.34-1.37C20.791,9.2,19.821,13.488,16.651,16.658Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
