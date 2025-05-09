// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscThumbsdown : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M13.4999 1H4.60292C3.72392 1 2.95692 1.564 2.69392 2.404L1.13192 7.404C0.940924 8.018 1.04892 8.667 1.42992 9.185C1.81092 9.703 2.39892 10 3.04092 10H6.47492L6.01092 12.32C5.87792 12.98 6.04792 13.658 6.47492 14.179C6.90192 14.7 7.53392 14.999 8.20692 14.999C8.65092 14.999 9.04692 14.701 9.15892 14.306L9.62292 13.02C10.1409 11.585 10.8559 10.234 11.7539 8.999H13.5009C14.3279 8.999 15.0009 8.326 15.0009 7.499V2.5C15.0009 1.673 14.3269 1 13.4999 1ZM8.68092 12.682L8.20592 14C7.83292 14 7.48292 13.834 7.24692 13.546C7.01092 13.258 6.91692 12.882 6.98992 12.517L7.57392 9.599C7.60292 9.452 7.56492 9.3 7.46992 9.184C7.37492 9.068 7.23292 9.001 7.08292 9.001H3.03892C2.71792 9.001 2.42392 8.853 2.23292 8.593C2.04292 8.334 1.98892 8.01 2.08492 7.702L3.64692 2.702C3.77792 2.282 4.16192 2 4.60092 2H10.9979V8.336C10.0199 9.668 9.23992 11.13 8.67892 12.682H8.68092ZM13.9999 7.5C13.9999 7.776 13.7749 8 13.4999 8H11.9999V2H13.4999C13.7749 2 13.9999 2.224 13.9999 2.5V7.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
