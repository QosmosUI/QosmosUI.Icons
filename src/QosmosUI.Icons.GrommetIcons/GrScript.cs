// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrScript : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M4 1C1.79086 1 0 2.79086 0 5V6H1H5.84699L4.01005 18.8586L4 18.9289V19C4 21.2091 5.79086 23 8 23H20C22.2091 23 24 21.2091 24 19V18H23H18.153L19.99 5.14142L20 5.07107V5C20 2.79086 18.2091 1 16 1H4ZM4 3C3.25972 3 2.61337 3.4022 2.26756 4H5.73244C5.38663 3.4022 4.74028 3 4 3ZM7.46487 3H16C17.0831 3 17.9652 3.86103 17.999 4.93597L16.1327 18H11H10V19C10 20.1046 9.10457 21 8 21C6.91685 21 6.03481 20.139 6.00101 19.064L7.98995 5.14142L8 5.07107V5C8 4.27143 7.80521 3.58835 7.46487 3ZM20 21H11.4649C11.6439 20.6905 11.7827 20.3548 11.874 20H21.7324C21.3866 20.5978 20.7403 21 20 21Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
