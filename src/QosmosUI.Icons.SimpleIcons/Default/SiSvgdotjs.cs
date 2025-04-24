// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSvgdotjs : ComponentBase
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
		builder.AddAttribute(15, "d", "M24 12 12 0 0 12l12 12 12-12Zm-18.569-.554 4.665-4.665c.335-.601.841-1.258 1.565-1.982a.4798.4798 0 0 1 .678 0c.187.187.187.491 0 .678-1.254 1.254-1.786 2.24-1.836 3.093-.035.59.174 1.1.49 1.573.36.536.854 1.026 1.346 1.518 1.13 1.13 2.206 2.289 2.116 3.826-.015.256-.063.525-.149.808l4.002-4.002a.6147.6147 0 0 1-.073-.293c0-.346.281-.627.627-.627s.627.281.627.627-.281.627-.627.627a.6147.6147 0 0 1-.293-.073l-4.665 4.665c-.335.601-.841 1.258-1.565 1.982a.4798.4798 0 0 1-.678 0 .4798.4798 0 0 1 0-.678c1.254-1.254 1.786-2.24 1.836-3.093.035-.59-.174-1.1-.49-1.573-.36-.536-.854-1.026-1.346-1.518-1.13-1.13-2.206-2.289-2.116-3.826.015-.256.063-.525.149-.808l-4.002 4.002c.047.087.073.187.073.293 0 .346-.281.627-.627.627A.6274.6274 0 0 1 4.511 12c0-.346.281-.627.627-.627.106 0 .206.026.293.073Zm-.293.296c.143 0 .258.115.258.258 0 .143-.115.258-.258.258A.2573.2573 0 0 1 4.88 12c0-.143.115-.258.258-.258Zm13.724 0c.143 0 .258.115.258.258 0 .143-.115.258-.258.258a.2573.2573 0 0 1-.258-.258c0-.143.115-.258.258-.258Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
