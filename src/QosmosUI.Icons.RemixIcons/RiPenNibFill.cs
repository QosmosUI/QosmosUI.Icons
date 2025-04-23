// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiPenNibFill : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M4.92898 21.4819L10.775 15.6359C11.4423 15.8141 12.1837 15.6414 12.7071 15.118C13.4882 14.3369 13.4882 13.0706 12.7071 12.2896C11.9261 11.5085 10.6598 11.5085 9.87872 12.2896C9.35526 12.813 9.18263 13.5544 9.36081 14.2217L3.51476 20.0677L2.4541 19.0071C5.28253 15.7072 6.34319 12.0539 7.7574 5.9256L14.1214 5.21849L19.7783 10.8754L19.0711 17.2393C12.9429 18.6535 9.28947 19.7142 5.98964 22.5426L4.92898 21.4819ZM16.5962 2.03651L22.9428 8.38312C23.1381 8.57838 23.1381 8.89496 22.9428 9.09022C22.8679 9.16513 22.7712 9.21431 22.6665 9.23067L21.1924 9.46113L15.5356 3.80428L15.7477 2.31935C15.7868 2.04599 16.04 1.85604 16.3134 1.89509C16.4205 1.91039 16.5197 1.96001 16.5962 2.03651Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
