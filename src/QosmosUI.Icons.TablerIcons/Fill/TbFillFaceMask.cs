// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillFaceMask : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.825 4.196l5 1.43a3 3 0 0 1 2.175 2.884v.065c1.7 .33 3 1.72 3 3.425s-1.3 3.095 -3 3.425v.066a3 3 0 0 1 -2.175 2.885l-5 1.428a3 3 0 0 1 -1.65 0l-5 -1.429a3 3 0 0 1 -2.17 -2.702l-.005 -.247c-1.7 -.33 -3 -1.72 -3 -3.426c0 -1.705 1.3 -3.096 3 -3.426v-.064a3 3 0 0 1 2.175 -2.884l5 -1.428a3 3 0 0 1 1.65 0m2.175 8.802h-6a1 1 0 0 0 0 2h6a1 1 0 0 0 0 -2m-11 -2.349c-.6 .248 -1 .77 -1 1.349c0 .578 .4 1.101 1 1.349zm16.001 0v2.697c.599 -.248 .999 -.77 .999 -1.348s-.4 -1.1 -.999 -1.348m-5.001 -1.652h-6a1 1 0 1 0 0 2h6a1 1 0 0 0 0 -2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
