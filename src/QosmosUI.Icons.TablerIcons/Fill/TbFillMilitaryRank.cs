// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillMilitaryRank : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.555 2.168l6 4a1 1 0 0 1 .445 .832v12a3 3 0 0 1 -3 3h-8a3 3 0 0 1 -3 -3v-12a1 1 0 0 1 .445 -.832l6 -4a1 1 0 0 1 1.11 0m-.108 12.938a1 1 0 0 0 -.894 0l-2 1a1 1 0 0 0 -.447 1.341l.058 .102a1 1 0 0 0 1.283 .345l1.553 -.776l1.553 .776a1 1 0 0 0 .894 -1.788zm0 -4a1 1 0 0 0 -.894 0l-2 1a1 1 0 0 0 -.447 1.341l.058 .102a1 1 0 0 0 1.283 .345l1.553 -.776l1.553 .776a1 1 0 0 0 .894 -1.788zm0 -4a1 1 0 0 0 -.894 0l-2 1a1 1 0 0 0 -.447 1.341l.058 .102a1 1 0 0 0 1.283 .345l1.553 -.776l1.553 .776a1 1 0 0 0 .894 -1.788z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
