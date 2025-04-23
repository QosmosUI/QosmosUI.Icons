// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdHeatPump : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M12.75,7.08 c0.82,0.12,1.57,0.44,2.2,0.91l-2.2,2.2V7.08z M11.25,7.08v3.11l-2.2-2.2C9.68,7.52,10.43,7.2,11.25,7.08z M7.99,9.05l2.2,2.2H7.08 C7.2,10.43,7.52,9.68,7.99,9.05z M7.08,12.75h3.11l-2.2,2.2C7.52,14.32,7.2,13.57,7.08,12.75z M11.25,16.92 c-0.82-0.12-1.57-0.44-2.2-0.91l2.2-2.2V16.92z M12,13c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1C13,12.55,12.55,13,12,13z M12.75,16.92v-3.11l2.2,2.2C14.32,16.48,13.57,16.8,12.75,16.92z M16.01,14.95l-2.2-2.2h3.11C16.8,13.57,16.48,14.32,16.01,14.95z M13.81,11.25l2.2-2.2c0.47,0.64,0.79,1.39,0.91,2.2H13.81z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
