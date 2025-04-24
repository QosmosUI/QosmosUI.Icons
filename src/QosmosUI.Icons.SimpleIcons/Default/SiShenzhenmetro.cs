// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiShenzhenmetro : ComponentBase
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
		builder.AddAttribute(15, "d", "M.27 0v.155c0 4.69 3.033 8.751 7.331 10.434v2.736C3.303 14.99.271 19.019.271 23.768V24H4.36v-.232c0-2.459 1.278-4.623 3.24-5.934V24h3.165v-7.384c.408-.065.82-.098 1.234-.1.423 0 .834.038 1.235.1V24h3.165v-6.148c1.925 1.313 3.163 3.469 3.163 5.916V24h4.168v-.232c0-4.691-3.033-8.751-7.331-10.434V10.6c4.298-1.665 7.33-5.696 7.33-10.446V.001h-4.09v.154c0 2.458-1.277 4.622-3.24 5.934V0h-3.165v7.305c-.408.066-.821.1-1.235.103a8.11 8.11 0 0 1-1.234-.103V.001H7.6V6.07C5.675 4.757 4.438 2.602 4.438.154V.001zm10.495 11.358c.82.084 1.648.084 2.469.001v1.205a12.236 12.236 0 0 0-2.47 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
