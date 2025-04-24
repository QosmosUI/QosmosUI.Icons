// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Outline;

public class TbOutlineBrandKickstarter : ComponentBase
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
    public string StrokeWidth { get; set; } = "2";

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
		builder.AddAttribute(14, "d", "M11 9l2.975 -4.65c.615 -.9 1.405 -1.35 2.377 -1.35c.79 0 1.474 .286 2.054 .858c.576 .574 .866 1.256 .866 2.054c0 .588 -.153 1.109 -.46 1.559l-2.812 4.029l3.465 4.912c.356 .46 .535 1 .535 1.613a2.92 2.92 0 0 1 -.843 2.098c-.561 .584 -1.242 .877 -2.04 .877c-.876 0 -1.545 -.29 -2 -.87l-4.112 -5.697v3.067c0 .876 -.313 1.69 -.611 2.175c-.543 .883 -1.35 1.325 -2.389 1.325c-.944 0 -1.753 -.327 -2.271 -.974c-.486 -.6 -.729 -1.392 -.729 -2.38v-11.371c0 -.934 .247 -1.706 .74 -2.313c.512 -.641 1.347 -.962 2.26 -.962c.868 0 1.821 .321 2.4 .962c.323 .356 .515 .714 .6 1.08c.052 .224 0 .643 0 1.26v2.698z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
