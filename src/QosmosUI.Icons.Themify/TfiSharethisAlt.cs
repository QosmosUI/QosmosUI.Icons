// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiSharethisAlt : ComponentBase
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
		builder.AddAttribute(15, "d", "M16.5 13.5c0 1.656-1.344 3-3 3h-10c-1.656 0-3-1.344-3-3v-10c0-1.656 1.344-3 3-3h10c1.656 0 3 1.344 3 3v10zM11.614 9.386c-0.583 0-1.114 0.229-1.51 0.604l-2.51-1.25c0.010-0.084 0.020-0.156 0.020-0.24s-0.010-0.156-0.021-0.24l2.51-1.249c0.396 0.375 0.927 0.604 1.51 0.604 1.219 0 2.219-0.999 2.219-2.229 0-1.219-1-2.219-2.219-2.219-1.229 0-2.229 1-2.229 2.219 0 0.083 0.010 0.156 0.021 0.239l-2.51 1.25c-0.395-0.365-0.926-0.594-1.509-0.594-1.219 0-2.219 0.989-2.219 2.219s1 2.219 2.219 2.219c0.583 0 1.114-0.229 1.51-0.594l2.51 1.25c-0.011 0.083-0.021 0.156-0.021 0.239 0 1.219 1 2.219 2.229 2.219 1.219 0 2.219-1 2.219-2.219 0-1.229-1-2.228-2.219-2.228z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
