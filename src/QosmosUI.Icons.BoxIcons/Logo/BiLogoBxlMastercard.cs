// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlMastercard : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.454 17.021c.048.041.1.082.151.122a6.173 6.173 0 0 1-3.42 1.03A6.17 6.17 0 0 1 2.01 12a6.175 6.175 0 0 1 9.592-5.144c-.05.043-.1.082-.138.126A6.633 6.633 0 0 0 9.166 12c0 1.925.833 3.755 2.288 5.021zm4.361-11.195a6.14 6.14 0 0 0-3.416 1.03c.049.043.099.082.137.126 1.462 1.263 2.299 3.094 2.299 5.018s-.835 3.753-2.288 5.021c-.049.041-.101.082-.151.122a6.162 6.162 0 0 0 3.418 1.03 6.174 6.174 0 1 0 .001-12.347zM12 7.15A6.152 6.152 0 0 0 9.644 12 6.15 6.15 0 0 0 12 16.853 6.157 6.157 0 0 0 14.357 12 6.15 6.15 0 0 0 12 7.15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
