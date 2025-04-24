// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiOnstar : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0C5.372 0 0 5.372 0 12s5.372 12 12 12 12-5.372 12-12S18.628 0 12 0zm-.049.763c6.233 0 11.304 5.066 11.304 11.294 0 6.229-5.07 11.295-11.304 11.295-6.233 0-11.304-5.066-11.304-11.295C.647 5.83 5.718.763 11.951.763zm0 .287C5.877 1.05.936 5.988.936 12.057c0 6.07 4.941 11.008 11.015 11.008 6.074 0 11.016-4.938 11.016-11.008 0-6.069-4.942-11.007-11.016-11.007zm4.73 3.25l.582 1.7 1.8.064-1.44 1.078.495 1.729-1.472-1.034-1.494 1.004.53-1.717-1.418-1.108 1.8-.028zM7.99 7.11c2.892 0 4.967 2.155 4.967 4.82v.027c0 2.664-2.102 4.847-4.994 4.847s-4.967-2.156-4.967-4.82v-.027c0-2.665 2.102-4.848 4.994-4.848zm-.027 1.9c-1.66 0-2.812 1.313-2.812 2.92v.027c0 1.606 1.179 2.945 2.839 2.945s2.812-1.312 2.812-2.918v-.027c0-1.607-1.178-2.946-2.839-2.946zm9.976.322c1.54 0 2.437 1.018 2.437 2.665v4.646h-2.035V12.64c0-.964-.455-1.46-1.232-1.46-.776 0-1.272.496-1.272 1.46v4.003h-2.035V9.466h2.035v1.018c.469-.603 1.071-1.152 2.102-1.152Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
