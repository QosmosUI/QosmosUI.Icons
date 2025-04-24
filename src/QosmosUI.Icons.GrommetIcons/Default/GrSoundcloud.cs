// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrSoundcloud : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 15.922c0 .298.108.523.324.676a.885.885 0 0 0 .692.162c.231-.045.393-.127.486-.246.093-.119.14-.316.14-.592v-3.238a.799.799 0 0 0-.24-.587.798.798 0 0 0-.587-.24.785.785 0 0 0-.575.24.797.797 0 0 0-.24.587v3.238Zm2.569 1.385c0 .216.076.378.229.486.152.108.348.162.586.162.246 0 .445-.054.597-.162.153-.108.23-.27.23-.486v-7.55a.785.785 0 0 0-.24-.575.798.798 0 0 0-.587-.24.785.785 0 0 0-.575.24.785.785 0 0 0-.24.576v7.55Zm2.557.358c0 .215.078.377.235.485.156.108.357.162.603.162.238 0 .433-.054.586-.162.153-.108.229-.27.229-.485v-6.891c0-.23-.08-.428-.24-.592a.776.776 0 0 0-.575-.246.807.807 0 0 0-.592.246.807.807 0 0 0-.246.592v6.89Zm2.569.033c0 .41.275.614.826.614.551 0 .827-.204.827-.614V6.53c0-.625-.19-.979-.57-1.06-.246-.06-.488.01-.726.211-.238.201-.357.484-.357.849v11.168Zm2.613.324V5.872c0-.388.116-.619.346-.693a6.542 6.542 0 0 1 4.668.625A6.556 6.556 0 0 1 17.707 8a6.543 6.543 0 0 1 1.055 3.065c.454-.193.938-.29 1.452-.29 1.042 0 1.934.368 2.675 1.106.74.737 1.111 1.623 1.111 2.657 0 1.043-.37 1.933-1.111 2.67-.741.737-1.629 1.105-2.664 1.105l-9.716-.01a.261.261 0 0 1-.15-.124.33.33 0 0 1-.05-.156Z");
		builder.CloseElement();
		builder.OpenElement(15, "defs");
		builder.OpenElement(16, "linearGradient");
		builder.AddAttribute(17, "id", "a");
		builder.AddAttribute(18, "x1", "30064.2");
		builder.AddAttribute(19, "x2", "30064.2");
		builder.AddAttribute(20, "y1", "507.299");
		builder.AddAttribute(21, "y2", "18096.6");
		builder.AddAttribute(22, "gradientUnits", "userSpaceOnUse");
		builder.OpenElement(23, "stop");
		builder.AddAttribute(24, "stop-color", "#F80");
		builder.CloseElement();
		builder.OpenElement(25, "stop");
		builder.AddAttribute(26, "offset", "1");
		builder.AddAttribute(27, "stop-color", "#F30");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
