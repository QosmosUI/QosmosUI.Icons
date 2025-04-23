// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BootstrapIcons;

public class BsFiletypeJava : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(15, "d", "M14 4.5V11h-1V4.5h-2A1.5 1.5 0 0 1 9.5 3V1H4a1 1 0 0 0-1 1v9H2V2a2 2 0 0 1 2-2h5.5zM1.521 15.175a1.3 1.3 0 0 1-.082-.466h.765a.6.6 0 0 0 .073.27.5.5 0 0 0 .454.246q.285 0 .422-.164.138-.165.138-.466V11.85h.79v2.725q0 .66-.357 1.005-.354.345-.984.345a1.6 1.6 0 0 1-.568-.094 1.1 1.1 0 0 1-.408-.266 1.1 1.1 0 0 1-.243-.39m3.972-.354-.314 1.028h-.8l1.342-3.999h.926l1.336 3.999h-.84l-.314-1.028zm1.178-.59-.49-1.616h-.035l-.49 1.617zm2.342 1.618h.952l1.327-3.999h-.878l-.888 3.138h-.038L8.59 11.85h-.917zm3.087-1.028-.314 1.028h-.8l1.342-3.999h.926l1.336 3.999h-.84l-.314-1.028zm1.178-.59-.49-1.616h-.035l-.49 1.617z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
