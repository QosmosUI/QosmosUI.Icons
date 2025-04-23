// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoDevices : ComponentBase
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
		builder.AddAttribute(14, "d", "M1 3.75C1 2.784 1.784 2 2.75 2h18.5c.966 0 1.75.784 1.75 1.75v4a.75.75 0 0 1-1.5 0v-4a.25.25 0 0 0-.25-.25H2.75a.25.25 0 0 0-.25.25v11.5c0 .138.112.25.25.25h9a.75.75 0 0 1 0 1.5h-1.287c-.126 1.266-.564 2.445-1.223 3.5h2.51a.75.75 0 0 1 0 1.5h-4a.75.75 0 0 1-.565-1.243c.964-1.105 1.598-2.382 1.769-3.757H2.75A1.75 1.75 0 0 1 1 15.25V3.75Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M14 11.75c0-.967.783-1.75 1.75-1.75h5.5c.966 0 1.75.783 1.75 1.75v8.5A1.75 1.75 0 0 1 21.25 22h-5.5A1.75 1.75 0 0 1 14 20.25Zm1.75-.25a.25.25 0 0 0-.25.25v8.5c0 .138.112.25.25.25h5.5a.25.25 0 0 0 .25-.25v-8.5a.25.25 0 0 0-.25-.25Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
