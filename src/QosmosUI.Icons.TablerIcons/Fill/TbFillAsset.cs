// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillAsset : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M19 2a3 3 0 0 1 2.86 3.91l-.107 .291l-.046 .093q -.061 .128 -.134 .25l-6.476 11.909a1 1 0 0 1 -.066 .104a7 7 0 0 1 -13.031 -3.557l.004 -.24a7 7 0 0 1 3.342 -5.732l.256 -.15l11.705 -6.355q .18 -.123 .378 -.22l.215 -.096l.136 -.048c.302 -.103 .627 -.159 .964 -.159m-10 10a3 3 0 0 0 -2.995 2.824l-.005 .176a3 3 0 1 0 3 -3m7.04 -6.512l-5.12 2.778a7.01 7.01 0 0 1 4.816 4.824l2.788 -5.128a3 3 0 0 1 -2.485 -2.474m2.961 -1.488a1 1 0 0 0 -.317 .051l-.31 .17a1 1 0 1 0 1.465 1.325l.072 -.13a1 1 0 0 0 -.91 -1.416");
		builder.CloseElement();
		builder.CloseElement();
    }
}
