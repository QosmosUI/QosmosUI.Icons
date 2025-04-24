// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiBitwarden : ComponentBase
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
		builder.AddAttribute(15, "d", "M21.722.296A.964.964 0 0 0 21.018 0H2.982a.959.959 0 0 0-.703.296.96.96 0 0 0-.297.702v12c0 .895.174 1.783.523 2.665.349.88.783 1.66 1.3 2.345.517.68 1.132 1.346 1.848 1.993a21.807 21.807 0 0 0 1.98 1.609c.605.427 1.235.83 1.893 1.212.657.381 1.125.638 1.4.772.276.134.5.241.664.311a.916.916 0 0 0 .814 0c.168-.073.389-.177.667-.311.275-.134.743-.394 1.401-.772a25.305 25.305 0 0 0 1.894-1.212A21.891 21.891 0 0 0 18.348 20c.716-.647 1.33-1.31 1.847-1.993s.949-1.463 1.3-2.345c.35-.879.524-1.767.524-2.665V1.001a.95.95 0 0 0-.297-.705zm-2.325 12.815c0 4.344-7.397 8.087-7.397 8.087V2.57h7.397v10.54z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
