// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillLifebuoy : ComponentBase
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
		builder.AddAttribute(14, "d", "M14.757 16.172l3.571 3.571a10.004 10.004 0 0 1 -12.656 0l3.57 -3.571a5 5 0 0 0 2.758 .828c1.02 0 1.967 -.305 2.757 -.828m-10.5 -10.5l3.571 3.57a5 5 0 0 0 -.828 2.758c0 1.02 .305 1.967 .828 2.757l-3.57 3.572a10 10 0 0 1 -2.258 -6.329l.005 -.324a10 10 0 0 1 2.252 -6.005m17.743 6.329c0 2.343 -.82 4.57 -2.257 6.328l-3.571 -3.57a5 5 0 0 0 .828 -2.758c0 -1.02 -.305 -1.967 -.828 -2.757l3.571 -3.57a10 10 0 0 1 2.257 6.327m-5 -8.66q .707 .41 1.33 .918l-3.573 3.57a5 5 0 0 0 -2.757 -.828c-1.02 0 -1.967 .305 -2.757 .828l-3.573 -3.57a10 10 0 0 1 11.33 -.918");
		builder.CloseElement();
		builder.CloseElement();
    }
}
