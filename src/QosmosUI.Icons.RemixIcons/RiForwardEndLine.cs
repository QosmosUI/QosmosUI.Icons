// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiForwardEndLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M22 4C21.4477 4 21 4.44772 21 5V10.6665L11.7774 4.51806C11.6952 4.4633 11.5987 4.43408 11.5 4.43408C11.2239 4.43408 11 4.65794 11 4.93408V10.6665L1.77735 4.51806C1.69522 4.4633 1.59871 4.43408 1.5 4.43408C1.22386 4.43408 1 4.65794 1 4.93408V19.0656C1 19.1643 1.02922 19.2608 1.08397 19.3429C1.23715 19.5727 1.54759 19.6348 1.77735 19.4816L11 13.3332V19.0656C11 19.1643 11.0292 19.2608 11.084 19.3429C11.2372 19.5727 11.5476 19.6348 11.7774 19.4816L21 13.3332V19C21 19.5523 21.4477 20 22 20C22.5523 20 23 19.5523 23 19V5C23 4.44772 22.5523 4 22 4ZM3 7.73686L9.39445 11.9998L3 16.2628V7.73686ZM13 16.2628V7.73686L19.3944 11.9998L13 16.2628Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
