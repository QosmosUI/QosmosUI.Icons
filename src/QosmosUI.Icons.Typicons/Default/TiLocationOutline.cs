// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiLocationOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M12 5c1.609 0 3.12.614 4.254 1.73 1.126 1.107 1.746 2.579 1.746 4.14s-.62 3.03-1.745 4.139l-4.255 4.184-4.254-4.186c-1.125-1.107-1.745-2.576-1.745-4.139s.62-3.032 1.745-4.141c1.135-1.113 2.647-1.727 4.254-1.727m0-2c-2.047 0-4.096.768-5.657 2.305-3.124 3.074-3.124 8.057 0 11.131l5.657 5.563 5.657-5.565c3.124-3.072 3.124-8.056 0-11.129-1.561-1.537-3.609-2.305-5.657-2.305zM12 8.499c.668 0 1.296.26 1.768.731.976.976.976 2.562 0 3.537-.473.472-1.1.731-1.768.731s-1.295-.26-1.768-.731c-.976-.976-.976-2.562 0-3.537.473-.471 1.101-.731 1.768-.731m0-1c-.896 0-1.792.342-2.475 1.024-1.367 1.367-1.367 3.584 0 4.951.684.684 1.578 1.024 2.475 1.024s1.792-.342 2.475-1.024c1.366-1.367 1.366-3.584 0-4.951-.683-.683-1.579-1.024-2.475-1.024z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
