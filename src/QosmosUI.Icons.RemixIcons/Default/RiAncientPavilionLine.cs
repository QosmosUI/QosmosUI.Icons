// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiAncientPavilionLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M1.51587 7.87678C1.67997 9.82977 3.0892 11.452 5.00006 11.8875V19.0013H3.00006V21.0013H21.0001V19.0013H19.0001V11.8875C20.9109 11.452 22.3202 9.82977 22.4842 7.87678C21.9938 7.95878 21.4973 8 21.0001 8C17.186 8 13.7861 5.59592 12.5148 2H11.4853C10.214 5.59592 6.81411 8 3.00006 8C2.50278 8 2.00635 7.95878 1.51587 7.87678ZM17.0001 19.0013H7.00006V12H17.0001V19.0013ZM18.5556 9.93749L18.2813 10H5.71878L5.44452 9.93749C5.30845 9.90648 5.17809 9.86594 5.05345 9.81587C6.59012 9.53219 8.02261 8.92072 9.35093 7.98146C10.4075 7.23431 11.2906 6.35588 12.0001 5.34615C12.7096 6.35588 13.5926 7.23431 14.6492 7.98146C15.9775 8.92072 17.41 9.53219 18.9467 9.81587C18.8221 9.86594 18.6917 9.90648 18.5556 9.93749Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
