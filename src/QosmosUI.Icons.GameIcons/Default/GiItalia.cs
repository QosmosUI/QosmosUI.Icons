// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiItalia : ComponentBase
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
		builder.AddAttribute(14, "d", "M220.491 24.574L61.571 79.201c-28.927 37.65 13.728 85.182 29.301 94.36l51.152-23.838 89.891 111.244L362.03 332.48l20.362 52.145-16.885 34.268 18.375 11.918 32.775-68.534-22.227-16.243 11.301-38.386 52.643 32.778-1.49-29.301-93.178-49.84c4.616-.771 9.298-1.572 10.242-1.808 1.987-.497-1.49-12.416-1.49-12.416l-33.817 1.437-31.24-17.33-29.3-53.139-36.75-23.34-3.477-56.119 40.723-18.375-3.973-33.771zM129.837 287.16l-5.463 16.102-21.086.414 8.443 88.398 40.723-9.435 1.074-79.95-4.728-14.474zm233.185 128.256L257.74 426.342l-1.986 18.87 90.88 42.214 13.411-17.381-11.92-13.408z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
