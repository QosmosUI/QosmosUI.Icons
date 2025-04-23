// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiTrousers : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M258.375 21.156c-44.557.187-87.24 7.376-118.563 21l-1.78 16.094h25.655v18.688H136l-2.125 19.406h29.813v18.687h-31.875l-38.72 352.876 123.344 24.813 34.157-262.845H236.688v-97.749H220.94V115.03h-38.562V96.345h38.563V76.938h-38.563V58.25h38.563V41.53h90.938v16.72h33.03v18.688h-33.03v19.406h33.03v18.687h-33.03v17.095h-56.499v79.063h27.406v18.687h-11.56l34.25 263.75h.217l129.063-26.28-38.72-352.314h-32.436V96.345H394l-2.156-19.406h-28.25V58.25h26.22l-1.783-16.094c-38.697-14.308-85.098-21.17-129.655-21zm-18.75 39.063v17.468h34.938v18.687h-34.938v17.063h53.563v-53.22h-53.563z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
