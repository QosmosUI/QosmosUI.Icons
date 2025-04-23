// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneAlarmOff : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M10.04 6.29C10.66 6.11 11.32 6 12 6c3.86 0 7 3.14 7 7 0 .68-.11 1.34-.29 1.96l1.56 1.56c.47-1.08.73-2.27.73-3.52 0-4.97-4.03-9-9-9-1.25 0-2.44.26-3.53.72l1.57 1.57zm7.297-4.48l4.607 3.845-1.28 1.535-4.61-3.843zm1.903 16.51l-1.43-1.43-9.7-9.7-1.43-1.43-.74-.74L4.52 3.6l-1.5-1.5-1.41 1.41 1.37 1.37-.92.77 1.28 1.54 1.06-.88.8.8C3.83 8.69 3 10.75 3 13c0 4.97 4.03 9 9 9 2.25 0 4.31-.83 5.89-2.2l2.1 2.1 1.41-1.41-2.16-2.17zM12 20c-3.86 0-7-3.14-7-7 0-1.7.61-3.26 1.62-4.47l9.85 9.85C15.26 19.39 13.7 20 12 20zM7.48 3.73l.46-.38-1.28-1.54-.6.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
