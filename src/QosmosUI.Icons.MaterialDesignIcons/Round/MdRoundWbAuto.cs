// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWbAuto : ComponentBase
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
		builder.AddAttribute(17, "d", "M6.85 12.65h2.3L8 9zM22.72 7c-.42 0-.77.3-.85.7l-1.07 5.59-1.31-5.51c-.11-.46-.52-.78-.99-.78s-.88.32-.98.78l-1.31 5.51-1.07-5.59c-.08-.4-.44-.7-.85-.7-.01 0-.03.01-.04.01C12.78 5.18 10.53 4 8 4c-4.42 0-8 3.58-8 8s3.58 8 8 8c3.17 0 5.9-1.85 7.2-4.52.2.32.55.52.94.52.51 0 .95-.35 1.07-.84L18.5 9.9l1.29 5.26c.12.49.57.84 1.07.84.52 0 .96-.36 1.08-.86l1.61-7.08c.13-.54-.28-1.06-.83-1.06zm-11.79 9c-.38 0-.72-.24-.84-.6L9.6 14H6.4l-.49 1.4c-.13.36-.46.6-.84.6-.62 0-1.05-.61-.84-1.19l2.44-6.86C6.87 7.38 7.4 7 8 7s1.13.38 1.34.94l2.44 6.86c.2.59-.23 1.2-.85 1.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
