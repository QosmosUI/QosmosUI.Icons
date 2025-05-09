// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundRealEstateAgent : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M3,22c1.1,0,2-0.9,2-2v-7c0-1.1-0.9-2-2-2s-2,0.9-2,2v7C1,21.1,1.9,22,3,22z M11.37,16.43l1.47,0.51 c0.11,0.04,0.22,0.06,0.33,0.06h6.83c1.11,0,2,0.89,2.01,2l0,0l-7.39,2.77c-0.4,0.15-0.84,0.17-1.25,0.05L7,20.02V11H8.6 c0.24,0,0.48,0.04,0.7,0.13l6.93,2.59c0.46,0.17,0.77,0.61,0.77,1.11v0c0,0.65-0.53,1.18-1.18,1.18h-2.63 c-0.12,0-0.24-0.02-0.36-0.07l-1.12-0.43c-0.26-0.1-0.55,0.04-0.64,0.3C10.98,16.06,11.11,16.34,11.37,16.43z M20.16,5.9l-5-3.57 c-0.7-0.5-1.63-0.5-2.32,0l-5,3.57C7.31,6.28,7,6.88,7,7.53V9h1.61c0.25,0,0.51,0.05,0.74,0.14l7.79,3.11 C18.26,12.71,19,13.79,19,15h2V7.53C21,6.88,20.69,6.28,20.16,5.9z M13,10c-0.28,0-0.5-0.22-0.5-0.5C12.5,9.22,12.72,9,13,9 s0.5,0.22,0.5,0.5C13.5,9.78,13.28,10,13,10z M13,8c-0.28,0-0.5-0.22-0.5-0.5C12.5,7.22,12.72,7,13,7s0.5,0.22,0.5,0.5 C13.5,7.78,13.28,8,13,8z M15,10c-0.28,0-0.5-0.22-0.5-0.5C14.5,9.22,14.72,9,15,9s0.5,0.22,0.5,0.5C15.5,9.78,15.28,10,15,10z M15,8c-0.28,0-0.5-0.22-0.5-0.5C14.5,7.22,14.72,7,15,7s0.5,0.22,0.5,0.5C15.5,7.78,15.28,8,15,8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
