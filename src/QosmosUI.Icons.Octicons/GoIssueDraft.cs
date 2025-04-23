// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoIssueDraft : ComponentBase
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
		builder.AddAttribute(14, "d", "M17.32 3.205a.75.75 0 0 1 1.046-.177 11.056 11.056 0 0 1 2.605 2.606.75.75 0 1 1-1.222.869 9.554 9.554 0 0 0-2.252-2.252.75.75 0 0 1-.177-1.046Zm3.475 14.115a.75.75 0 0 1 .176 1.046 11.07 11.07 0 0 1-2.605 2.605.75.75 0 1 1-.869-1.222 9.554 9.554 0 0 0 2.252-2.252.75.75 0 0 1 1.046-.177ZM2.018 9.543a.75.75 0 0 1 .615.864 9.571 9.571 0 0 0 0 3.186.75.75 0 1 1-1.48.25 11.07 11.07 0 0 1 0-3.686.75.75 0 0 1 .865-.614Zm7.525 12.439a.75.75 0 0 1 .864-.615 9.571 9.571 0 0 0 3.186 0 .75.75 0 1 1 .25 1.48 11.07 11.07 0 0 1-3.686 0 .75.75 0 0 1-.614-.865ZM6.68 3.205a.75.75 0 0 1-.177 1.046A9.558 9.558 0 0 0 4.25 6.503a.75.75 0 1 1-1.223-.87 11.056 11.056 0 0 1 2.606-2.605.75.75 0 0 1 1.046.177ZM3.205 17.32a.75.75 0 0 1 1.046.177 9.554 9.554 0 0 0 2.252 2.252.75.75 0 1 1-.87 1.223 11.056 11.056 0 0 1-2.605-2.606.75.75 0 0 1 .177-1.046Zm6.952-16.166a11.07 11.07 0 0 1 3.686 0 .75.75 0 0 1-.25 1.479 9.571 9.571 0 0 0-3.186 0 .75.75 0 1 1-.25-1.48Zm11.825 8.389a.75.75 0 0 1 .864.614 11.07 11.07 0 0 1 0 3.686.75.75 0 0 1-1.479-.25 9.571 9.571 0 0 0 0-3.186.75.75 0 0 1 .615-.864Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
