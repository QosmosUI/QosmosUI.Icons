// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiHearthisdotat : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.485 3.515C15.799-1.17 8.2-1.17 3.515 3.515c-4.687 4.686-4.687 12.285 0 16.97 4.685 4.686 12.284 4.686 16.97 0 4.687-4.685 4.687-12.284 0-16.97zm-5.81 14.433c-.252.252-1.25.562-1.25-.012 0-.573-.157-3.089-2.028-4.958-1.88-1.88-4.55-2.192-5.056-2.192-.506 0-.331-1-.078-1.252.253-.253.558-.15 1.064-.15 0 0 3.445.464 5.326 2.345 1.868 1.869 2.173 5.153 2.173 5.153 0 .463.102.813-.15 1.066zm4.022-.509c-.36.36-1.786.803-1.786-.015 0-.82-.224-4.41-2.893-7.079C11.335 7.662 7.524 7.217 6.8 7.217c-.723 0-.473-1.426-.113-1.787.361-.36.799-.214 1.52-.214 0 0 4.918.663 7.603 3.348 2.666 2.667 3.1 7.356 3.1 7.356 0 .658.147 1.158-.214 1.52z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
