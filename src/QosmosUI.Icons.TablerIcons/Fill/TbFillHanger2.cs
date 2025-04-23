// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillHanger2 : ComponentBase
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
		builder.AddAttribute(14, "d", "M12 2a3 3 0 0 1 3 3a1 1 0 0 1 -1.993 .117l-.007 -.117a1 1 0 0 0 -2 -.004c.006 1.516 .495 2.579 1.486 3.13l7.97 4.428a3 3 0 0 1 1.544 2.623v.823a3 3 0 0 1 -2.824 2.995l-.176 .005a3 3 0 0 1 -3 3h-8a3 3 0 0 1 -3 -3a3 3 0 0 1 -3 -3v-.823a3 3 0 0 1 1.543 -2.623l6.695 -3.72c-.832 -.976 -1.232 -2.296 -1.238 -3.834a3 3 0 0 1 3 -3m0 8.144l-7.486 4.158a1 1 0 0 0 -.514 .875v.823a1 1 0 0 0 1 1h.17a3 3 0 0 1 2.83 -2h8c1.306 0 2.418 .835 2.83 2h.17a1 1 0 0 0 1 -1v-.823a1 1 0 0 0 -.515 -.875z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
