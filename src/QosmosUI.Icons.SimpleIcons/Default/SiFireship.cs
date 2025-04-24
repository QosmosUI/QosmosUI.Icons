// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiFireship : ComponentBase
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
		builder.AddAttribute(15, "d", "M9.245.05c-.042-.035-.14-.035-.22-.05-.041.06-.098.113-.113.166a3.114 3.114 0 0 0-.064.416 15.42 15.42 0 0 1-3.742 8.693c-1.258 1.474-2.51 2.982-3.44 4.585-2.293 3.972-.249 8.031 4.763 9.804.163.06.348.087.76.181-1.701-1.534-2.57-3.1-2.28-4.944.284-1.765 1.172-3.337 2.525-4.77a1.043 1.043 0 0 1 .099.549c-.068 1.572.453 2.96 2.063 4.055.741.507 1.41 1.081 2.079 1.644.684.57.884 1.263.688 2.015-.09.366-.227.725-.378 1.171 1.145-.11 2.203-.264 2.914-.9.68-.604 1.183-1.322 1.909-2.154.049.707.15 1.255.113 1.8-.045.566-.22 1.126-.336 1.689 3.477-.525 6.546-3.934 6.682-7.427.098-2.543-2.071-6.274-3.893-6.637l.302.688c.631 1.391.817 2.8.416 4.256-.4 1.448-2.426 3.073-4.214 3.277.06-.144.087-.28.17-.39 1.927-2.596 1.946-5.31.854-8.084C15.44 5.98 12.632 2.88 9.245.053Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
