// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImTv : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M15.331 4.502c-1.388-0.199-2.865-0.344-4.407-0.425l2.576-2.576-1-1-3.509 3.509c-0.328-0.006-0.659-0.009-0.991-0.009v0l-4-4-1 1 3.034 3.034c-1.889 0.066-3.693 0.227-5.365 0.467-0.43 1.683-0.669 3.543-0.669 5.498s0.239 3.815 0.669 5.498c2.244 0.323 4.724 0.502 7.331 0.502s5.087-0.179 7.331-0.502c0.43-1.683 0.669-3.543 0.669-5.498s-0.239-3.815-0.669-5.498zM13.498 13.666c-1.683 0.215-3.543 0.334-5.498 0.334s-3.815-0.119-5.498-0.334c-0.323-1.122-0.502-2.362-0.502-3.666s0.179-2.543 0.502-3.666c1.683-0.215 3.543-0.334 5.498-0.334s3.815 0.119 5.498 0.334c0.323 1.122 0.502 2.362 0.502 3.666s-0.179 2.543-0.502 3.666z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
