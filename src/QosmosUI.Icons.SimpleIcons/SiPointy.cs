// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiPointy : ComponentBase
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
		builder.AddAttribute(15, "d", "M8.076.025S4.52.234 2.833 2.751c-1.58 2.351-1.465 5.145-1.1 8.121C2.096 13.831 2.587 24 2.587 24c.002.003 11.235-11.526 11.23-11.506 1.75-1.805 2.408-4.468 2.395-5.961-.037-4.274-3.461-6.815-8.136-6.508zm.777 10.774c-1.991 0-3.604-1.632-3.604-3.645 0-2.015 1.614-3.649 3.604-3.649s3.642 1.512 3.642 3.527c0 2.011-1.652 3.767-3.642 3.767zm2.765-3.741a1.58 1.58 0 1 1-3.162 0 1.58 1.58 0 0 1 3.162 0zm10.879 1.431s-2.325.158-3.644.57c-1.317.413-2.502 1.076-2.502 1.076s.495-.852.705-2.361c.207-1.511-.14-2.652-.14-2.652l5.581 3.367Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
