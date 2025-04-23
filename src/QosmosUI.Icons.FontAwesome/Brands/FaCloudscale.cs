// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaCloudscale : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 448 512";

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
		builder.AddAttribute(14, "d", "M318.1 154l-9.4 7.6c-22.5-19.3-51.5-33.6-83.3-33.6C153.8 128 96 188.8 96 260.3c0 6.6.4 13.1 1.4 19.4-2-56 41.8-97.4 92.6-97.4 24.2 0 46.2 9.4 62.6 24.7l-25.2 20.4c-8.3-.9-16.8 1.8-23.1 8.1-11.1 11-11.1 28.9 0 40 11.1 11 28.9 11 40 0 6.3-6.3 9-14.9 8.1-23.1l75.2-88.8c6.3-6.5-3.3-15.9-9.5-9.6zm-83.8 111.5c-5.6 5.5-14.6 5.5-20.2 0-5.6-5.6-5.6-14.6 0-20.2s14.6-5.6 20.2 0 5.6 14.7 0 20.2zM224 32C100.5 32 0 132.5 0 256s100.5 224 224 224 224-100.5 224-224S347.5 32 224 32zm0 384c-88.2 0-160-71.8-160-160S135.8 96 224 96s160 71.8 160 160-71.8 160-160 160z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
