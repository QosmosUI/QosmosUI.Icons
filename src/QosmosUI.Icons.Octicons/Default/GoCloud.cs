// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons.Default;

public class GoCloud : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M3.103 10.107c0-4.244 3.445-7.607 7.733-7.607 3.19 0 5.912 1.858 7.099 4.563l.01.022.001.006C21.348 7.345 24 10.095 24 13.536 24 17.148 21.076 20 17.431 20H5.017C2.23 20 0 17.83 0 15.06a4.899 4.899 0 0 1 3.112-4.581 7.696 7.696 0 0 1-.009-.372ZM10.836 4c-3.485 0-6.233 2.717-6.233 6.107 0 .284.022.602.052.756a.75.75 0 0 1-.552.869c-1.52.385-2.603 1.712-2.603 3.328 0 1.917 1.532 3.44 3.517 3.44h12.414c2.843 0 5.069-2.206 5.069-4.964 0-2.759-2.226-4.965-5.069-4.965a.75.75 0 0 1-.696-.47l-.179-.446C15.606 5.5 13.424 4 10.836 4Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
