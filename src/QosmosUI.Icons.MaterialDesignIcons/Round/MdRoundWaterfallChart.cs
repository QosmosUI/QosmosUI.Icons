// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWaterfallChart : ComponentBase
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
		builder.AddAttribute(20, "d", "M19.5,4L19.5,4C20.33,4,21,4.67,21,5.5v13c0,0.83-0.67,1.5-1.5,1.5h0c-0.83,0-1.5-0.67-1.5-1.5v-13 C18,4.67,18.67,4,19.5,4z M4.5,13L4.5,13C5.33,13,6,13.67,6,14.5v4C6,19.33,5.33,20,4.5,20h0C3.67,20,3,19.33,3,18.5v-4 C3,13.67,3.67,13,4.5,13z M15.5,4L15.5,4C16.33,4,17,4.67,17,5.5v0C17,6.33,16.33,7,15.5,7h0C14.67,7,14,6.33,14,5.5v0 C14,4.67,14.67,4,15.5,4z M11.5,5L11.5,5C12.33,5,13,5.67,13,6.5v1C13,8.33,12.33,9,11.5,9h0C10.67,9,10,8.33,10,7.5v-1 C10,5.67,10.67,5,11.5,5z M8.5,10L8.5,10c0.83,0,1.5,0.67,1.5,1.5v1c0,0.83-0.67,1.5-1.5,1.5h0C7.67,14,7,13.33,7,12.5v-1 C7,10.67,7.67,10,8.5,10z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
