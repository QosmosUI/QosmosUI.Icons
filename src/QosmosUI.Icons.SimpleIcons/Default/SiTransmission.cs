// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiTransmission : ComponentBase
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
		builder.AddAttribute(15, "d", "M1.6956 9.46V22.254c0 .945.8847 1.709 1.7157 1.709h17.1573c.878 0 1.7157-.6098 1.7157-1.709V9.4666c-2.3323.3753-4.6177.6233-6.863.7708v5.1471h3.4315l-6.8629 6.863-6.8628-6.863h3.4314v-5.0868c-2.339-.1207-4.6244-.3887-6.8428-.831h-.02v-.0068zM15.4214.0368v8.4177c2.2452-.1474 4.5306-.1675 6.8629-.5428C23.2226 7.7643 24 7.1008 24 6.0888v-3.8c0-1.012-.7841-1.6622-1.7157-1.8297-2.339-.429-4.6177-.2949-6.863-.4222zM8.5585.0503C6.2396.191 3.9609.077 1.7157.459.7774.6199 0 1.2767 0 2.2887v3.8001c0 1.012.7841 1.642 1.7157 1.823 2.2184.4423 4.5038.4758 6.8428.6031V.0503z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
