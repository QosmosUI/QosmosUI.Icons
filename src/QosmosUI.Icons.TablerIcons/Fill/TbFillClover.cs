// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillClover : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.712 13.297l3.398 3.442a3.104 3.104 0 0 1 0 4.351a3.04 3.04 0 0 1 -4.036 .27l-.075 -.062l-.073 .062a3.04 3.04 0 0 1 -1.664 .634l-.203 .007a3.04 3.04 0 0 1 -2.17 -.91a3.104 3.104 0 0 1 .002 -4.354l3.397 -3.44a1 1 0 0 1 1.424 0m8.378 -5.407a3.04 3.04 0 0 1 .27 4.037l-.062 .073l.062 .075a3.04 3.04 0 0 1 .634 1.664l.007 .203a3.04 3.04 0 0 1 -.91 2.17a3.104 3.104 0 0 1 -4.354 -.002l-3.44 -3.397a1 1 0 0 1 0 -1.424l3.443 -3.399a3.104 3.104 0 0 1 4.351 0m-13.827 .002l3.44 3.397a1 1 0 0 1 0 1.424l-3.444 3.397a3.104 3.104 0 0 1 -4.351 0a3.04 3.04 0 0 1 -.27 -4.036l.062 -.075l-.062 -.073a3.04 3.04 0 0 1 -.634 -1.664l-.007 -.203c0 -.816 .328 -1.598 .91 -2.17a3.104 3.104 0 0 1 4.354 .002m6.678 -5.891a3.04 3.04 0 0 1 2.17 .91a3.104 3.104 0 0 1 -.002 4.354l-3.397 3.44a1 1 0 0 1 -1.424 0l-3.397 -3.444a3.104 3.104 0 0 1 0 -4.351a3.04 3.04 0 0 1 4.036 -.27l.073 .062l.075 -.062a3.04 3.04 0 0 1 1.664 -.634z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
