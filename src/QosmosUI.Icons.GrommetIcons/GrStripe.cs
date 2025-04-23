// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrStripe : ComponentBase
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
		builder.AddAttribute(15, "d", "M1,1 L23,1 L23,23 L1,23 L1,1 Z M11.1196337,9.18908425 C11.1196337,8.58622711 11.6142857,8.35435897 12.4335531,8.35435897 C13.6083516,8.35435897 15.0923077,8.70989011 16.2671062,9.343663 L16.2671062,5.71106227 C14.9841026,5.20095238 13.7165568,5 12.4335531,5 C9.2956044,5 7.20879121,6.6385348 7.20879121,9.37457875 C7.20879121,13.6409524 13.0827839,12.9608059 13.0827839,14.800293 C13.0827839,15.5113553 12.4644689,15.7432234 11.5988278,15.7432234 C10.3158242,15.7432234 8.67728938,15.2176557 7.37882784,14.5065934 L7.37882784,18.1855678 C8.81641026,18.8038828 10.2694505,19.0666667 11.5988278,19.0666667 C14.8140659,19.0666667 17.0245421,17.4745055 17.0245421,14.7075458 C17.0090842,10.1010989 11.1196337,10.9203663 11.1196337,9.18908425 L11.1196337,9.18908425 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
