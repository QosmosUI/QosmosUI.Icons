// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiMagic : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0a29.658 29.658 0 0 1-3.611 3.53A27.326 27.326 0 0 1 9.729 12c0 2.948-.47 5.792-1.34 8.47A29.658 29.658 0 0 1 12 24a29.658 29.658 0 0 1 3.611-3.53 27.326 27.326 0 0 1-1.34-8.47c0-2.948.47-5.792 1.34-8.47A29.658 29.658 0 0 1 12 0Zm6.109 5.381A27.362 27.362 0 0 0 17.3 12c0 2.278.28 4.494.809 6.619a30.696 30.696 0 0 1 4.391-2.424A13.662 13.662 0 0 1 21.843 12c0-1.46.23-2.868.657-4.195a30.698 30.698 0 0 1-4.391-2.424Zm-12.218 0A30.7 30.7 0 0 1 1.5 7.805c.427 1.327.657 2.736.657 4.195 0 1.46-.23 2.868-.657 4.195a30.696 30.696 0 0 1 4.391 2.424C6.42 16.494 6.7 14.278 6.7 12c0-2.278-.28-4.494-.809-6.619z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
