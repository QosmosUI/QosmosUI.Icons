// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiDoctrine : ComponentBase
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
		builder.AddAttribute(14, "d", "M22.325 12.138c-0.005-0.004-0.009-0.008-0.009-0.008-0.051-0.064-0.107-0.124-0.163-0.18l-7.698-7.698c-0.919-0.919-2.408-0.919-3.328 0s-0.919 2.408 0 3.328l2.485 2.485c-4.161 1.056-7.236 4.829-7.236 9.323 0 5.316 4.307 9.623 9.623 9.623s9.623-4.307 9.623-9.623c-0-2.891-1.275-5.487-3.297-7.249zM22.129 20.811l-5.56 5.56c-0.334 0.333-0.774 0.5-1.21 0.5s-0.877-0.167-1.21-0.5c-0.667-0.667-0.667-1.753 0-2.421l2.639-2.639h-5.705c-0.945 0-1.711-0.766-1.711-1.711s0.766-1.711 1.711-1.711h5.705l-2.639-2.639c-0.667-0.667-0.667-1.753 0-2.421s1.754-0.667 2.421 0l5.56 5.56c0.667 0.667 0.667 1.753 0 2.421z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
