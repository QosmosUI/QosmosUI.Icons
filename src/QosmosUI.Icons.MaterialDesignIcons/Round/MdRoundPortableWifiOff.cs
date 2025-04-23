// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPortableWifiOff : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M2.71 3.07c-.39.39-.39 1.02 0 1.41L4.1 5.87C2.79 7.57 2 9.69 2 12c0 3.3 1.6 6.22 4.06 8.04.48.35 1.16.21 1.46-.31.25-.43.14-.99-.26-1.29C5.29 16.98 4 14.65 4 12c0-1.76.57-3.38 1.53-4.69l1.43 1.44C6.36 9.68 6 10.8 6 12c0 1.8.8 3.41 2.06 4.51.46.4 1.19.25 1.5-.28l.01-.01c.24-.42.13-.94-.23-1.26C8.52 14.23 8 13.18 8 12c0-.65.17-1.25.44-1.79l1.58 1.58L10 12c0 1.1.9 2 2 2l.21-.02 6.81 6.81c.39.39 1.02.39 1.41 0 .39-.39.39-1.02 0-1.41L4.13 3.07c-.39-.39-1.03-.39-1.42 0zm15 10.75c.18-.57.29-1.19.29-1.82 0-3.31-2.69-6-6-6-.63 0-1.25.11-1.82.29l1.72 1.72c.03 0 .06-.01.1-.01 2.21 0 4 1.79 4 4 0 .04-.01.07-.01.11l1.72 1.71zM12 4c4.42 0 8 3.58 8 8 0 1.2-.29 2.32-.77 3.35l1.49 1.49C21.53 15.4 22 13.76 22 12c0-5.52-4.48-10-10-10-1.76 0-3.4.48-4.84 1.28l1.48 1.48C9.66 4.28 10.8 4 12 4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
