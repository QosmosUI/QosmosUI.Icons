// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrUserSettings : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M18.0003,20.9998 C16.3453,20.9998 15.0003,19.6538 15.0003,17.9998 C15.0003,16.3458 16.3453,14.9998 18.0003,14.9998 C19.6543,14.9998 21.0003,16.3458 21.0003,17.9998 C21.0003,19.6538 19.6543,20.9998 18.0003,20.9998 L18.0003,20.9998 Z M24.0003,17.9998 L21.0003,17.9998 L24.0003,17.9998 Z M20.1213,20.1218 L22.2423,22.2428 L20.1213,20.1218 Z M18.0003,23.9998 L18.0003,20.9998 L18.0003,23.9998 Z M13.7573,22.2428 L15.8783,20.1208 L13.7573,22.2428 Z M12.0003,17.9998 L15.0003,17.9998 L12.0003,17.9998 Z M15.8783,15.8788 L13.7573,13.7578 L15.8783,15.8788 Z M18.0003,14.9998 L18.0003,11.9998 L18.0003,14.9998 Z M20.1213,15.8788 L22.2423,13.7578 L20.1213,15.8788 Z M12.5,12.5 C11.2660678,11.4458897 9.77508483,11 8,11 C4.13400675,11 1,13.0294373 1,18 L1,23 L11,23 M8,11 C10.7614237,11 13,8.76142375 13,6 C13,3.23857625 10.7614237,1 8,1 C5.23857625,1 3,3.23857625 3,6 C3,8.76142375 5.23857625,11 8,11 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
