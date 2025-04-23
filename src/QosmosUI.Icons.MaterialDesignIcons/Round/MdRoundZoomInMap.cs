// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundZoomInMap : ComponentBase
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
		builder.AddAttribute(20, "d", "M3,8c0,0.55,0.45,1,1,1l4,0c0.55,0,1-0.45,1-1l0-4c0-0.55-0.45-1-1-1S7,3.45,7,4l0,1.59L4.62,3.21 c-0.39-0.39-1.02-0.39-1.41,0c-0.39,0.39-0.39,1.02,0,1.41L5.59,7L4,7C3.45,7,3,7.45,3,8z M20,7h-1.59l2.38-2.38 c0.39-0.39,0.39-1.02,0-1.41c-0.39-0.39-1.02-0.39-1.41,0L17,5.59V4c0-0.55-0.45-1-1-1c-0.55,0-1,0.45-1,1v4c0,0.55,0.45,1,1,1h4 c0.55,0,1-0.45,1-1S20.55,7,20,7z M4,17h1.59l-2.38,2.38c-0.39,0.39-0.39,1.02,0,1.41c0.39,0.39,1.02,0.39,1.41,0L7,18.41L7,20 c0,0.55,0.45,1,1,1s1-0.45,1-1l0-4c0-0.55-0.45-1-1-1l-4,0c-0.55,0-1,0.45-1,1C3,16.55,3.45,17,4,17z M21,16c0-0.55-0.45-1-1-1h-4 c-0.55,0-1,0.45-1,1v4c0,0.55,0.45,1,1,1c0.55,0,1-0.45,1-1v-1.59l2.38,2.38c0.39,0.39,1.02,0.39,1.41,0 c0.39-0.39,0.39-1.02,0-1.41L18.41,17H20C20.55,17,21,16.55,21,16z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
