// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiNotist : ComponentBase
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
		builder.AddAttribute(15, "d", "M5.9327 3.8008c-1.099.11-2.288.4-3.038.74-1.069.499-1.259.869-.909 1.868.36 1.0401.19 2.3081-1.0001 7.5053-.878 3.876-1.027 4.686-.977 5.406.04.47.09.63.29.7901.22.179.33.189 1.688.129 3.408-.17 4.0571-.22 4.2671-.34.24-.13.25-.2.44-1.758.32-2.8681 1.788-7.1552 3.027-8.8942 1.0601-1.479 2.3591-2.128 3.0982-1.549.78.62.76 1.559-.13 4.147-.68 1.999-.79 2.428-.909 3.617-.15 1.4601.13 2.4891.96 3.4082.849.94 2.118 1.409 3.846 1.409 1.64 0 2.9681-.41 4.3771-1.339 1.29-.86 2.8281-2.608 3.0081-3.4281.1-.41-.07-.859-.35-.969-.41-.15-.65-.04-1.389.63-.859.78-1.249.949-2.008.889-1.0101-.08-1.4501-.66-1.4501-1.919 0-.899.09-1.349.65-3.3171.79-2.728.93-3.9671.58-5.0271-.57-1.768-2.978-2.538-5.6461-1.798-1.449.41-3.238 1.449-4.5971 2.688-.38.34-.68.59-.68.56 0-.02.07-.35.16-.72.34-1.499.2-2.248-.479-2.598-.39-.2-1.599-.26-2.8281-.13z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
