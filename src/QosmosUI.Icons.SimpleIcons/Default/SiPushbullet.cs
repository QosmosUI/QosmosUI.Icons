// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPushbullet : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0A12 12 0 0 0 0 12a12 12 0 0 0 12 12 12 12 0 0 0 12-12A12 12 0 0 0 12 0zm0 1.688A10.312 10.312 0 0 1 22.312 12 10.312 10.312 0 0 1 12 22.312 10.312 10.312 0 0 1 1.688 12 10.312 10.312 0 0 1 12 1.688zM7.258 6.92a.659.772 0 0 0-.659.772v8.643a.603.603 0 0 0 .603.603h1.733a.603.603 0 0 0 .603-.603V7.692a.659.772 0 0 0-.658-.772zm6.94.001c-.975.005-1.93.005-2.867.002-.28 0-.474.254-.534.499a1.7 1.7 0 0 0-.043.405c.004 2.854.007 5.677.007 8.47 0 .397.21.643.589.641 1.002-.004 1.967-.003 2.895 0 .058 0 .129.022.176.02.824-.018 1.552-.251 2.182-.698 2.02-1.43 2.554-4.264 1.662-6.47-.574-1.417-1.743-2.573-3.27-2.82a5.027 5.027 0 0 0-.797-.049z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
