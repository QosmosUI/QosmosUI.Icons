// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImGit : ComponentBase
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
		builder.AddAttribute(14, "d", "M15.698 7.287l-6.986-6.986c-0.402-0.402-1.055-0.402-1.457 0l-1.623 1.623 1.221 1.221c0.196-0.094 0.415-0.146 0.647-0.146 0.828 0 1.5 0.672 1.5 1.5 0 0.232-0.053 0.451-0.146 0.647l2 2c0.196-0.094 0.415-0.146 0.647-0.146 0.828 0 1.5 0.672 1.5 1.5s-0.672 1.5-1.5 1.5-1.5-0.672-1.5-1.5c0-0.232 0.053-0.451 0.146-0.647l-2-2c-0.048 0.023-0.097 0.043-0.147 0.061v4.171c0.583 0.206 1 0.761 1 1.414 0 0.828-0.672 1.5-1.5 1.5s-1.5-0.672-1.5-1.5c0-0.653 0.417-1.208 1-1.414v-4.171c-0.583-0.206-1-0.761-1-1.414 0-0.232 0.053-0.451 0.146-0.647l-1.221-1.221-4.623 4.623c-0.402 0.403-0.402 1.055 0 1.458l6.986 6.986c0.402 0.402 1.054 0.402 1.457 0l6.953-6.953c0.402-0.403 0.402-1.055-0-1.458z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
