// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrMedium : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

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
		builder.AddAttribute(14, "d", "M6.783 5a6.783 6.783 0 1 0 0 13.565A6.783 6.783 0 0 0 6.783 5Zm10.695.522c-1.873 0-3.391 2.803-3.391 6.26 0 .65.053 1.274.152 1.862.132.784.346 1.502.622 2.121.138.31.292.594.46.849.335.51.724.904 1.149 1.148.319.183.657.282 1.008.282s.69-.1 1.009-.282c.425-.244.814-.638 1.149-1.148.167-.255.321-.54.46-.849.276-.618.49-1.337.621-2.12.1-.589.153-1.214.153-1.862 0-3.458-1.519-6.261-3.392-6.261Zm5.218.521c-.136 0-.266.09-.388.259-.082.111-.16.257-.234.434a4.007 4.007 0 0 0-.107.288c-.07.206-.134.441-.193.7-.118.52-.214 1.138-.28 1.825a22.61 22.61 0 0 0-.103 2.234 24.502 24.502 0 0 0 .103 2.234c.066.686.162 1.305.28 1.824.059.26.123.495.193.7.034.104.07.2.107.288.074.177.153.323.234.435.122.168.253.258.388.258.72 0 1.304-2.57 1.304-5.74 0-3.169-.584-5.739-1.304-5.739Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
