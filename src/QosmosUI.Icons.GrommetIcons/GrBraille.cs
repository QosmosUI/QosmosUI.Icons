// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrBraille : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "fill-rule", "evenodd");
		builder.AddAttribute(16, "stroke-width", "2");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M7 10C8.65685425 10 10 8.65685425 10 7 10 5.34314575 8.65685425 4 7 4 5.34314575 4 4 5.34314575 4 7 4 8.65685425 5.34314575 10 7 10zM17 20C18.6568542 20 20 18.6568542 20 17 20 15.3431458 18.6568542 14 17 14 15.3431458 14 14 15.3431458 14 17 14 18.6568542 15.3431458 20 17 20zM7 8C7.55228475 8 8 7.55228475 8 7 8 6.44771525 7.55228475 6 7 6 6.44771525 6 6 6.44771525 6 7 6 7.55228475 6.44771525 8 7 8zM17 18C17.5522847 18 18 17.5522847 18 17 18 16.4477153 17.5522847 16 17 16 16.4477153 16 16 16.4477153 16 17 16 17.5522847 16.4477153 18 17 18zM7 20C5.34314575 20 4 18.6568542 4 17 4 15.3431458 5.34314575 14 7 14 8.65685425 14 10 15.3431458 10 17 10 18.6568542 8.65685425 20 7 20zM17 10C15.3431458 10 14 8.65685425 14 7 14 5.34314575 15.3431458 4 17 4 18.6568542 4 20 5.34314575 20 7 20 8.65685425 18.6568542 10 17 10z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
