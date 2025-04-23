// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoPaperclip : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.187 3.588a2.75 2.75 0 0 0-3.889 0L5.575 13.31a4.5 4.5 0 0 0 6.364 6.364l8.662-8.662a.75.75 0 0 1 1.061 1.06L13 20.735a6 6 0 0 1-8.485-8.485l9.723-9.723a4.247 4.247 0 0 1 4.124-1.139 4.247 4.247 0 0 1 3.025 3.025 4.247 4.247 0 0 1-1.139 4.124l-9.193 9.193a2.64 2.64 0 0 1-1.858.779 2.626 2.626 0 0 1-1.854-.779c-.196-.196-.338-.47-.43-.726a2.822 2.822 0 0 1-.168-.946c0-.7.284-1.373.775-1.864l8.132-8.131a.749.749 0 0 1 1.275.326.749.749 0 0 1-.215.734l-8.131 8.132a1.148 1.148 0 0 0-.336.803c.003.204.053.405.146.587.01.018.018.028.02.032.22.215.501.332.786.332.29 0 .58-.121.798-.34l9.192-9.192a2.75 2.75 0 0 0 0-3.89Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
