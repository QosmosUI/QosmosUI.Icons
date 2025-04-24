// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiComments : ComponentBase
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
		builder.AddAttribute(15, "d", "M17 1.5v7.969c0 0.827-0.673 1.5-1.5 1.5h-0.508v-1h0.508c0.276 0 0.5-0.225 0.5-0.5v-7.969c0-0.275-0.224-0.5-0.5-0.5h-14c-0.276 0-0.5 0.225-0.5 0.5v7.969c0 0.275 0.224 0.5 0.5 0.5h1.5v2.892l1.779-1.569 0.661 0.75-3.44 3.035v-4.108h-0.5c-0.827 0-1.5-0.673-1.5-1.5v-7.969c0-0.827 0.673-1.5 1.5-1.5h14c0.827 0 1.5 0.673 1.5 1.5zM14.020 9.54v3.043c0 0.827-0.673 1.5-1.5 1.5h-0.5v3.064l-3.667-3.064h-0.853c-0.827 0-1.5-0.673-1.5-1.5v-3.043c0-0.827 0.673-1.5 1.5-1.5h5.020c0.827 0 1.5 0.673 1.5 1.5zM13.020 9.54c0-0.275-0.224-0.5-0.5-0.5h-5.020c-0.276 0-0.5 0.225-0.5 0.5v3.043c0 0.275 0.224 0.5 0.5 0.5h1.217l2.303 1.926v-1.926h1.5c0.276 0 0.5-0.225 0.5-0.5v-3.043z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
