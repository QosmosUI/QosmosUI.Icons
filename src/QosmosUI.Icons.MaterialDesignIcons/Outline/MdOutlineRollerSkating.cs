// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineRollerSkating : ComponentBase
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
		builder.OpenElement(20, "g");
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M20,12c0-1.79-1.19-3.34-2.91-3.82l-2.62-0.74C13.62,7.19,13,6.39,13,5.5V1H4v15h16V12z M18,14H6V3h5v1H9.5 C9.22,4,9,4.22,9,4.5C9,4.78,9.22,5,9.5,5H11l0.1,1H9.5C9.22,6,9,6.22,9,6.5C9,6.78,9.22,7,9.5,7h1.81 c0.45,1.12,1.4,2.01,2.6,2.36l2.62,0.73C17.4,10.33,18,11.1,18,12V14z M5,17c-1.66,0-3,1.34-3,3s1.34,3,3,3s3-1.34,3-3 S6.66,17,5,17z M5,21c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1C6,20.55,5.55,21,5,21z M19,17c-1.66,0-3,1.34-3,3 s1.34,3,3,3s3-1.34,3-3S20.66,17,19,17z M19,21c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1C20,20.55,19.55,21,19,21z M12,17c-1.66,0-3,1.34-3,3s1.34,3,3,3s3-1.34,3-3S13.66,17,12,17z M12,21c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1 C13,20.55,12.55,21,12,21z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
