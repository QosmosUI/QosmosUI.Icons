// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineNoFlash : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.4,5.6H22L19,11V7h-1V2h4L20.4,5.6z M16,11.4l0,1.77l2,2V11c0-0.88-0.72-1.6-1.6-1.6h-2.54L12.58,8h-1.75l3.4,3.4H16z M2.1,2.1L0.69,3.51l5.66,5.66L6.14,9.4H3.6C2.72,9.4,2,10.12,2,11v9.4C2,21.28,2.72,22,3.6,22h12.8c0.75,0,1.38-0.52,1.55-1.22 l2.54,2.54l1.41-1.41L2.1,2.1z M11.5,15.5c0,0.83-0.67,1.5-1.5,1.5s-1.5-0.67-1.5-1.5S9.17,14,10,14S11.5,14.67,11.5,15.5z M15.96,20H4v-8.6h2.14h0.88l0.59-0.65l0.15-0.16l1.5,1.5C7.68,12.43,6.5,13.82,6.5,15.5c0,1.93,1.57,3.5,3.5,3.5 c1.68,0,3.07-1.18,3.42-2.76l2.55,2.55L15.96,20z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(18, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
