// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiMan : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M10.979 14.943h2.05L15.46 18.7h-2.054l-.263-.409h-2.278l-.264.41H8.548zm1.025 1.568l-.458.711h.916l-.458-.712zM0 17.372C0 10.704 5.372 5.3 12 5.3s12 5.405 12 12.073c0 .449-.024.892-.072 1.328H22.58c.054-.435.082-.878.082-1.328 0-5.924-4.774-10.726-10.662-10.726-5.889 0-10.661 4.802-10.661 10.726 0 .45.027.893.08 1.328H.073A12.254 12.274 0 0 1 0 17.372zm2.237-2.43h1.83l1.22 1.228 1.22-1.227h1.831V18.7H6.363v-1.38l-1.075 1.082-1.076-1.082v1.38H2.237v-3.757zm13.42 0h1.927l2.17 1.62v-1.62h1.975V18.7h-1.942l-2.156-1.605V18.7h-1.975Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
