// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiRenren : ComponentBase
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
		builder.AddAttribute(15, "d", "M5.66 9.553V5.254A6.794 6.794 0 0 0 1.606 16.34c2.379-1.152 4.042-3.755 4.054-6.787zm1.132 4.115c-.423 1.752-1.687 3.25-3.262 4.245a6.76 6.76 0 0 0 3.26.833 6.772 6.772 0 0 0 3.264-.833c-1.575-.996-2.84-2.494-3.262-4.245zm5.184-6.103a6.79 6.79 0 0 0-4.052-2.31V9.52c0 3.045 1.667 5.663 4.051 6.818a6.767 6.767 0 0 1-1.607-4.387 6.755 6.755 0 0 1 1.608-4.386zc1.003 1.183 1.655 2.714 1.655 4.387 0 1.674-.65 3.203-1.655 4.388 2.38-1.15 4.088-3.755 4.1-6.787V5.254a6.9 6.901 0 0 0-4.1 2.31zM18.34 9.52c0 3.046 1.667 5.663 4.053 6.82A6.793 6.793 0 0 0 18.34 5.255zm-1.132 4.148c-.423 1.752-1.687 3.25-3.263 4.245a6.76 6.76 0 0 0 3.262.833 6.772 6.772 0 0 0 3.263-.833c-1.575-.996-2.839-2.494-3.262-4.245z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
