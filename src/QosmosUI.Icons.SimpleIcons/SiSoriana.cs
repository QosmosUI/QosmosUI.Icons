// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiSoriana : ComponentBase
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
		builder.AddAttribute(15, "d", "M18.994 3.2c-1.16 0-2.772.494-3.94 2.104-.223.314-.39.664-.494 1.034a4.27 4.27 0 0 0 .678 3.692c.6.812 1.368 1.42 2.044 1.96.332.26 1.034.926 1.26 1.208.34.422.596.674.902 1.606.186.564.212 1.308.12 1.73C21.684 14.384 24 11.594 24 8.56c0-3.486-2.498-5.36-5.006-5.36M15.05 14.986c-.886-1.204-1.908-1.936-2.754-2.706-.368-.336-.772-.584-1.07-.88-1.434-1.424-2.102-3.18-1.764-5.34.268-1.692 1.108-2.806 2.124-3.622a7.098 7.098 0 0 0-4.278-1.372C3.274 1.066-.1 4.31.002 8.306c.184 7.22 9.224 13.37 12.948 14.628 1.992-1.02 3.05-2.928 3.05-4.884 0-1.426-.612-2.6-.95-3.064");
		builder.CloseElement();
		builder.CloseElement();
    }
}
