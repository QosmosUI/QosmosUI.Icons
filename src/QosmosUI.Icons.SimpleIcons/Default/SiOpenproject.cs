// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiOpenproject : ComponentBase
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
		builder.AddAttribute(15, "d", "M19.35.37h-1.86a4.628 4.628 0 0 0-4.652 4.624v5.609H4.652A4.628 4.628 0 0 0 0 15.23v3.721c0 2.569 2.083 4.679 4.652 4.679h1.86c2.57 0 4.652-2.11 4.652-4.679v-3.72c0-.063 0-.158-.005-.158H8.373v3.88c0 1.026-.835 1.886-1.861 1.886h-1.86c-1.027 0-1.861-.864-1.861-1.886V15.23a1.839 1.839 0 0 1 1.86-1.833h14.697c2.57 0 4.652-2.11 4.652-4.679V4.997A4.628 4.628 0 0 0 19.35.37Zm1.861 8.345c0 1.026-.835 1.886-1.861 1.886h-3.721V4.997a1.839 1.839 0 0 1 1.86-1.833h1.86a1.839 1.839 0 0 1 1.862 1.833zm-8.373 9.706a.236.236 0 0 0 0 .03c0 .746.629 1.344 1.396 1.344.767 0 1.395-.594 1.395-1.34a.188.188 0 0 0 0-.034v-3.35h-2.791z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
