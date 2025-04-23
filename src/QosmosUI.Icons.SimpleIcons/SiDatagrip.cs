// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiDatagrip : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 0v24h24V0Zm17.1797 2.9477a5.452 5.452 0 0 1 3.9047 1.364L19.7078 5.972a3.672 3.672 0 0 0-2.596-1.0086c-1.6 0-2.8555 1.408-2.8555 3.096v.0282c0 1.816 1.2517 3.1523 3.0117 3.1523a3.492 3.492 0 0 0 2.064-.5921V9.2234h-2.2V7.336h4.3157v4.3157a6.436 6.436 0 0 1-4.2438 1.5757c-3.096 0-5.2242-2.1797-5.2242-5.1117v-.0281a5.1 5.1 0 0 1 5.2-5.1398zm-14.7438.1718h3.8758c3.12 0 5.2805 2.1439 5.2805 4.9399v.028c0 2.8-2.1605 4.968-5.2805 4.968H2.436Zm4.075 1.9688a2.852 2.852 0 0 0-.1992.003H4.6203v6h1.6914A2.832 2.832 0 0 0 9.304 8.1235v-.036a2.852 2.852 0 0 0-2.793-2.9991Zm-4.303 14.407h9v1.5h-9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
