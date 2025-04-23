// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCalculate : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M13.56,6.53L13.56,6.53 c0.29-0.29,0.77-0.29,1.06,0l0.88,0.88l0.88-0.88c0.29-0.29,0.77-0.29,1.06,0l0,0c0.29,0.29,0.29,0.77,0,1.06l-0.88,0.88l0.88,0.88 c0.29,0.29,0.29,0.77,0,1.06v0c-0.29,0.29-0.77,0.29-1.06,0L15.5,9.54l-0.88,0.88c-0.29,0.29-0.77,0.29-1.06,0l0,0 c-0.29-0.29-0.29-0.77,0-1.06l0.88-0.88l-0.88-0.88C13.26,7.3,13.26,6.82,13.56,6.53z M7,7.72h3.5c0.41,0,0.75,0.34,0.75,0.75v0 c0,0.41-0.34,0.75-0.75,0.75H7c-0.41,0-0.75-0.34-0.75-0.75v0C6.25,8.06,6.59,7.72,7,7.72z M10.75,16H9.5v1.25 C9.5,17.66,9.16,18,8.75,18h0C8.34,18,8,17.66,8,17.25V16H6.75C6.34,16,6,15.66,6,15.25v0c0-0.41,0.34-0.75,0.75-0.75H8v-1.25 c0-0.41,0.34-0.75,0.75-0.75h0c0.41,0,0.75,0.34,0.75,0.75v1.25h1.25c0.41,0,0.75,0.34,0.75,0.75v0C11.5,15.66,11.16,16,10.75,16z M17.25,17.25h-3.5c-0.41,0-0.75-0.34-0.75-0.75l0,0c0-0.41,0.34-0.75,0.75-0.75h3.5c0.41,0,0.75,0.34,0.75,0.75l0,0 C18,16.91,17.66,17.25,17.25,17.25z M17.25,14.75h-3.5C13.34,14.75,13,14.41,13,14v0c0-0.41,0.34-0.75,0.75-0.75h3.5 c0.41,0,0.75,0.34,0.75,0.75v0C18,14.41,17.66,14.75,17.25,14.75z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
