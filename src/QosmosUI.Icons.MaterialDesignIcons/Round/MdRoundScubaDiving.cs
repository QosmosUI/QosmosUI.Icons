// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundScubaDiving : ComponentBase
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
		builder.AddAttribute(24, "d", "M1,13c0-1.1,0.9-2,2-2s2,0.9,2,2s-0.9,2-2,2S1,14.1,1,13z M8.89,10.11l3.56-0.95c0.53-0.14,0.85-0.69,0.71-1.22L12.9,6.97 c-0.14-0.53-0.69-0.85-1.22-0.71L8.11,7.21c-0.8,0.21-1.28,1.04-1.06,1.84l0,0C7.27,9.85,8.09,10.33,8.89,10.11z M22.52,2.52 c-0.29-0.29-0.75-0.29-1.04,0L19,5l-2,4l-9.48,2.87c-0.82,0.2-1.39,0.89-1.5,1.68L5.24,18L3,21c-0.33,0.44-0.24,1.07,0.2,1.4 c0.44,0.33,1.07,0.24,1.4-0.2L7,19l1.14-3.14l5.57-1.77c0.19-0.06,0.38-0.15,0.54-0.27l4.2-2.94c0.36-0.25,0.62-0.61,0.75-1.02 L20.5,5.9l2.06-2.38C22.81,3.22,22.79,2.79,22.52,2.52z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
