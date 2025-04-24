// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiSailboatLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M3.00003 18H21C21.2762 18 21.5 18.2239 21.5 18.5C21.5 18.6082 21.4649 18.7135 21.4 18.8L19.3 21.6C19.1112 21.8518 18.8148 22 18.5 22H5.50003C5.18527 22 4.88888 21.8518 4.70003 21.6L2.60003 18.8C2.43434 18.5791 2.47912 18.2657 2.70003 18.1C2.78658 18.0351 2.89184 18 3.00003 18ZM7.16128 14H13V6.7016L7.16128 14ZM15 2.42543V15C15 15.5523 14.5523 16 14 16H4.04034C3.7642 16 3.54034 15.7762 3.54034 15.5C3.54034 15.3865 3.57898 15.2764 3.64991 15.1877L14.1096 2.11309C14.2821 1.89745 14.5967 1.86249 14.8124 2.035C14.931 2.12989 15 2.27354 15 2.42543Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
