// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Brands;

public class FaSquareDribbble : ComponentBase
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
		builder.AddAttribute(14, "d", "M165.9 132.5c-38.3 18-66.8 53.3-75.7 95.7c6.1 .1 62.4 .3 126.4-16.7c-22.7-40.2-47.1-74.1-50.7-79zm26.1-9.1c3.8 5.1 28.6 38.9 51 80c48.6-18.3 69.1-45.9 71.6-49.4C281 124.2 235.3 112.9 192 123.4zM277.4 382c-2-12-10-53.8-29.2-103.6c-55.1 18.8-93.8 56.4-108.1 85.6c40.5 31.6 93.3 36.7 137.3 18zM227.8 232.6C159.6 253 93.4 252.2 87.4 252c0 .7 0 1.4 0 2.1s0 1.4 0 2.1c0 35.1 13.3 67.1 35.1 91.4c22.2-37.9 67.1-77.9 116.5-91.8c-3.4-7.8-7.2-15.5-11.1-23.2zm72.5 136.9c30.7-20.7 52.5-53.6 58.6-91.6c-4.6-1.5-42.3-12.7-85.1-5.8c17.9 49.1 25.1 89.1 26.5 97.4zm-34.8-119c45.5-5.7 90.7 3.4 95.2 4.4c-.3-32.3-11.8-61.9-30.9-85.1c-2.9 3.9-25.8 33.2-76.3 53.9c4.8 9.8 8.3 17.8 12 26.8zM384 32H64C28.7 32 0 60.7 0 96V416c0 35.3 28.7 64 64 64H384c35.3 0 64-28.7 64-64V96c0-35.3-28.7-64-64-64zM224 416a160 160 0 1 1 0-320 160 160 0 1 1 0 320z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
