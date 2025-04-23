// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiStaffbase : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.847 20.095a7.805 7.805 0 01-6.286-3.238l1.714-1.238C8.323 17.048 10.037 18 11.847 18s3.523-.857 4.571-2.381l1.714 1.238a7.805 7.805 0 01-6.285 3.238zm.19-18c1.62 0 3.238.476 4.762 1.334l1.048.476 2.857-.572-.477 2.857c2.381 3.715 2.191 9.239-1.047 12.667a9.748 9.748 0 01-7.048 3.048 9.98 9.98 0 01-6.857-2.762c-3.905-3.81-4-10-.286-13.905 1.905-2.095 4.477-3.143 7.048-3.143m0-2.095C8.799 0 5.751 1.333 3.466 3.714c-4.572 4.762-4.477 12.381.285 16.953A11.91 11.91 0 0012.037 24c3.238 0 6.381-1.333 8.571-3.619 3.62-3.714 4.286-9.81 1.81-14.571l.38-2.096.477-2.952-2.952.571-2.19.381-.382-.19C15.941.476 14.037 0 12.037 0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
