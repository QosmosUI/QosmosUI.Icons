// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiTrillertv : ComponentBase
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
		builder.AddAttribute(15, "d", "m9.496.07-1.8 3.107-.868-.498c-1.269-.729-2.852.184-2.852 1.64v6.28l3.9-6.734L9.933.319a.14.14 0 0 0-.053-.19l-.19-.11a.143.143 0 0 0-.193.05Zm-.713 3.734-4.807 8.301v7.163c0 .674.338 1.23.826 1.562l-1.65 2.85a.14.14 0 0 0 .05.192l.192.109a.142.142 0 0 0 .193-.05l1.665-2.874L13.629 6.59Zm11.63 2.547-1.8 3.108-4.33-2.49-8.217 14.186a1.91 1.91 0 0 0 .764-.248l8.598-4.948 5.42-9.356a.141.141 0 0 0-.05-.193c-.065-.035-.128-.073-.192-.11-.027-.02-.14-.041-.193.051zm-.711 3.735-2.967 5.123 3.08-1.774c1.268-.731 1.268-2.556 0-3.285z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
