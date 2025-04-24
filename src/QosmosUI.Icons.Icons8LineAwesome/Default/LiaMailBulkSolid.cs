// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaMailBulkSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 6 5 L 6 15 L 2 15 L 2 28 L 19 28 L 19 24 L 30 24 L 30 11 L 23 11 L 23 5 L 6 5 z M 8 7 L 21 7 L 21 11 L 12 11 L 12 15 L 8 15 L 8 7 z M 14 13 L 28 13 L 28 22 L 19 22 L 19 15 L 14 15 L 14 13 z M 23 15 L 23 17 L 26 17 L 26 15 L 23 15 z M 4 17 L 6 17 L 13 17 L 17 17 L 17 18.113281 L 10.960938 21.867188 C 10.681938 22.041188 10.319062 22.042188 10.039062 21.867188 L 4 18.115234 L 4 17 z M 17 20.46875 L 17 26 L 4 26 L 4 20.470703 L 8.9824219 23.566406 C 9.4504219 23.857406 9.976 24.003906 10.5 24.003906 C 11.024 24.003906 11.548625 23.857453 12.015625 23.564453 L 17 20.46875 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
