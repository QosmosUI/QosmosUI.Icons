// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiAwselasticloadbalancing : ComponentBase
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
		builder.AddAttribute(15, "d", "M7.2 18.24C3.76 18.24.96 15.44.96 12s2.8-6.24 6.24-6.24 6.24 2.8 6.24 6.24-2.8 6.24-6.24 6.24m14.4 2.88c0 1.059-.861 1.92-1.92 1.92a1.92 1.92 0 0 1-1.92-1.92c0-1.059.861-1.92 1.92-1.92s1.92.861 1.92 1.92M19.68.96c1.059 0 1.92.861 1.92 1.92s-.861 1.92-1.92 1.92a1.92 1.92 0 0 1-1.92-1.92c0-1.059.861-1.92 1.92-1.92m1.44 9.12c1.059 0 1.92.861 1.92 1.92s-.861 1.92-1.92 1.92A1.92 1.92 0 0 1 19.2 12c0-1.059.861-1.92 1.92-1.92m-6.744 2.4h3.907a2.88 2.88 0 0 0 2.837 2.4A2.883 2.883 0 0 0 24 12a2.883 2.883 0 0 0-2.88-2.88 2.88 2.88 0 0 0-2.837 2.4h-3.907a7.1 7.1 0 0 0-.661-2.566l4.26-3.759a2.86 2.86 0 0 0 1.705.565 2.883 2.883 0 0 0 2.88-2.88A2.883 2.883 0 0 0 19.68 0a2.883 2.883 0 0 0-2.88 2.88c0 .603.187 1.162.504 1.625L13.24 8.092A7.2 7.2 0 0 0 7.2 4.8C3.23 4.8 0 8.03 0 12s3.23 7.2 7.2 7.2a7.2 7.2 0 0 0 6.039-3.292l4.065 3.587a2.86 2.86 0 0 0-.504 1.625A2.883 2.883 0 0 0 19.68 24a2.883 2.883 0 0 0 2.88-2.88 2.883 2.883 0 0 0-2.88-2.88 2.86 2.86 0 0 0-1.706.565l-4.26-3.759c.371-.789.601-1.654.662-2.566");
		builder.CloseElement();
		builder.CloseElement();
    }
}
