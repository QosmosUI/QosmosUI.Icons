// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCheckmarx : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.544.12A6.553 6.553 0 0 0 0 6.664v10.674a6.551 6.551 0 0 0 6.544 6.542h10.912A6.551 6.551 0 0 0 24 17.338v-.831a2.193 2.193 0 0 0-4.388 0v.83c0 1.19-.967 2.157-2.156 2.157H6.544a2.16 2.16 0 0 1-2.158-2.156V6.748c0-1.19.969-2.16 2.158-2.16 3.843.004 7.814-.009 11.612.001.556.138.892.445 1.058.848.193.47.343 1.118-.404 1.748l-6.26 4.596-1.892-2.441a2.191 2.191 0 0 0-3.075-.391 2.191 2.191 0 0 0-.391 3.076l3.198 4.133a2.197 2.197 0 0 0 3.035.424l7.252-5.301a56.68 56.68 0 0 0 1.22-.977c2.106-1.926 2.517-4.393 1.627-6.553C22.603 1.51 20.268.12 17.435.12Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
