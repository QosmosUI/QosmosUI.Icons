// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAssuredWorkload : ComponentBase
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
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M6,17c0.55,0,1-0.45,1-1v-5c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v5C5,16.55,5.45,17,6,17L6,17z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12,17c0.55,0,1-0.45,1-1v-5c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v5C11,16.55,11.45,17,12,17L12,17z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M21.32,5.66l-8.42-4.21c-0.56-0.28-1.23-0.28-1.79,0L2.68,5.66C2.26,5.87,2,6.3,2,6.76v0C2,7.45,2.55,8,3.24,8h17.53 C21.45,8,22,7.45,22,6.76v0C22,6.3,21.74,5.87,21.32,5.66z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M2,20L2,20c0,0.55,0.45,1,1,1h11.4c-0.21-0.64-0.32-1.31-0.36-2H3C2.45,19,2,19.45,2,20z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M19,12.26V11c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v2.26L19,12.26z");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M19.55,14.22l-3,1.5C16.21,15.89,16,16.24,16,16.62v1.93c0,2.52,1.71,4.88,4,5.45c2.29-0.57,4-2.93,4-5.45v-1.93 c0-0.38-0.21-0.73-0.55-0.89l-3-1.5C20.17,14.08,19.83,14.08,19.55,14.22z M18.58,20.3l-0.8-0.8c-0.29-0.29-0.29-0.77,0-1.06l0,0 c0.29-0.29,0.77-0.29,1.06,0l0.44,0.44l1.88-1.85c0.29-0.29,0.77-0.29,1.06,0l0,0c0.29,0.29,0.29,0.77,0,1.06l-2.23,2.21 C19.6,20.69,18.97,20.69,18.58,20.3z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
