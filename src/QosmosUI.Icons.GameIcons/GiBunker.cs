// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBunker : ComponentBase
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
		builder.AddAttribute(14, "d", "M59.18 34.76v39.65H457.03V34.76zm67.5 51.391v73.396h39.994l-.084-.042 9.853-6.86 3.569-21.466 9.66 7.119 21.807-3.285-3.883 11.261 6.767 13.274h173.635V86.15zm-42.87 1.62v176.01h32V87.77zm313.89 0v176.01h32V87.77zM275.706 98.397l-1.055 7.39 8.748 9.638-7.693 2.17-6.674 9.935-1.383 2.06-3.7-6.05-13.727-2.225 5.408-5.908-.428-13.37 7.043 2.4zM126.68 213.48v50.385h261.318V213.48zm186.41 4.4l16.308 8.05 9.284-3.086-2.358 17.553 6.08 7.808-17.765 2.797-5.528 7.914-8.623-15.824-9.494-2.918 2.135-2.16 10.3-10.418zM79.105 281.932l-.904 18.49H434.84l-.904-18.49zm-1.783 36.49l-7.76 158.818H443.48l-7.76-158.818z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
