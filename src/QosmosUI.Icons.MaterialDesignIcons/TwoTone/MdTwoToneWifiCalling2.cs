// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneWifiCalling2 : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M16.49,4.5c1.79,0,3.42,0.73,4.59,1.91l1.06-1.06C20.7,3.9,18.7,3,16.49,3c-2.21,0-4.21,0.9-5.66,2.34 l1.06,1.06C13.08,5.23,14.7,4.5,16.49,4.5z");
		builder.AddAttribute(21, "fill-opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M16.49,6c-1.38,0-2.63,0.56-3.54,1.46l1.06,1.06c0.63-0.63,1.51-1.03,2.47-1.03s1.84,0.39,2.47,1.03l1.06-1.06 C19.12,6.56,17.87,6,16.49,6z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M16.49,9c-0.55,0-1.05,0.22-1.41,0.59L16.49,11l1.41-1.41C17.54,9.22,17.04,9,16.49,9z");
		builder.CloseElement();
		builder.OpenElement(26, "g");
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M15,17.83c1.29,0.54,2.63,0.89,4,1.07v-2.23l-2.35-0.47L15,17.83z");
		builder.AddAttribute(29, "enable-background", "new");
		builder.AddAttribute(30, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M7.33,5H5.1c0.18,1.37,0.53,2.7,1.07,4L7.8,7.35L7.33,5z");
		builder.AddAttribute(33, "enable-background", "new");
		builder.AddAttribute(34, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M20.2,14.87l-3.67-0.73c-0.5-0.1-0.83,0.2-0.9,0.27l-2.52,2.5c-2.5-1.43-4.57-3.5-6-6l2.5-2.52 c0.23-0.24,0.33-0.57,0.27-0.9L9.13,3.8C9.04,3.34,8.63,3,8.15,3H4C3.44,3,2.97,3.47,3,4.03C3.17,6.92,4.05,9.63,5.43,12 c1.58,2.73,3.85,4.99,6.57,6.57c2.37,1.37,5.08,2.26,7.97,2.43c0.55,0.03,1.03-0.43,1.03-1v-4.15 C21,15.37,20.66,14.96,20.2,14.87z M5.1,5h2.23L7.8,7.35L6.17,9C5.63,7.7,5.27,6.37,5.1,5z M19,18.9c-1.37-0.18-2.7-0.53-4-1.07 l1.65-1.63L19,16.67V18.9z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
