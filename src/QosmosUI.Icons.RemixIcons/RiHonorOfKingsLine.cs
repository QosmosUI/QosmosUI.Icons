// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiHonorOfKingsLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M18.3292 4.25604L16.9062 5.67921C13.7678 3.23734 9.22861 3.45865 6.34412 6.34315C3.97034 8.71692 3.40017 12.2113 4.63361 15.1234L7.0508 12.7061C6.83751 11.2027 7.30906 9.62085 8.46544 8.46447C10.1757 6.75423 12.8166 6.54193 14.7579 7.82757L13.2937 9.2919C12.1787 8.75967 10.8031 8.95526 9.87966 9.87868C8.95624 10.8021 8.76065 12.1777 9.29288 13.2927L2.8428 19.7424C2.80859 16.2426 2.25158 14.931 2.05494 13.0406C1.75392 10.1467 2.71224 7.1466 4.92991 4.92893C8.59624 1.2626 14.4012 1.03831 18.3292 4.25604ZM21.1592 4.25759C21.1934 7.75736 21.7504 9.06895 21.947 10.9594C22.248 13.8533 21.2897 16.8534 19.072 19.0711C15.4057 22.7374 9.60078 22.9617 5.67278 19.744L7.09575 18.3208C10.2342 20.7627 14.7733 20.5413 17.6578 17.6569C20.0316 15.2831 20.6018 11.7887 19.3683 8.87656L16.9512 11.2939C17.1644 12.7973 16.6929 14.3792 15.5365 15.5355C13.8263 17.2458 11.1853 17.4581 9.24404 16.1724L10.7083 14.7081C11.8233 15.2403 13.1989 15.0447 14.1223 14.1213C15.0457 13.1979 15.2413 11.8223 14.7091 10.7073L21.1592 4.25759Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
