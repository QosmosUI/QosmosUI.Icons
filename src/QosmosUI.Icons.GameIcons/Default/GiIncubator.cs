// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiIncubator : ComponentBase
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
		builder.AddAttribute(14, "d", "M233 41v30h46V41h-46zm-9 48c-29.8 0-77.4 11.7-116.3 29.2-19.46 8.8-36.82 19-48.81 29.4-7.86 6.8-12.84 13.4-15.52 19.4H468.6c-2.6-6-7.6-12.6-15.5-19.4-12-10.4-29.3-20.6-48.8-29.4C365.4 100.7 317.8 89 288 89h-64zM72.8 202.6l-48 64 14.4 10.8 48-64-14.4-10.8zm299.7 0l-14.4 10.8 48 64 14.4-10.8-48-64zm66.7 0l-14.4 10.8 48 64 14.4-10.8-48-64zM130.7 204l-32.05 64 16.15 8 32-64-16.1-8zm57.9 1.8l-16 64 17.4 4.4 16-64-17.4-4.4zm134.8 0l-17.4 4.4 16 64 17.4-4.4-16-64zM247 208v64h18v-64h-18zM96 320c-28 0-56 53.3-56 106.6 0 26.7 28 53.3 56 53.3s56-26.6 56-53.3c0-53.3-28-106.6-56-106.6zm320 0c-28 0-56 53.3-56 106.6 0 26.7 28 53.3 56 53.3s56-26.6 56-53.3c0-53.3-28-106.6-56-106.6zm-160 .1c-28 0-56 53.3-56 106.6 0 26.7 28 53.3 56 53.3s56-26.6 56-53.3c0-53.3-28-106.6-56-106.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
