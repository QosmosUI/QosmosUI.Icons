// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPdm : ComponentBase
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
		builder.AddAttribute(15, "d", "M10.44.418a3.12 3.12 0 0 1 3.12 0l7.69 4.44a3.12 3.12 0 0 1 1.56 2.702v8.88a3.12 3.12 0 0 1-1.56 2.702l-7.69 4.44a3.12 3.12 0 0 1-3.12 0l-7.69-4.44a3.12 3.12 0 0 1-1.56-2.702V7.56a3.12 3.12 0 0 1 1.56-2.702Zm3.87 3.315L12.311 2.58a.624.624 0 0 0-.624 0l-7.69 4.44a.624.624 0 0 0-.312.54v3.774l10.623-6.133Zm2.496 13.643 1.255.725 1.941-1.12a.624.624 0 0 0 .312-.541V7.56a.624.624 0 0 0-.312-.54l-3.196-1.845Zm-2.497-1.441V8.083l-6.8 3.926ZM3.686 14.217v2.223c0 .223.119.429.312.54l7.69 4.44a.624.624 0 0 0 .624 0l3.252-1.878-10.55-6.091Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
