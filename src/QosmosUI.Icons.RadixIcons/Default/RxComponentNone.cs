// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RadixIcons.Default;

public class RxComponentNone : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "15";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 15 15";

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
		builder.AddAttribute(16, "d", "M7.85361 1.48959C7.65835 1.29432 7.34176 1.29432 7.1465 1.48959L1.48965 7.14644C1.29439 7.3417 1.29439 7.65829 1.48965 7.85355L3.9645 10.3284L1.64644 12.6464C1.45118 12.8417 1.45118 13.1583 1.64644 13.3536C1.84171 13.5488 2.15829 13.5488 2.35355 13.3536L4.6716 11.0355L7.1465 13.5104C7.34176 13.7057 7.65835 13.7057 7.85361 13.5104L13.5105 7.85355C13.7057 7.65829 13.7057 7.3417 13.5105 7.14644L11.0356 4.67154L13.3535 2.35355C13.5488 2.15829 13.5488 1.84171 13.3535 1.64645C13.1583 1.45118 12.8417 1.45118 12.6464 1.64645L10.3285 3.96443L7.85361 1.48959ZM9.62135 4.67154L7.50005 2.55025L2.55031 7.49999L4.6716 9.62129L9.62135 4.67154ZM5.37871 10.3284L7.50005 12.4497L12.4498 7.49999L10.3285 5.37865L5.37871 10.3284Z");
		builder.AddAttribute(17, "fill", "currentColor");
		builder.CloseElement();
		builder.CloseElement();
    }
}
