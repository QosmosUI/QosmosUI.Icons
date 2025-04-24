// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiKnowledgebase : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.1 5.52V1.5h-.18c-3.36.15-6.15 2.31-7.83 4.02l-.09.09-.09-.09C10.2 3.81 7.44 1.65 4.08 1.5H3.9v4.02H0v6.93c0 1.68.06 3.36.18 4.74a5.57 5.57 0 005.19 5.1c2.13.12 4.38.21 6.63.21s4.5-.09 6.63-.24a5.57 5.57 0 005.19-5.1c.12-1.38.18-3.06.18-4.74v-6.9zm0 6.93c0 1.59-.06 3.15-.18 4.41-.09.81-.75 1.47-1.56 1.5a90 90 0 01-12.72 0c-.81-.03-1.5-.69-1.56-1.5-.12-1.26-.18-2.85-.18-4.41V5.52c2.82.12 5.64 3.15 6.48 4.32L12 12.09l1.62-2.25c.84-1.2 3.66-4.2 6.48-4.32z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
