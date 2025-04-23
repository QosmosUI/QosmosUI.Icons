// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoDesktopDownload : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.25 9.331V.75a.75.75 0 0 1 1.5 0v8.58l1.949-2.11A.75.75 0 1 1 15.8 8.237l-3.25 3.52a.75.75 0 0 1-1.102 0l-3.25-3.52A.75.75 0 1 1 9.3 7.22l1.949 2.111Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M2.5 3.75v11.5c0 .138.112.25.25.25h18.5a.25.25 0 0 0 .25-.25V3.75a.25.25 0 0 0-.25-.25h-5.5a.75.75 0 0 1 0-1.5h5.5c.966 0 1.75.784 1.75 1.75v11.5A1.75 1.75 0 0 1 21.25 17h-6.204c.171 1.375.805 2.652 1.769 3.757A.752.752 0 0 1 16.25 22h-8.5a.75.75 0 0 1-.566-1.243c.965-1.105 1.599-2.382 1.77-3.757H2.75A1.75 1.75 0 0 1 1 15.25V3.75C1 2.784 1.784 2 2.75 2h5.5a.75.75 0 0 1 0 1.5h-5.5a.25.25 0 0 0-.25.25ZM10.463 17c-.126 1.266-.564 2.445-1.223 3.5h5.52c-.66-1.055-1.098-2.234-1.223-3.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
