// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneNoPhotography : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M10.94,8.12L8.9,6.07L9.88,5h4.24l1.83,2H20v10.17l-3.12-3.12 C16.96,13.71,17,13.36,17,13c0-2.76-2.24-5-5-5C11.64,8,11.29,8.04,10.94,8.12z M12,18c-2.76,0-5-2.24-5-5 c0-0.91,0.25-1.76,0.68-2.49L4.17,7H4v12h12.17l-1.68-1.68C13.76,17.75,12.91,18,12,18z");
		builder.AddAttribute(20, "enable-background", "new");
		builder.AddAttribute(21, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M8.9,6.07L7.48,4.66L9,3h6l1.83,2H20c1.1,0,2,0.9,2,2v12c0,0.05-0.01,0.1-0.02,0.16L20,17.17V7h-4.05l-1.83-2H9.88 L8.9,6.07z M20.49,23.31L18.17,21H4c-1.1,0-2-0.9-2-2V7c0-0.59,0.27-1.12,0.68-1.49l-2-2L2.1,2.1L7,7l2.01,2.01l1.43,1.43l4.1,4.1 l1.43,1.43L19,19l1.82,1.82l1.08,1.08L20.49,23.31z M9.19,12.02C9.08,12.33,9,12.65,9,13c0,1.65,1.35,3,3,3 c0.35,0,0.67-0.08,0.98-0.19L9.19,12.02z M16.17,19l-1.68-1.68C13.76,17.75,12.91,18,12,18c-2.76,0-5-2.24-5-5 c0-0.91,0.25-1.76,0.68-2.49L4.17,7H4v12H16.17z M14.81,11.98l2.08,2.08C16.96,13.71,17,13.36,17,13c0-2.76-2.24-5-5-5 c-0.36,0-0.71,0.04-1.06,0.12l2.08,2.08C13.85,10.5,14.5,11.15,14.81,11.98z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
