// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiElastic : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.345 16.33l-3.959-.926-1.05-2.01 5.177-4.535a3.962 3.962 0 012.559 3.702 4.006 4.006 0 01-2.727 3.77m-2.976 4.68c-.616 0-1.22-.207-1.714-.587l.782-4.077 3.596.841c.115.31.172.642.172.987a2.839 2.839 0 01-2.836 2.836m-2.637-.586a5.92 5.92 0 01-4.908 2.6A5.947 5.947 0 014 15.905l5.167-4.67 5.272 2.403 1.167 2.23zM.928 11.443a4.007 4.007 0 012.726-3.77l3.95.933.927 1.98-5.05 4.565a3.97 3.97 0 01-2.553-3.708m5.703-8.45a2.841 2.841 0 011.723.58l-.789 4.092-3.598-.85a2.842 2.842 0 01-.172-.986A2.84 2.84 0 016.63 2.992m2.66.59A5.92 5.92 0 0120.1 6.93c0 .4-.038.781-.114 1.164l-5.299 4.643-5.251-2.394-1.026-2.19zM24 12.571a4.723 4.723 0 00-3.124-4.454 6.695 6.695 0 00.126-1.29A6.789 6.789 0 0014.22.047 6.769 6.769 0 008.727 2.86a3.586 3.586 0 00-2.204-.754A3.604 3.604 0 003.15 6.959 4.786 4.786 0 000 11.431 4.727 4.727 0 003.139 15.9a6.876 6.876 0 00-.124 1.289 6.773 6.773 0 006.765 6.765c2.19 0 4.22-1.052 5.49-2.824a3.568 3.568 0 002.207.769 3.603 3.603 0 003.374-4.854A4.785 4.785 0 0024 12.572");
		builder.CloseElement();
		builder.CloseElement();
    }
}
