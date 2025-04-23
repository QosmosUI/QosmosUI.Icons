// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons;

public class VscIssueReopened : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M5.28 5.65556L2 7.00556L1.34 6.74556L0 3.50556L0.92 3.12556L1.73 5.07556C2.27376 3.71475 3.2627 2.57844 4.53544 1.85207C5.80817 1.1257 7.28953 0.852174 8.73774 1.07614C10.1859 1.3001 11.5155 2.00832 12.5093 3.08521C13.5032 4.1621 14.1027 5.54407 14.21 7.00556H13.21C13.0956 5.75683 12.5564 4.58511 11.6824 3.68594C10.8083 2.78677 9.65237 2.21456 8.40739 2.06478C7.1624 1.91501 5.90371 2.19674 4.84137 2.86297C3.77903 3.52919 2.97731 4.53959 2.57 5.72556L4.89 4.72556L5.28 5.65556ZM14.14 8.33562L15.48 11.5656L14.56 12.0056L13.74 10.0056C13.1919 11.3718 12.1958 12.511 10.9149 13.2364C9.63412 13.9618 8.14476 14.2302 6.69127 13.9977C5.23779 13.7651 3.90654 13.0454 2.91599 11.9566C1.92544 10.8678 1.33445 9.47455 1.24001 8.00562H2.24001V7.50562C2.24281 8.79308 2.69801 10.0386 3.52602 11.0245C4.35404 12.0104 5.5022 12.6739 6.76983 12.899C8.03745 13.1242 9.34388 12.8967 10.4608 12.2563C11.5777 11.6159 12.434 10.6033 12.88 9.39562L10.63 10.3256L10.24 9.40561L13.49 8.05562L14.14 8.33562Z");
		builder.CloseElement();
		builder.OpenElement(17, "circle");
		builder.AddAttribute(18, "cx", "7.74001");
		builder.AddAttribute(19, "cy", "7.53955");
		builder.AddAttribute(20, "r", "1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
