// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiGitBranch : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
		builder.AddAttribute(14, "d", "M21.5 7.119c-2.023 0-3.667 1.643-3.667 3.667 0 1.353 0.741 2.523 1.833 3.159v0.508c0 0 0 3.667-3.667 3.667-1.52 0-2.711 0.326-3.667 0.825v-8.666c1.093-0.636 1.833-1.806 1.833-3.159 0-2.024-1.643-3.667-3.667-3.667s-3.667 1.643-3.667 3.667c0 1.353 0.74 2.523 1.833 3.159v12.016c-1.093 0.636-1.833 1.805-1.833 3.158 0 2.023 1.643 3.667 3.667 3.667s3.667-1.644 3.667-3.667c0-0.96-0.378-1.826-0.981-2.482 0.534-0.655 1.401-1.185 2.815-1.185 7.276 0 7.333-7.333 7.333-7.333v-0.508c1.092-0.636 1.833-1.806 1.833-3.159 0-2.024-1.644-3.667-3.667-3.667zM10.5 5.286c1.014 0 1.833 0.819 1.833 1.833s-0.819 1.833-1.833 1.833c-1.014 0-1.833-0.819-1.833-1.833s0.819-1.833 1.833-1.833zM10.5 27.286c-1.014 0-1.833-0.82-1.833-1.833 0-1.012 0.819-1.833 1.833-1.833s1.833 0.822 1.833 1.833c0 1.013-0.819 1.833-1.833 1.833zM21.5 12.619c-1.013 0-1.833-0.819-1.833-1.833s0.82-1.833 1.833-1.833 1.833 0.819 1.833 1.833c0 1.014-0.82 1.833-1.833 1.833z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
