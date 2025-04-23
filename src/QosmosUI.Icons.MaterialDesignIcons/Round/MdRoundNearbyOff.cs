// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundNearbyOff : ComponentBase
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
		builder.AddAttribute(20, "d", "M21.41,13.42L18.83,16l-1.81-1.81L19.2,12L12,4.8L9.81,6.99L8,5.17l2.58-2.58c0.78-0.78,2.05-0.78,2.83,0l8,8 C22.2,11.37,22.2,12.63,21.41,13.42z M20.48,21.9L20.48,21.9c-0.39,0.39-1.02,0.39-1.41,0L16,18.83l-2.58,2.58 c-0.78,0.78-2.05,0.78-2.83,0l-8-8c-0.78-0.78-0.78-2.05,0-2.83L5.17,8L2.1,4.93c-0.39-0.39-0.39-1.02,0-1.41l0,0 c0.39-0.39,1.02-0.39,1.41,0l16.98,16.97C20.87,20.87,20.87,21.51,20.48,21.9z M14.19,17.02l-1.39-1.39l-0.09,0.09 c-0.39,0.39-1.02,0.39-1.42,0l-3.01-3.01c-0.39-0.39-0.39-1.02,0-1.41l0.09-0.09l-1.4-1.39L4.8,12l7.2,7.2L14.19,17.02z M15.71,11.29l-3.01-3.01c-0.39-0.39-1.02-0.39-1.41,0L11.2,8.38l4.42,4.42l0.09-0.09C16.1,12.32,16.1,11.68,15.71,11.29z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
