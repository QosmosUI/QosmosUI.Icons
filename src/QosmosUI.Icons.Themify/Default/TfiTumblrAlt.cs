// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiTumblrAlt : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M9.104 0.5v4.042h3.793v2.51h-3.793v4.104c0 0.927 0.042 1.521 0.146 1.792 0.094 0.261 0.281 0.468 0.541 0.625 0.354 0.218 0.761 0.323 1.219 0.323 0.813 0 1.615-0.261 2.417-0.793v2.521c-0.688 0.323-1.302 0.552-1.854 0.678-0.553 0.135-1.156 0.197-1.803 0.197-0.729 0-1.374-0.094-1.938-0.281-0.562-0.177-1.042-0.448-1.437-0.781-0.395-0.343-0.676-0.708-0.822-1.093-0.156-0.386-0.229-0.947-0.229-1.677v-5.615h-1.771v-2.261c0.624-0.207 1.166-0.5 1.614-0.874 0.449-0.386 0.803-0.844 1.074-1.375 0.27-0.542 0.458-1.219 0.562-2.042h2.281z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
