// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Solid;

public class BiSolidBxsPlanet : ComponentBase
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
		builder.AddAttribute(14, "d", "M15.165 15.582c4.587-4.073 8.141-9.424 6.057-11.771-.661-.744-1.584-1.089-2.575-.983-.832.091-1.687.502-2.549 1.192a8.922 8.922 0 0 0-8.712.282 8.917 8.917 0 0 0-4.109 5.515 8.892 8.892 0 0 0 .306 5.325c-1.065 1.203-2.054 3.677-.823 5.063.517.581 1.257.841 2.147.841 2.707 0 6.808-2.399 10.258-5.464zm3.699-10.767c.358-.034.632.064.861.323.231.261.169.946-.252 1.929a9.059 9.059 0 0 0-1.617-1.853c.431-.262.776-.373 1.008-.399zM4.633 17.118a8.979 8.979 0 0 0 1.568 1.737c-1.025.303-1.714.283-1.945.021-.217-.243.002-1.069.377-1.758zm16.31-5.869c-1.215 1.797-2.906 3.671-4.778 5.333-1.934 1.719-4.066 3.208-6.05 4.202a9.082 9.082 0 0 0 1.874.212 8.986 8.986 0 0 0 4.616-1.282 8.915 8.915 0 0 0 4.338-8.465z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
