// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiInternetcomputer : ComponentBase
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
		builder.AddAttribute(15, "d", "M18.264 6.24c-2.52 0-5.376 3.024-6.264 3.984-.72-.792-3.696-3.984-6.264-3.984C2.568 6.24 0 8.832 0 12c0 3.168 2.568 5.76 5.736 5.76 2.52 0 5.376-3.024 6.264-3.984.72.792 3.696 3.984 6.264 3.984C21.432 17.76 24 15.168 24 12c0-3.168-2.568-5.76-5.736-5.76ZM5.736 15.384A3.38 3.38 0 0 1 2.352 12a3.395 3.395 0 0 1 3.384-3.384c1.176 0 3.24 1.8 4.68 3.384-.408.456-3.144 3.384-4.68 3.384zm12.528 0c-1.176 0-3.24-1.8-4.68-3.384.408-.456 3.168-3.384 4.68-3.384A3.38 3.38 0 0 1 21.648 12c-.024 1.872-1.536 3.384-3.384 3.384z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
