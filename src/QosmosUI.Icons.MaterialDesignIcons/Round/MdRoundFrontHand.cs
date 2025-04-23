// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFrontHand : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M18.5,14.5c0,0.28-0.22,0.5-0.5,0.5l0,0c-1.51,0-2.77,1.12-2.97,2.58C15,17.82,14.78,18,14.54,18c-0.3,0-0.54-0.27-0.5-0.57 c0.26-1.77,1.68-3.17,3.46-3.4l0-10.78C17.5,2.56,16.94,2,16.25,2C15.56,2,15,2.56,15,3.25v7.25c0,0.28-0.22,0.5-0.5,0.5 S14,10.78,14,10.5V1.25C14,0.56,13.44,0,12.75,0S11.5,0.56,11.5,1.25v9.25c0,0.28-0.22,0.5-0.5,0.5s-0.5-0.22-0.5-0.5V2.75 c0-0.69-0.56-1.25-1.25-1.25S8,2.06,8,2.75v8.75C8,11.78,7.78,12,7.5,12S7,11.78,7,11.5V5.75C7,5.06,6.44,4.5,5.75,4.5 S4.5,5.06,4.5,5.75v10c0,4.56,3.69,8.25,8.25,8.25S21,20.31,21,15.75v-6.5C21,8.56,20.44,8,19.75,8S18.5,8.56,18.5,9.25V14.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
