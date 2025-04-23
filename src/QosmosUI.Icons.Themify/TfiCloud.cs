// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiCloud : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12.75 4.5c-0.578 0-1.146 0.123-1.691 0.367-0.889-0.873-2.075-1.367-3.309-1.367-1.966 0-3.684 1.19-4.397 3.002-1.803-0.074-3.353 1.421-3.353 3.248 0 1.792 1.458 3.25 3.25 3.25h9.5c2.343 0 4.25-1.907 4.25-4.25s-1.907-4.25-4.25-4.25zM12.75 12h-9.5c-1.241 0-2.25-1.009-2.25-2.25s1.009-2.25 2.25-2.25c0.125 0 0.244 0.019 0.363 0.038l0.435 0.072 0.126-0.422c0.478-1.608 1.915-2.688 3.576-2.688 1.073 0 2.102 0.477 2.821 1.307l0.265 0.306 0.354-0.195c0.503-0.277 1.027-0.418 1.56-0.418 1.792 0 3.25 1.458 3.25 3.25s-1.458 3.25-3.25 3.25z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
