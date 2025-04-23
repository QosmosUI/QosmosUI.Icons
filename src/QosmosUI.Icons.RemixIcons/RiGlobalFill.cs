// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiGlobalFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M2.04932 12.9999H7.52725C7.70624 16.2688 8.7574 19.3053 10.452 21.8809C5.98761 21.1871 2.5001 17.5402 2.04932 12.9999ZM2.04932 10.9999C2.5001 6.45968 5.98761 2.81276 10.452 2.11902C8.7574 4.69456 7.70624 7.73111 7.52725 10.9999H2.04932ZM21.9506 10.9999H16.4726C16.2936 7.73111 15.2425 4.69456 13.5479 2.11902C18.0123 2.81276 21.4998 6.45968 21.9506 10.9999ZM21.9506 12.9999C21.4998 17.5402 18.0123 21.1871 13.5479 21.8809C15.2425 19.3053 16.2936 16.2688 16.4726 12.9999H21.9506ZM9.53068 12.9999H14.4692C14.2976 15.7828 13.4146 18.3732 11.9999 20.5915C10.5852 18.3732 9.70229 15.7828 9.53068 12.9999ZM9.53068 10.9999C9.70229 8.21709 10.5852 5.62672 11.9999 3.40841C13.4146 5.62672 14.2976 8.21709 14.4692 10.9999H9.53068Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
