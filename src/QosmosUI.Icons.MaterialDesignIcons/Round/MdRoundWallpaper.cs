// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWallpaper : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M4 5c0-.55.45-1 1-1h5c.55 0 1-.45 1-1s-.45-1-1-1H4c-1.1 0-2 .9-2 2v6c0 .55.45 1 1 1s1-.45 1-1V5zm5.61 8.49l-2.96 3.7c-.26.33-.03.81.39.81H17c.41 0 .65-.47.4-.8l-2-2.67c-.2-.27-.6-.27-.8 0l-1.63 2.18-2.58-3.22c-.2-.25-.58-.25-.78 0zM17 8.5c0-.83-.67-1.5-1.5-1.5S14 7.67 14 8.5s.67 1.5 1.5 1.5S17 9.33 17 8.5zM20 2h-6c-.55 0-1 .45-1 1s.45 1 1 1h5c.55 0 1 .45 1 1v5c0 .55.45 1 1 1s1-.45 1-1V4c0-1.1-.9-2-2-2zm0 17c0 .55-.45 1-1 1h-5c-.55 0-1 .45-1 1s.45 1 1 1h6c1.1 0 2-.9 2-2v-6c0-.55-.45-1-1-1s-1 .45-1 1v5zM3 13c-.55 0-1 .45-1 1v6c0 1.1.9 2 2 2h6c.55 0 1-.45 1-1s-.45-1-1-1H5c-.55 0-1-.45-1-1v-5c0-.55-.45-1-1-1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
