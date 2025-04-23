// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiEnterprisedb : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0A12 12 0 0 0 0 12a12 12 0 0 0 12 12 12 12 0 0 0 12-12A12 12 0 0 0 12 0zM6.44 7.75c.072 0 .148.004.222.012l1.815.18a.384.384 0 0 1 .345.369v6.636c0 .186-.154.32-.345.301l-1.815-.18C5.47 14.95 4.5 13.918 4.5 12.762c0-.62.279-1.15.72-1.49-.441-.428-.72-1.011-.72-1.631 0-1.084.85-1.892 1.94-1.89zm11.12 0c1.09 0 1.94.807 1.94 1.89 0 .62-.278 1.204-.72 1.631.442.34.72.87.72 1.49 0 1.157-.967 2.19-2.16 2.307l-1.817.18c-.191.02-.345-.116-.345-.3V8.31c0-.185.154-.35.345-.369l1.817-.18c.074-.007.148-.011.22-.011zm-7.374 2H12c1.194 0 2.16.93 2.16 2.074v3.09c0 1.145-.972 2.086-2.166 2.086H10.18a.343.343 0 0 1-.34-.344v-.092c0-.34.187-.331.27-.34l.136-.011c1.216-.13 1.735-.404 1.754-.766h-1.82c-.202 0-.34-.195-.34-.388v-4.977c0-.184.154-.332.346-.332z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
