// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons.Default;

public class GoFileBadge : ComponentBase
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
		builder.AddAttribute(14, "d", "M4 2.5a.5.5 0 0 0-.5.5v18a.5.5 0 0 0 .5.5h6a.75.75 0 0 1 0 1.5H4a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h10.982a2 2 0 0 1 1.414.586l.064.064.01.008.31.312a.75.75 0 0 1-1.06 1.06l-.078-.078-.004-.003-.093-.093c-.003-.003 0 0 0 0l-.21-.21a.5.5 0 0 0-.353-.146H4Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M18 6.25a4.25 4.25 0 1 0 0 8.5 4.25 4.25 0 0 0 0-8.5Zm-5.75 4.25a5.75 5.75 0 1 1 11.5 0 5.75 5.75 0 0 1-11.5 0Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "m21.283 14.866 1.455 8a.75.75 0 0 1-1.002.836l-3.296-1.24a1.25 1.25 0 0 0-.88 0l-3.296 1.24a.75.75 0 0 1-1.002-.836l1.455-8 1.475.268-1.217 6.698 2.056-.774a2.75 2.75 0 0 1 1.938 0l2.056.774-1.217-6.698 1.475-.268Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
