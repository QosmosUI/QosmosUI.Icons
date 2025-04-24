// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrVenmo : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "clip-path", "url(#a)");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "fill-rule", "evenodd");
		builder.AddAttribute(17, "d", "M24 12c0 6.628-5.372 12-12 12-6.627 0-12-5.372-12-12C0 5.373 5.373 0 12 0c6.628 0 12 5.373 12 12Zm-5.982-3.571c0-1-.21-1.79-.677-2.558l-4.035.814c.256.535.42 1.185.42 2.14 0 1.744-1.237 4.303-2.24 5.93L10.413 6.15l-4.431.42 2.03 12.094h5.06c2.216-2.907 4.946-7.047 4.946-10.234Z");
		builder.AddAttribute(18, "clip-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "defs");
		builder.OpenElement(20, "clipPath");
		builder.AddAttribute(21, "id", "a");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M0 0h24v24H0z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
