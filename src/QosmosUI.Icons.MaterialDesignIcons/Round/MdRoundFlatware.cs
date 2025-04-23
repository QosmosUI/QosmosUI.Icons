// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundFlatware : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M16,7.08c0,1.77-0.84,3.25-2,3.82V20c0,0.55-0.45,1-1,1h0c-0.55,0-1-0.45-1-1v-9.1c-1.16-0.57-2-2.05-2-3.82 C10.01,4.83,11.35,3,13,3C14.66,3,16,4.83,16,7.08z M18.27,3.18C17.64,2.99,17,3.49,17,4.15L17,20c0,0.55,0.45,1,1,1h0 c0.55,0,1-0.45,1-1v-7h1c0.55,0,1-0.45,1-1V7C21,5.54,20.14,3.74,18.27,3.18z M8.28,3c-0.4,0-0.72,0.32-0.72,0.72V7H6.72V3.72 C6.72,3.32,6.4,3,6,3S5.28,3.32,5.28,3.72V7H4.44V3.72C4.44,3.32,4.12,3,3.72,3S3,3.32,3,3.72V9c0,1.1,0.9,2,2,2v9 c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-9c1.1,0,2-0.9,2-2V3.72C9,3.32,8.68,3,8.28,3z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
