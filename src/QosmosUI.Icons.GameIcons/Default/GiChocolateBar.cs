// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiChocolateBar : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M296.385 64.965s-17.449 15.537-26.69 12.29c-3.338-1.172-6.104-4.45-8.353-8.49L244.398 85.71l84.582 84.584 60.258-60.258-14.955-14.955c-3.33 1.341-6.57 2.1-9.422 1.842-10.105-.913-23.527-19.315-23.527-19.315S325.559 92.59 316.4 90.602c-10.594-2.3-20.015-25.637-20.015-25.637zm-64.713 33.47l-60.254 60.256L256 243.273l60.254-60.253zm170.293 24.327l-60.258 60.258 84.584 84.582 60.256-60.256zM158.69 171.418l-44.802 44.803 100.488 68.675L243.273 256zm170.29 24.328L268.726 256l84.582 84.582 60.255-60.254zM78.491 213.828L48.848 278.02l85.732.11 48.123 93.856 72.02-17.418 49.988 79.266 29.115-45.504zM256 268.727l-26.504 26.503 100.488 68.676 10.598-10.597zM34.107 296l-8.654 8.654 181.893 181.893 67.047-67.047-28-44.4-73.239 17.712-49.58-96.697L34.777 296z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
