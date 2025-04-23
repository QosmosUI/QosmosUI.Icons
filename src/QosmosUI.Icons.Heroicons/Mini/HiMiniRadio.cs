// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Heroicons.Mini;

public class HiMiniRadio : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 20 20";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M17.45 3.473a.75.75 0 1 0-.4-1.446L5.313 5.265c-.84.096-1.671.217-2.495.362A2.212 2.212 0 0 0 1 7.816v7.934A2.25 2.25 0 0 0 3.25 18h13.5A2.25 2.25 0 0 0 19 15.75V7.816c0-1.06-.745-2-1.817-2.189a41.12 41.12 0 0 0-5.406-.59l5.673-1.564ZM16 9.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0ZM14.5 16a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3Zm-9.26-5a.75.75 0 0 1 .75-.75H6a.75.75 0 0 1 .75.75v.01a.75.75 0 0 1-.75.75h-.01a.75.75 0 0 1-.75-.75V11Zm2.75-.75a.75.75 0 0 0-.75.75v.01c0 .414.336.75.75.75H8a.75.75 0 0 0 .75-.75V11a.75.75 0 0 0-.75-.75h-.01Zm-1.75-1.5A.75.75 0 0 1 6.99 8H7a.75.75 0 0 1 .75.75v.01a.75.75 0 0 1-.75.75h-.01a.75.75 0 0 1-.75-.75v-.01Zm3.583.42a.75.75 0 0 0-1.06 0l-.007.007a.75.75 0 0 0 0 1.06l.007.007a.75.75 0 0 0 1.06 0l.007-.007a.75.75 0 0 0 0-1.06l-.007-.008Zm.427 2.08A.75.75 0 0 1 11 12v.01a.75.75 0 0 1-.75.75h-.01a.75.75 0 0 1-.75-.75V12a.75.75 0 0 1 .75-.75h.01Zm-.42 3.583a.75.75 0 0 0 0-1.06l-.007-.007a.75.75 0 0 0-1.06 0l-.007.007a.75.75 0 0 0 0 1.06l.007.008a.75.75 0 0 0 1.06 0l.008-.008Zm-3.59.417a.75.75 0 0 1 .75-.75H7a.75.75 0 0 1 .75.75v.01a.75.75 0 0 1-.75.75h-.01a.75.75 0 0 1-.75-.75v-.01Zm-1.013-1.484a.75.75 0 0 0-1.06 0l-.008.007a.75.75 0 0 0 0 1.06l.007.008a.75.75 0 0 0 1.061 0l.007-.008a.75.75 0 0 0 0-1.06l-.007-.007ZM3.75 11.25a.75.75 0 0 1 .75.75v.01a.75.75 0 0 1-.75.75h-.01a.75.75 0 0 1-.75-.75V12a.75.75 0 0 1 .75-.75h.01Zm1.484-1.013a.75.75 0 0 0 0-1.06l-.007-.007a.75.75 0 0 0-1.06 0l-.007.007a.75.75 0 0 0 0 1.06l.007.007a.75.75 0 0 0 1.06 0l.007-.007ZM7.24 13a.75.75 0 0 1 .75-.75H8a.75.75 0 0 1 .75.75v.01a.75.75 0 0 1-.75.75h-.01a.75.75 0 0 1-.75-.75V13Zm-1.25-.75a.75.75 0 0 0-.75.75v.01c0 .414.336.75.75.75H6a.75.75 0 0 0 .75-.75V13a.75.75 0 0 0-.75-.75h-.01Z");
		builder.AddAttribute(16, "clip-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
    }
}
