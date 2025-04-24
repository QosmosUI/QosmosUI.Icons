// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCalendarHalfYear : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M25 57v30h62V57H25zm160 0v62h62V57h-62zm80 0v14h62V57h-62zm80 0v39h62V57h-62zm80 0v78h62V57h-62zM105 73v78h62V73h-62zm160 16v78h62V89h-62zM25 105v78h62v-78H25zm320 9v78h62v-78h-62zm-160 23v78h62v-78h-62zm240 16v78h62v-78h-62zm-320 16v78h62v-78h-62zm160 16v78h62v-78h-62zM25 201v78h62v-78H25zm320 9v78h62v-78h-62zm-160 23v78h62v-78h-62zm240 16v78h62v-78h-62zm-320 16v78h62v-78h-62zm160 16v78h62v-78h-62zM25 297v78h62v-78H25zm320 9v78h62v-78h-62zm-160 23v78h62v-78h-62zm240 16v78h62v-78h-62zm-320 16v94h62v-94h-62zm160 16v78h62v-78h-62zM25 393v78h62v-78H25zm320 9v69h62v-69h-62zm-160 23v46h62v-46h-62zm240 16v14h62v-14h-62z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
