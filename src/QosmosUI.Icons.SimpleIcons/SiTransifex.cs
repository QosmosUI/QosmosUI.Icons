// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiTransifex : ComponentBase
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
		builder.AddAttribute(15, "d", "m20.073 12.851-2.758-2.757 3.722-3.659a.33.33 0 0 1 .467.003l2.27 2.309a.33.33 0 0 1-.004.468zm0 0h-.001zm-9.04-6.433 12.87 12.869c.129.13.129.34 0 .469l-2.289 2.289a.331.331 0 0 1-.468 0l-5.168-5.168-2.863 2.815c-.604.593-1.244 1.159-1.975 1.591a7.037 7.037 0 0 1-2.248.83c-2.191.42-4.557-.047-6.303-1.468A7.065 7.065 0 0 1 0 15.207V2.069a.33.33 0 0 1 .331-.33h3.237a.33.33 0 0 1 .331.33v4.125H6.65c.178 0 .323.145.323.323v3.617a.323.323 0 0 1-.323.323H3.899v4.75c0 1.272.808 2.429 1.988 2.893.753.295 1.617.321 2.397.131.852-.206 1.484-.717 2.097-1.319l2.839-2.792-4.945-4.945a.331.331 0 0 1 0-.468l2.289-2.289a.333.333 0 0 1 .469 0");
		builder.CloseElement();
		builder.CloseElement();
    }
}
