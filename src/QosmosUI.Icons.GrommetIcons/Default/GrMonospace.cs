// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrMonospace : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.88,17H9.58L8.65,14.1H4.44L3.57,17H1.32L5.41,4.17H7.66ZM8,11.93,6.52,7.17,5.09,11.93Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M14.13,17,12.22,4.17h1.66L15.07,13l1.46-8.82h1.92l1.4,9,1.23-9h1.62L20.78,17H19.06l-1.6-9.6L15.88,17Z");
		builder.CloseElement();
		builder.OpenElement(17, "polygon");
		builder.AddAttribute(18, "points", "11.36 17.95 11.36 19.34 1.89 19.34 1.89 17.95 1.38 17.95 1.38 19.86 1.64 19.86 1.89 19.86 11.36 19.86 11.87 19.86 11.87 19.86 11.87 17.95 11.36 17.95");
		builder.CloseElement();
		builder.OpenElement(19, "polygon");
		builder.AddAttribute(20, "points", "22.17 18 22.17 19.39 12.69 19.39 12.69 18 12.19 18 12.19 19.91 12.45 19.91 12.69 19.91 22.17 19.91 22.67 19.91 22.68 19.91 22.68 18 22.17 18");
		builder.CloseElement();
		builder.CloseElement();
    }
}
