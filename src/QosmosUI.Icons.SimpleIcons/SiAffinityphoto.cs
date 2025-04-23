// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAffinityphoto : ComponentBase
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
		builder.AddAttribute(15, "d", "M24 2.344v19.312A2.345 2.345 0 0 1 21.656 24H2.344A2.345 2.345 0 0 1 0 21.656V2.344A2.345 2.345 0 0 1 2.344 0h19.312A2.345 2.345 0 0 1 24 2.344Zm-13.328-.586-.41.709 5.021 8.693 5.43-9.402H10.672Zm2.213 7.702H11.12a.901.901 0 0 0-.75.446l-.925 1.605-.007.011a.901.901 0 0 0 0 .872l.924 1.599.01.017a.893.893 0 0 0 .755.428c.002 0 1.178.001 1.765-.002a.888.888 0 0 0 .75-.436c.311-.539.624-1.077.933-1.617a.879.879 0 0 0-.006-.863l-.008-.013-.921-1.595-.005-.008a.897.897 0 0 0-.75-.444ZM2.36 22.18 9.699 9.475H6.215l-4.457 7.717.002 4.182a.94.94 0 0 0 .6.806Zm11.844.062-5.479-9.486-5.485 9.486h10.964ZM12.926 8.676l-3.125-5.41-3.125 5.41h6.25Zm9.316 6.56H11.08l4.046 7.006h6.197a.938.938 0 0 0 .919-.937v-6.069Zm-.635-13.428-7.295 12.63h7.93V2.695a.938.938 0 0 0-.635-.887Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
