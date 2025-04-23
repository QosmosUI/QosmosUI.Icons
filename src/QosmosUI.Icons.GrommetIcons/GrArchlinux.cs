// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrArchlinux : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M11.995499,0 C10.9272763,2.61898783 10.2829772,4.33212022 9.09364861,6.87325951 C9.82285899,7.64621596 10.7179267,8.54636058 12.1714997,9.56299285 C10.6087581,8.91993273 9.54277553,8.27431817 8.74615646,7.60436135 C7.22404876,10.7804724 4.83934636,15.3047005 0,24 C3.8035621,21.8041428 6.75200705,20.4503725 9.49981901,19.9338097 C9.38183641,19.4263273 9.31474077,18.8773854 9.31929729,18.3046251 L9.32381903,18.1827747 C9.38418076,15.7459387 10.6518189,13.8720119 12.1534614,13.9992474 C13.6551031,14.1264836 14.8223099,16.2062608 14.7619552,18.6430989 C14.7506091,19.1016345 14.6988943,19.5427398 14.6085152,19.9518612 C17.3264906,20.483546 20.2434156,21.8338506 23.9955134,24 C23.2556658,22.6379048 22.5952972,21.4100753 21.9646676,20.2406911 C20.9713321,19.4707837 19.9352208,18.4687462 17.8217601,17.3839783 C19.2744348,17.7614433 20.3145182,18.1969375 21.1252451,18.6837145 C14.7134752,6.74608943 14.1942543,5.15982659 11.995499,0 L11.995499,0 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
