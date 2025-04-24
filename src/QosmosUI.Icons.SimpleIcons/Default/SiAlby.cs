// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiAlby : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.08 9.322c-3.77 0-6.96 2.33-8.05 5.57-.36 1.04.25 2.13 1.27 2.55 2.15.87 4.46 1.32 6.78 1.32s4.62-.45 6.78-1.32c1.02-.42 1.63-1.51 1.27-2.55-1.09-3.24-4.29-5.57-8.05-5.57zm-2.92 6.61c-1.09 0-1.97-.7-1.97-1.57s.89-1.57 1.97-1.57 1.97.7 1.97 1.57-.88 1.57-1.97 1.57zm5.63 0c-1.08 0-1.96-.7-1.96-1.57s.87-1.57 1.96-1.57 1.97.7 1.97 1.57-.88 1.57-1.97 1.57zm4.79-8.14.91-.91c.75.42 1.67.4 2.4-.06 1.11-.69 1.44-2.14.75-3.25a2.355 2.355 0 0 0-3.25-.75 2.358 2.358 0 0 0-.76 3.25l-.92.92c-1.87-1.53-4.15-2.44-6.63-2.44s-4.81.93-6.7 2.5l-1-1c.45-.74.46-1.66.03-2.41a2.357 2.357 0 0 0-3.22-.87 2.36 2.36 0 0 0-.88 3.22 2.37 2.37 0 0 0 3.23.88l.98.98c-1.93 1.94-3.3 4.61-3.83 7.6-.28 1.66.57 3.29 2.09 3.99 2.92 1.39 6.11 2.11 9.34 2.1 3.2 0 6.36-.7 9.25-2.06a3.695 3.695 0 0 0 2.16-3.37c0-.2-.01-.41-.05-.62-.54-3.04-1.93-5.75-3.9-7.7zm1.29 10.63a20.394 20.394 0 0 1-8.75 1.95c-3.06.01-6.08-.67-8.83-1.99a2.504 2.504 0 0 1-1.44-2.7c1.03-5.76 5.28-9.94 10.23-9.94s9.22 4.2 10.24 9.97c.19 1.12-.4 2.22-1.45 2.71z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
