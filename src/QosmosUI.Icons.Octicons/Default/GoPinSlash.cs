// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons.Default;

public class GoPinSlash : ComponentBase
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
		builder.AddAttribute(14, "d", "M2.345 20.595 8.47 14.47q.219-.22.53-.22.311 0 .53.22.22.219.22.53 0 .311-.22.53l-6.125 6.125q-.219.22-.53.22-.311 0-.53-.22-.22-.219-.22-.53 0-.311.22-.53Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "m16.72 11.97.358-.358a6.738 6.738 0 0 1 2.326-1.518l1.896-.738a.25.25 0 0 0 .086-.409l-6.333-6.333a.25.25 0 0 0-.409.086l-.521 1.34a8.663 8.663 0 0 1-2.243 3.265.75.75 0 0 1-1.01-1.11 7.132 7.132 0 0 0 1.854-2.699l.521-1.34a1.75 1.75 0 0 1 2.869-.603l6.333 6.333a1.75 1.75 0 0 1-.603 2.869l-1.896.737a5.26 5.26 0 0 0-1.81 1.18l-.358.358a.749.749 0 1 1-1.06-1.06Zm-12.549-.738a1.75 1.75 0 0 1 .757-2.92l3.366-.962.412 1.443-3.366.961a.25.25 0 0 0-.108.417l8.597 8.597a.25.25 0 0 0 .417-.108l.961-3.366 1.443.412-.962 3.366a1.75 1.75 0 0 1-2.92.757Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "m3.405 2.095 18.75 18.75q.22.219.22.53 0 .311-.22.53-.219.22-.53.22-.311 0-.53-.22L2.345 3.155q-.22-.219-.22-.53 0-.311.22-.53.219-.22.53-.22.311 0 .53.22Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
