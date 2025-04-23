// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Heroicons.Mini;

public class HiMiniEyeDropper : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 20 20";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M12.1 3.667a3.502 3.502 0 1 1 6.782 1.738 3.487 3.487 0 0 1-.907 1.57 3.495 3.495 0 0 1-1.617.919L16 7.99V10a.75.75 0 0 1-.22.53l-.25.25a.75.75 0 0 1-1.06 0l-.845-.844L7.22 16.34A2.25 2.25 0 0 1 5.629 17H5.12a.75.75 0 0 0-.53.22l-1.56 1.56a.75.75 0 0 1-1.061 0l-.75-.75a.75.75 0 0 1 0-1.06l1.56-1.561a.75.75 0 0 0 .22-.53v-.508c0-.596.237-1.169.659-1.59l6.405-6.406-.844-.845a.75.75 0 0 1 0-1.06l.25-.25A.75.75 0 0 1 10 4h2.01l.09-.333ZM4.72 13.84l6.405-6.405 1.44 1.439-6.406 6.405a.75.75 0 0 1-.53.22H5.12c-.258 0-.511.044-.75.129a2.25 2.25 0 0 0 .129-.75v-.508a.75.75 0 0 1 .22-.53Z");
		builder.AddAttribute(16, "clip-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
    }
}
