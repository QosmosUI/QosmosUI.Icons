// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRing : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M255.157 123c-68.66 0-137.1 18.922-182.867 55.275.234 14.35 1.818 35.624 9.332 48.23 110.634-60.336 236.436-60.336 347.07 0 7.513-12.606 9.098-33.88 9.332-48.23C392.257 141.922 323.817 123 255.157 123zm199.81 76.057c-.324 2.98-.718 6.02-1.246 9.082-2.226 12.93-6.213 26.458-15.99 35.98-14.436 18.637-40.806 30.462-72.858 38.603C332.392 290.973 293.79 295 255.157 295c-38.632 0-77.235-4.028-109.715-12.277-31.907-8.104-58.17-19.868-72.648-38.36-11.983-11.982-16.234-28.786-17.77-43.857-13.73 27.256-11.503 62.122.672 98.648C69.988 342.03 129.406 389 255.156 389c125.75 0 185.17-46.97 199.462-89.846l.1-.297.12-.287c15.134-36.712 15.61-71.983.13-99.513z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
