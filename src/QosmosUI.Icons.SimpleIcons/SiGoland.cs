// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiGoland : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 0v24h24V0Zm6.764 3a5.448 5.448 0 0 1 3.892 1.356L9.284 6.012A3.652 3.652 0 0 0 6.696 5c-1.6 0-2.844 1.4-2.844 3.08v.028c0 1.812 1.244 3.14 3 3.14a3.468 3.468 0 0 0 2.048-.596V9.228H6.708v-1.88H11v4.296a6.428 6.428 0 0 1-4.228 1.572c-3.076 0-5.196-2.164-5.196-5.092v-.028A5.08 5.08 0 0 1 6.764 3Zm10.432 0c3.052 0 5.244 2.276 5.244 5.088v.028a5.116 5.116 0 0 1-5.272 5.12c-3.056-.02-5.248-2.296-5.248-5.112v-.028A5.116 5.116 0 0 1 17.196 3Zm-.028 2A2.96 2.96 0 0 0 14.2 8.068v.028a3.008 3.008 0 0 0 3 3.112 2.96 2.96 0 0 0 2.964-3.084v-.028A3.004 3.004 0 0 0 17.168 5ZM2.252 19.5h9V21h-9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
