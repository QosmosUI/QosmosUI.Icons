// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiMockserviceworker : ComponentBase
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
		builder.AddAttribute(15, "d", "M4.5 0A4.49 4.49 0 0 0 0 4.5v15A4.49 4.49 0 0 0 4.5 24h15a4.49 4.49 0 0 0 4.5-4.5v-15A4.49 4.49 0 0 0 19.5 0Zm1.633 4.43 11.715.013c.623.001 1.208.26 1.62.674.414.414.671 1 .67 1.623v.086l-1.224 11.799a2.31 2.31 0 0 1-.836 1.545 2.293 2.293 0 0 1-3.15-.246L4.426 8.262a2.31 2.31 0 0 1-.586-1.657A2.295 2.295 0 0 1 6.133 4.43Zm2.363 3.35 7.334 8.146.844-8.137zm1.123.501 3.244.004 2.92 3.244-.336 3.227zM4.678 9.287l3.017 3.354-.369 3.57 3.588.004 3.018 3.351-7.78-.01c-.623 0-1.208-.26-1.62-.673-.414-.414-.671-1-.67-1.623v-.086z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
