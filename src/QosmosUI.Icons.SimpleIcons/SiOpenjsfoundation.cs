// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiOpenjsfoundation : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.992 0 1.603 6v12L12 24l10.397-5.992V6L11.992 0M10.97 1.534 8.458 5.878H3.443l7.526-4.344M8.046 6.595 6.87 8.634 3.343 6.595h4.703M7.13 9.603 11.275 12 7.13 14.397 5.748 12 7.13 9.603m-.611-.351L5.343 11.29 2.985 7.214l3.534 2.038m-4.1-1.595L4.932 12 2.42 16.343V7.657m2.916 5.06 1.175 2.039-3.526 2.038 2.35-4.076m1.535 2.648 1.176 2.039H3.343l3.527-2.039m-3.427 2.756h5.015l2.511 4.344-7.526-4.344M11.64 22.2l-2.35-4.078h2.351V22.2m0-4.794h-2.77l-1.383-2.397 4.145-2.397v4.794h.008m0-6.023L7.496 8.985l1.382-2.397h2.763v4.794m0-5.504H9.29l2.351-4.076v4.076m5.832 3.374L21 7.214l-2.351 4.076-1.176-2.038M18.237 12l-1.382 2.397L12.71 12l4.145-2.397L18.236 12m-1.122-3.366L15.94 6.595h4.702l-3.527 2.039m3.428-2.756h-5.015l-2.504-4.344 7.519 4.344m-8.19-4.076 2.35 4.076h-2.351V1.802m0 4.793h2.763l1.382 2.397-4.145 2.397V6.595m0 6.023 4.145 2.397-1.382 2.39h-2.763v-4.787m0 5.504h2.351l-2.351 4.076v-4.076m.672 4.344 2.504-4.344h5.015l-7.52 4.344m2.917-5.061 1.175-2.039 3.527 2.039H15.94m1.534-2.657 1.176-2.038L21 16.786l-3.526-2.038m4.1 1.595L19.06 12l2.511-4.343v8.687");
		builder.CloseElement();
		builder.CloseElement();
    }
}
