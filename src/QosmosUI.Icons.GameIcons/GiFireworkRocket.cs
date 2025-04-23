// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiFireworkRocket : ComponentBase
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
		builder.AddAttribute(14, "d", "M487.375 26.906L356.5 56.47c-23.13 58.833 39.11 126.32 101.313 101.5l29.562-131.064zm-143.5 99.125L237.78 232.5c-3.703 22.683 2.47 38.328 16.94 46.47l10.718 6.03-8.688 8.72L57.625 492.686H83.78l314.19-317.28c-23.152-9.146-42.645-27.243-54.095-49.376zM218.75 233.126l-113.53 18.72 97.436 5.968-121.97 51.156 105.158-9.47-67.313 61.688 62.564-18.282 54.844-54.812c-13.938-12.937-19.78-32.964-17.188-54.97zM16.844 245.063v32.312l84.937-15.563-84.936-16.75zm263.75 75.437l-42.688 43.063-.875 67.75L280.595 320.5zm-161.97 2.625L16.845 341.5v44.094l101.78-62.47zm8.157 61.25l-110.124 47.22v65.124H27.22l1.28-1.283 41.03-41.03 57.25-70.032zm85.314 15.22l-39.156 97.217h38.78l.376-97.218zm58.78 1.967l-10.718 95.25h26.156l-15.437-95.25z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
