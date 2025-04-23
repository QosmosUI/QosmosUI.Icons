// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiCairometro : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.397 4.14h.882v.881h-.882zm-1.628 0h.883v.881h-.883zm4.915 1.055v3.402h-1.386V5.195h-.84v1.763h-2.983V5.196h-.84v3.402H8.543v.84h1.911V7.82h2.983v1.617h5.44V5.195zm2.352 3.395h-1.512V6.028h1.512zM5.173 5.195v2.604h2.353v.805H5.173v.833h3.193V5.195zm2.339 1.757H5.999v-.924h1.513zm-2.64 12.177V9.726h4.175L12 12.68l2.954-2.953h4.176v9.403h-4.176v-3.442L12 18.754l-2.952-3.048v3.424zM12 0L8.485 3.515h-4.97v4.97L0 12l3.515 3.515v4.97h4.97L12 24l3.515-3.515h4.97v-4.97L24 12l-3.515-3.515v-4.97h-4.97zm0 1.708l3.014 3.015h4.263v4.263L22.292 12l-3.015 3.014v4.263h-4.263L12 22.292l-3.014-3.015H4.723v-4.263L1.708 12l3.015-3.014V4.723h4.263Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
