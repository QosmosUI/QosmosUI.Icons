// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiSpannerOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "circle");
		builder.AddAttribute(15, "cx", "8");
		builder.AddAttribute(16, "cy", "16");
		builder.AddAttribute(17, "r", "1");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M20.733 4.657c-.392-.378-1.013-.377-1.399.009.387-.386.388-1.008.01-1.4-1.078-.792-2.405-1.266-3.844-1.266-3.59 0-6.5 2.91-6.5 6.5l.031.379c-.337.239-2.893 2.147-4.258 3.301-1.135.99-1.773 2.375-1.773 3.82 0 2.757 2.243 5 5 5 1.465 0 2.854-.65 3.811-1.784 1.173-1.375 3.08-3.923 3.317-4.229l.372.013c3.59 0 6.5-2.91 6.5-6.5 0-1.44-.474-2.766-1.267-3.843zm-12.733 14.343c-1.656 0-3-1.343-3-3 0-.92.423-1.732 1.064-2.292 2.368-2.002 3.617-2.748 5.115-4.015-.105-.382-.179-.777-.179-1.193 0-2.485 2.015-4.5 4.5-4.5.47 0 .914.092 1.339.226l-2.839 2.774.5 2.5 2.5.5 2.805-2.741c.115.396.195.807.195 1.241 0 2.485-2.015 4.5-4.5 4.5-.416 0-.811-.074-1.193-.18-1.267 1.498-2.013 2.748-4.024 5.105-.551.652-1.363 1.075-2.283 1.075zm11.384-12.729l-2.705 2.645-1.329-.266-.263-1.314 2.726-2.663c.651.393 1.19.939 1.571 1.598z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
