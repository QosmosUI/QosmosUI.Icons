// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BootstrapIcons.Default;

public class BsBorder : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M0 0h.969v.5H1v.469H.969V1H.5V.969H0zm2.844 1h-.938V0h.938zm1.875 0H3.78V0h.938v1zm1.875 0h-.938V0h.938zm.937 0V.969H7.5V.5h.031V0h.938v.5H8.5v.469h-.031V1zm2.813 0h-.938V0h.938zm1.875 0h-.938V0h.938zm1.875 0h-.938V0h.938zM15.5 1h-.469V.969H15V.5h.031V0H16v.969h-.5zM1 1.906v.938H0v-.938zm6.5.938v-.938h1v.938zm7.5 0v-.938h1v.938zM1 3.78v.938H0V3.78zm6.5.938V3.78h1v.938zm7.5 0V3.78h1v.938zM1 5.656v.938H0v-.938zm6.5.938v-.938h1v.938zm7.5 0v-.938h1v.938zM.969 8.5H.5v-.031H0V7.53h.5V7.5h.469v.031H1v.938H.969zm1.875 0h-.938v-1h.938zm1.875 0H3.78v-1h.938v1zm1.875 0h-.938v-1h.938zm1.875-.031V8.5H7.53v-.031H7.5V7.53h.031V7.5h.938v.031H8.5v.938zm1.875.031h-.938v-1h.938zm1.875 0h-.938v-1h.938zm1.875 0h-.938v-1h.938zm1.406 0h-.469v-.031H15V7.53h.031V7.5h.469v.031h.5v.938h-.5zM0 10.344v-.938h1v.938zm7.5 0v-.938h1v.938zm8.5-.938v.938h-1v-.938zM0 12.22v-.938h1v.938zm7.5 0v-.938h1v.938zm8.5-.938v.938h-1v-.938zM0 14.094v-.938h1v.938zm7.5 0v-.938h1v.938zm8.5-.938v.938h-1v-.938zM.969 16H0v-.969h.5V15h.469v.031H1v.469H.969zm1.875 0h-.938v-1h.938zm1.875 0H3.78v-1h.938v1zm1.875 0h-.938v-1h.938zm.937 0v-.5H7.5v-.469h.031V15h.938v.031H8.5v.469h-.031v.5zm2.813 0h-.938v-1h.938zm1.875 0h-.938v-1h.938zm1.875 0h-.938v-1h.938zm.937 0v-.5H15v-.469h.031V15h.469v.031h.5V16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
