// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiDtube : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 1.6416v20.7168h8.5156c1.3133 0 2.4886-.1588 3.5371-.4766 1.038-.3177 1.9716-.7833 2.7871-1.4082 1.1545-.8896 2.0431-2.0456 2.668-3.4648.6143-1.4192.9316-3.0486.9316-4.8809-.0105-1.578-.243-3.0203-.709-4.3125-.466-1.2921-1.1116-2.3919-1.959-3.3027-.8366-.9109-1.8536-1.6108-3.0292-2.1191-1.1757-.4979-2.4784-.752-3.9082-.752zm5.2012 5.709l8.039 4.6601-8.039 4.6485zm15.9922 9.162c-1.4934 0-2.711 1.2177-2.711 2.711 0 1.4934 1.2176 2.711 2.711 2.711h.0957c1.4933 0 2.7109-1.2176 2.7109-2.711 0-1.4933-1.2176-2.711-2.711-2.711z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
