// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundVoiceOverOff : ComponentBase
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
		builder.AddAttribute(17, "d", "M15.72 6.41c-.35.35-.44.88-.25 1.35.3.75.32 1.58.05 2.34-.16.46-.06.98.29 1.32.6.6 1.66.47 2.02-.31.64-1.39.6-2.99-.12-4.41-.4-.75-1.41-.88-1.99-.29zm3.46-3.52c-.4.4-.46 1.02-.13 1.48 1.93 2.68 1.95 6.25.09 9.07-.31.46-.23 1.08.16 1.47.51.51 1.38.46 1.81-.13 2.57-3.51 2.52-8.2-.17-11.77-.43-.56-1.26-.62-1.76-.12zM9.43 5.04l3.53 3.53c-.2-1.86-1.67-3.33-3.53-3.53zM3.71 3.56c-.39.39-.39 1.02 0 1.41l1.91 1.91c-.56.89-.79 2.01-.47 3.2.36 1.33 1.44 2.4 2.77 2.77 1.19.33 2.31.09 3.2-.47l4.4 4.4C13.74 15.6 10.78 15 9 15c-2.67 0-8 1.34-8 4v1c0 .55.45 1 1 1h14c.55 0 1-.45 1-1v-1c0-.37-.11-.7-.29-1.02l2.31 2.31c.39.39 1.02.39 1.41 0 .39-.39.39-1.02 0-1.41L5.12 3.56c-.39-.39-1.02-.39-1.41 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
