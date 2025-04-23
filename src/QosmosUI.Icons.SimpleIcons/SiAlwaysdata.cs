// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAlwaysdata : ComponentBase
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
		builder.AddAttribute(15, "d", "M23.0536 15.2543c1.2615 1.2625 1.2622 3.3114 0 4.5728-1.2617 1.2621-3.3068 1.2607-4.5687-.0018-.9599-.9598-1.1874-2.3713-.6878-3.5476L12.97 8.9472a2.903 2.903 0 0 1-.765-.0068l-4.6071 6.2009c.2567.7533.0937 1.6183-.5072 2.2176-.8397.8413-2.2063.8399-3.0474-.0017-.6534-.6533-.7916-1.622-.428-2.4164l-2.0027-2.9336c-.0585.0072-.116.0176-.1766.0176-.7923 0-1.4359-.642-1.4359-1.4356 0-.7928.6436-1.4359 1.436-1.4359.7936 0 1.4358.6431 1.4358 1.436 0 .2516-.0703.485-.1838.6904l2.0731 2.5544c.5163-.2096 1.069-.191 1.5494-.0132l3.8572-6.2123c-.686-1.107-.5521-2.5782.4096-3.5401 1.1215-1.1218 2.9412-1.1218 4.0608-.0007.8791.8786 1.0666 2.1881.5676 3.2539l5.24 7.0044c.9312-.0937 1.8947.215 2.608.9282z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
