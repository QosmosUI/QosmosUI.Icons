// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiCoinLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.0049 4.00281C18.08 4.00281 23.0049 6.6891 23.0049 10.0028V14.0028C23.0049 17.3165 18.08 20.0028 12.0049 20.0028C6.03824 20.0028 1.18114 17.4116 1.00957 14.1797L1.00488 14.0028V10.0028C1.00488 6.6891 5.92975 4.00281 12.0049 4.00281ZM12.0049 16.0028C8.28443 16.0028 4.99537 14.9953 3.00466 13.4533L3.00488 14.0028C3.00488 15.885 6.88751 18.0028 12.0049 18.0028C17.0156 18.0028 20.8426 15.9723 20.9999 14.1207L21.0049 14.0028L21.0061 13.4525C19.0155 14.995 15.726 16.0028 12.0049 16.0028ZM12.0049 6.00281C6.88751 6.00281 3.00488 8.12061 3.00488 10.0028C3.00488 11.885 6.88751 14.0028 12.0049 14.0028C17.1223 14.0028 21.0049 11.885 21.0049 10.0028C21.0049 8.12061 17.1223 6.00281 12.0049 6.00281Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
