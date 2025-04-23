// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDatasetLinked : ComponentBase
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
		builder.AddAttribute(25, "d", "M8.09,17H7v-4h3.69c0.95-0.63,2.09-1,3.31-1h6c0.34,0,0.67,0.04,1,0.09V5c0-1.1-0.9-2-2-2H5C3.9,3,3,3.9,3,5v14 c0,1.1,0.9,2,2,2h3.81C8.3,20.12,8,19.09,8,18C8,17.66,8.04,17.33,8.09,17z M13,7h4v4h-4V7z M7,7h4v4H7V7z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M12.03,17.66c0.16-0.98,1.09-1.66,2.08-1.66L15,16c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1l-0.83,0 c-2.09,0-3.95,1.53-4.15,3.61C9.79,19.99,11.66,22,14,22h1c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h-1 C12.79,20,11.82,18.91,12.03,17.66z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M19.83,14L19,14c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1l0.89,0c1,0,1.92,0.68,2.08,1.66C22.18,18.91,21.21,20,20,20h-1 c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h1c2.34,0,4.21-2.01,3.98-4.39C23.78,15.53,21.92,14,19.83,14z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M15,19h4c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h-4c-0.55,0-1,0.45-1,1v0C14,18.55,14.45,19,15,19z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
