// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiKeeweb : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.4138 24c-.2293-.0004-.4838-.0966-.7462-.2342-.5598-.2937-.9436-.665-.6231-1.2759l7.786-14.8424a58 58 0 0 1-.2224-.1157C9.8007 6.059 8.5551 3.8816 9.5635 1.9594c1.159-2.2094 4.7486-2.6104 8.0176-.8956 3.269 1.7149 4.9794 4.8961 3.8204 7.1056-.9968 1.9001-3.5993 2.0696-6.2161.6968a85 85 0 0 0-.3215-.1672L7.0716 23.5533c-.1703.3246-.3979.4471-.6578.4467m-1.4335-3.1798-.1474-.0773-.0328-.0171-1.9943-1.0463-.4808-.2522a.1664.1664 0 0 1-.0701-.2247l.6312-1.2032a.1665.1665 0 0 1 .2235-.0707l.0013.0006.9615.5044a.1665.1665 0 0 0 .2247-.0701l.6312-1.2031a.1665.1665 0 0 0-.0701-.2248l-.4808-.2522-.4807-.2522a.1664.1664 0 0 1-.0701-.2247l.6311-1.2033a.1664.1664 0 0 1 .2247-.07l.4809.2522 1.2514.6565.7757.4069.001.0005.1465.0768-.663 1.2636-.0456.087v.0002l-.9405 1.7927-.0957.1823-.5355 1.0208-.0003.0007zm3.1515-6.0076-.1474-.0774-.7002-.3673-.5529-.29a.1665.1665 0 0 1-.0702-.2247l.6313-1.2032a.1665.1665 0 0 1 .2247-.0702l.5529.2901.7002.3674.001.0004.1465.077-.0774.1473-.3155.6016-.3156.6016-.0004.0006zm10.302-7.121c.4153.0008.74-.1664.9557-.5777.6575-1.2533-.5588-3.1869-2.7166-4.3188s-4.44-1.0336-5.0974.2197 1.1712 2.0762 3.329 3.2082c1.4498.7605 2.6792 1.467 3.5294 1.4687");
		builder.CloseElement();
		builder.CloseElement();
    }
}
