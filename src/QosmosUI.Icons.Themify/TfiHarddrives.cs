// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiHarddrives : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M13.5 12.5c-0.827 0-1.5 0.673-1.5 1.5s0.673 1.5 1.5 1.5 1.5-0.673 1.5-1.5-0.673-1.5-1.5-1.5zM13.5 14.5c-0.275 0-0.5-0.225-0.5-0.5s0.225-0.5 0.5-0.5 0.5 0.225 0.5 0.5-0.225 0.5-0.5 0.5zM17 3.15l-2.923-3.15h-11.151l-2.926 3.087v6.433h0.936l-0.936 1.172v6.308h17v-6.26l-1.046-1.22h1.046v-6.37zM3.355 1h10.286l1.854 2h-14.035l1.895-2zM1 16v-4h15v4h-15zM15.906 11h-14.873l1.181-1.48h12.424l1.268 1.48zM1 8.52v-4.52h15v4.52h-15zM13.5 5c-0.827 0-1.5 0.673-1.5 1.5 0 0.826 0.673 1.499 1.5 1.499s1.5-0.673 1.5-1.499c0-0.827-0.673-1.5-1.5-1.5zM13.5 6.999c-0.275 0-0.5-0.224-0.5-0.499s0.225-0.5 0.5-0.5 0.5 0.225 0.5 0.5-0.225 0.499-0.5 0.499z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
