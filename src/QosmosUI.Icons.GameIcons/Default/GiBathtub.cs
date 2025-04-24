// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBathtub : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M440.6 24.77c-.7 0-1.4 0-2.1.1-17.2 1.06-33.5 10.97-43.1 25.11 3.9 1.97 7.6 4.48 11.1 7.61 1.2 1.08 2.4 2.2 3.4 3.34 7.3-10.82 22.9-19.32 35.1-17.96 6.7.74 12.4 3.6 17.3 10.84 4.9 7.23 8.7 19.41 8.7 38.21V268h18V92c0-21.2-4.2-37.02-11.8-48.29-7.6-11.26-18.9-17.4-30.2-18.66-2.1-.23-4.3-.32-6.4-.28zm-69.4 37.17c-2.7 0-5.4.21-8.1.65-6.1 1.03-11.8 3.47-16.3 6.06l55.3 49.45c2.1-4.8 3.9-10.7 4.3-16.9.6-10.74-2.2-21.55-11.9-30.19-7.3-6.51-15.3-8.97-23.3-9.07zM16 289v18h480v-18zm9.29 36c1.42 56.1 15.91 97.6 42.75 126H444c12.8-14.5 24-39.8 31.3-65.5 6.5-22.6 10.1-45 11.2-60.5zm59.22 144l-12 18 14.98 10 18.71-28zm337.29 0l18.7 28 15-10-12-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
