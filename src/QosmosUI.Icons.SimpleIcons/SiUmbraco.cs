// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiUmbraco : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 11.982A12 12 0 1 1 12 24 12 12 0 0 1 0 11.982zm11.756 4.11a11.856 11.856 0 0 1-2.773-.25 2.12 2.12 0 0 1-1.514-1.218q-.41-.943-.396-2.895a18.419 18.419 0 0 1 .127-2.04q.118-.988.236-1.629l.082-.425a.201.201 0 0 0 0-.038.244.244 0 0 0-.201-.236l-1.544-.246H5.74a.243.243 0 0 0-.235.189 6.517 6.517 0 0 0-.089.409c-.088.455-.17.9-.26 1.548a19.99 19.99 0 0 0-.176 2.12 11.165 11.165 0 0 0 0 1.486q.05 1.977.675 3.155.626 1.179 2.106 1.695 1.482.517 4.135.506h.22q2.655.01 4.134-.506 1.478-.518 2.1-1.695.623-1.178.678-3.147a11.165 11.165 0 0 0 0-1.485 19.99 19.99 0 0 0-.176-2.121 30.014 30.014 0 0 0-.26-1.548 6.724 6.724 0 0 0-.088-.41.243.243 0 0 0-.236-.188h-.04l-1.548.242a.236.236 0 0 0-.203.236.201.201 0 0 0 0 .037l.081.426q.118.643.236 1.63a18.709 18.709 0 0 1 .126 2.039q.019 1.95-.396 2.892a2.12 2.12 0 0 1-1.502 1.22 11.82 11.82 0 0 1-2.769.247Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
