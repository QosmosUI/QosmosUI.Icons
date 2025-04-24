// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiWebmoney : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.943.1825c1.8723 0 3.6538.429 5.2524 1.1964.2507.1131.503.2485.7529.384l-1.0961.971-1.6433-1.6933-2.8315 2.483L10.71 1.74 5.5032 6.368l3.3336 3.6347-1.3014 1.1285 3.2889 3.6346-1.3015 1.128 4.7045 5.1698 2.7844-2.5285 2.4217 2.7097c-.48.3613-1.0052.7232-1.5754 1.0387a12.0418 12.0418 0 0 1-5.892 1.534C5.3657 23.8175 0 18.5135 0 11.9899-.0231 5.5104 5.3435.1825 11.943.1825zM9.7502 11.267l2.8546-2.5285 2.5582 2.8218-2.8552 2.5283zm2.033 4.8764l2.8314-2.551 2.5807 2.8216-2.8548 2.5286zM7.719 6.4587l2.8537-2.5285 2.5577 2.8217-2.8548 2.5285zm5.2284-1.355l2.124-1.8961L16.99 5.307l-2.124 1.9186zm3.7912 8.6914l2.1232-1.8963 1.9186 2.1215-2.124 1.8975zm1.8723 4.267l2.124-1.8966 1.9171 2.0995-2.1232 1.9183zm.868-9.7527l1.4156-1.2643 1.2784 1.4002-1.4155 1.2638zM17.652 4.133l1.4158-1.2864 1.2793 1.422-1.4168 1.2641zm3.6308 8.3531l1.4156-1.2642L24 12.6216l-1.4381 1.2639zm-6.3711-3.138l2.124-1.8963 1.9178 2.099-2.1231 1.8967Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
