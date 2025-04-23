// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiUniqlo : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 0v24h24V0H0zm3.006 3.236h1.52v5.051a1.007 1.007 0 1 0 2.014 0v-5.05h1.517v5.056a2.525 2.525 0 1 1-5.051 0V3.236zm7.07 0h1.514l2.023 4.328V3.236h1.516v7.575h-1.516L11.59 6.482v4.329h-1.514V3.236zm7.569.01h1.488v7.576h-1.488V3.246zM5.533 13.078a2.526 2.526 0 0 1 2.524 2.53v2.523a2.51 2.51 0 0 1-.75 1.793l.75 2.248H6.539l-.518-1.563a2.472 2.472 0 0 1-.488.043 2.524 2.524 0 0 1-2.527-2.521v-2.524a2.527 2.527 0 0 1 2.527-2.529zm4.547 0h1.514v6.057h3.535v1.517H10.08v-7.574zm8.336 0a2.526 2.526 0 0 1 2.523 2.53v2.523a2.525 2.525 0 0 1-2.523 2.521 2.53 2.53 0 0 1-2.531-2.521v-2.524a2.533 2.533 0 0 1 2.531-2.529zm-12.88 1.52a1.007 1.007 0 0 0-1.01 1.01v2.523c0 .552.45 1.006 1.01 1.006.558 0 1.003-.454 1.003-1.006v-2.524c0-.559-.445-1.01-1.004-1.01zm12.88 0a1.01 1.01 0 0 0-1.012 1.01v2.523c0 .552.453 1.006 1.012 1.006a1.012 1.012 0 0 0 1.01-1.006v-2.524c0-.559-.455-1.01-1.01-1.01z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
