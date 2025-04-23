// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiRumahweb : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 12.149c.028-.275.148-.543.36-.753l7.182-7.092a.972.972 0 0 1 .103-.091c.308-.265 1.807-1.473 3.743-1.553h.402c1.126.047 2.374.5 3.61 1.731 2.534 2.542 5.076 5.077 7.615 7.615 1.14 1.14 1.198 2.585.642 3.795a4.043 4.043 0 0 1-.819 1.173 3.973 3.973 0 0 1-1.188.823c-1.208.537-2.646.458-3.86-.753l-.053-.056-6.222-6.061a.93.93 0 0 0-1.03-.207 1.6 1.6 0 0 0-.499.325c-.15.141-.272.304-.352.473-.136.291-.141.627.085.907l6.806 6.802c.483.485.481 1.27-.005 1.752a1.246 1.246 0 0 1-1.758-.004l-6.889-6.89c-.999-1.138-1.021-2.48-.488-3.614a4.087 4.087 0 0 1 2.185-2.05c1.183-.468 2.553-.365 3.679.731 2.103 2.044 4.197 4.098 6.304 6.138.359.356.76.392 1.085.248a1.6 1.6 0 0 0 .76-.763c.154-.335.148-.726-.146-1.018-2.54-2.533-5.07-5.077-7.615-7.605-1.977-1.973-4.04-.345-4.347-.082l-7.178 7.086a1.245 1.245 0 0 1-1.757-.003A1.248 1.248 0 0 1 0 12.402v-.253Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
