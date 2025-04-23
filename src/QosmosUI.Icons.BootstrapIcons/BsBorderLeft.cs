// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BootstrapIcons;

public class BsBorderLeft : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0v16h1V0zm1.906 1h.938V0h-.938zm1.875 0h.938V0H3.78v1zm1.875 0h.938V0h-.938zM7.531.969V1h.938V.969H8.5V.5h-.031V0H7.53v.5H7.5v.469zM9.406 1h.938V0h-.938zm1.875 0h.938V0h-.938zm1.875 0h.938V0h-.938zm1.875 0h.469V.969h.5V0h-.969v.5H15v.469h.031zM7.5 1.906v.938h1v-.938zm7.5 0v.938h1v-.938zM7.5 3.781v.938h1V3.78h-1zm7.5 0v.938h1V3.78h-1zM7.5 5.656v.938h1v-.938zm7.5 0v.938h1v-.938zM1.906 8.5h.938v-1h-.938zm1.875 0h.938v-1H3.78v1zm1.875 0h.938v-1h-.938zm2.813 0v-.031H8.5V7.53h-.031V7.5H7.53v.031H7.5v.938h.031V8.5zm.937 0h.938v-1h-.938zm1.875 0h.938v-1h-.938zm1.875 0h.938v-1h-.938zm1.875 0h.469v-.031h.5V7.53h-.5V7.5h-.469v.031H15v.938h.031zM7.5 9.406v.938h1v-.938zm8.5.938v-.938h-1v.938zm-8.5.937v.938h1v-.938zm8.5.938v-.938h-1v.938zm-8.5.937v.938h1v-.938zm8.5.938v-.938h-1v.938zM1.906 16h.938v-1h-.938zm1.875 0h.938v-1H3.78v1zm1.875 0h.938v-1h-.938zm1.875-.5v.5h.938v-.5H8.5v-.469h-.031V15H7.53v.031H7.5v.469zm1.875.5h.938v-1h-.938zm1.875 0h.938v-1h-.938zm1.875 0h.938v-1h-.938zm1.875-.5v.5H16v-.969h-.5V15h-.469v.031H15v.469z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
