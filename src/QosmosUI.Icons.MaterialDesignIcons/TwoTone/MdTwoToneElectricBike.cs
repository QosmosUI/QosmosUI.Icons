// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneElectricBike : ComponentBase
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
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M19,7h-0.82l-1.7-4.68C16.19,1.53,15.44,1,14.6,1H12v2h2.6l1.46,4h-4.81l-0.36-1H12V4H7v2h1.75l1.82,5H9.9 C9.46,8.77,7.59,7.12,5.25,7.01C2.45,6.87,0,9.2,0,12c0,2.8,2.2,5,5,5c2.46,0,4.45-1.69,4.9-4h4.2c0.44,2.23,2.31,3.88,4.65,3.99 c2.8,0.13,5.25-2.19,5.25-5C24,9.2,21.8,7,19,7z M7.82,13c-0.4,1.17-1.49,2-2.82,2c-1.68,0-3-1.32-3-3s1.32-3,3-3 c1.33,0,2.42,0.83,2.82,2H5v2H7.82z M14.1,11h-1.4l-0.73-2H15C14.56,9.58,14.24,10.25,14.1,11z M19,15c-1.68,0-3-1.32-3-3 c0-0.93,0.41-1.73,1.05-2.28l0.96,2.64l1.88-0.68l-0.97-2.67C18.94,9.01,18.97,9,19,9c1.68,0,3,1.32,3,3S20.68,15,19,15z");
		builder.CloseElement();
		builder.OpenElement(22, "polygon");
		builder.AddAttribute(23, "points", "11,20 7,20 13,23 13,21 17,21 11,18");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
