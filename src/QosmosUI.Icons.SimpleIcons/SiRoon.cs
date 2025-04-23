// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiRoon : ComponentBase
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
		builder.AddAttribute(15, "d", "M3.29045 9.19816c.138-.02376.23432-.17068.23432-.32064a.31246.31246 0 0 0-.18305-.299s-.0877-.05976-.5772-.05976C1.05931 8.51876 0 9.59844 0 11.3365v3.79832a.35555.35555 0 0 0 .71104 0v-3.79832c0-1.37753.84717-2.1881 2.1359-2.1362.08608.00351.3352.0243.4435-.00213zm17.89042-.69322c-1.64076 0-2.8316 1.19085-2.8316 2.83161v3.79832a.35555.35555 0 1 0 .71103 0v-3.79832c0-1.22151.89185-2.10808 2.12057-2.10808 1.22158 0 2.10815.88657 2.10815 2.10808v3.79832a.35549.35549 0 1 0 .71098 0v-3.79832c0-1.64076-1.18557-2.8316-2.81913-2.8316Zm-6.89807 0c-1.83654 0-3.3305 1.57798-3.3305 3.51768 0 1.91213 1.49402 3.4678 3.3305 3.4678 1.84333 0 3.34306-1.55567 3.34306-3.4678 0-1.9397-1.49967-3.51768-3.34306-3.51768zm2.61953 3.51768c0 1.53385-1.17514 2.78167-2.61953 2.78167-1.44438 0-2.61953-1.24788-2.61953-2.78167 0-1.56136 1.17515-2.83161 2.61953-2.83161 1.44439 0 2.61953 1.27024 2.61953 2.83161zM6.87328 8.50494c-1.83654 0-3.33063 1.57798-3.33063 3.51768 0 1.91213 1.49409 3.4678 3.33063 3.4678 1.84334 0 3.343-1.55567 3.343-3.4678 0-1.9397-1.49966-3.51768-3.343-3.51768zm2.61947 3.51768c0 1.53385-1.17514 2.78167-2.61953 2.78167-1.44438 0-2.61953-1.24788-2.61953-2.78167 0-1.56136 1.17515-2.83161 2.61953-2.83161 1.44439 0 2.61953 1.27024 2.61953 2.83161z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
