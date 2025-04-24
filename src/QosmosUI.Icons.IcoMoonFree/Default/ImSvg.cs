// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImSvg : ComponentBase
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
		builder.AddAttribute(14, "d", "M14.5 6.5c-0.444 0-0.843 0.193-1.118 0.5h-2.968l2.099-2.099c0.411 0.023 0.83-0.123 1.144-0.437 0.586-0.586 0.586-1.536 0-2.121s-1.536-0.586-2.121 0c-0.314 0.314-0.46 0.733-0.437 1.144l-2.099 2.099v-2.968c0.307-0.275 0.5-0.674 0.5-1.118 0-0.828-0.672-1.5-1.5-1.5s-1.5 0.672-1.5 1.5c0 0.444 0.193 0.843 0.5 1.118v2.968l-2.099-2.099c0.023-0.411-0.123-0.83-0.437-1.144-0.586-0.586-1.536-0.586-2.121 0s-0.586 1.536 0 2.121c0.314 0.314 0.733 0.46 1.144 0.437l2.099 2.099h-2.968c-0.275-0.307-0.674-0.5-1.118-0.5-0.828 0-1.5 0.672-1.5 1.5s0.672 1.5 1.5 1.5c0.444 0 0.843-0.193 1.118-0.5h2.968l-2.099 2.099c-0.411-0.023-0.83 0.123-1.144 0.437-0.586 0.586-0.586 1.536 0 2.121s1.536 0.586 2.121 0c0.314-0.314 0.46-0.733 0.437-1.144l2.099-2.099v2.968c-0.307 0.275-0.5 0.674-0.5 1.118 0 0.828 0.672 1.5 1.5 1.5s1.5-0.672 1.5-1.5c0-0.444-0.193-0.843-0.5-1.118v-2.968l2.099 2.099c-0.023 0.411 0.123 0.83 0.437 1.144 0.586 0.586 1.536 0.586 2.121 0s0.586-1.536 0-2.121c-0.314-0.314-0.733-0.46-1.144-0.437l-2.099-2.099h2.968c0.275 0.307 0.674 0.5 1.118 0.5 0.828 0 1.5-0.672 1.5-1.5s-0.672-1.5-1.5-1.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
