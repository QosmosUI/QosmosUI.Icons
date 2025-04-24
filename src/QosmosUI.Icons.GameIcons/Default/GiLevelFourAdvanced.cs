// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiLevelFourAdvanced : ComponentBase
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
		builder.AddAttribute(14, "d", "M16 16c48 96 24 120 72 168 0 0 48 0 72-24s24-72 24-72c-48-48-72-24-168-72zm144 144c-24.57 24.57-39.75 58.51-39.75 96s15.18 71.43 39.75 96c24.57 24.57 58.51 39.75 96 39.75s71.43-15.18 96-39.75c24.57-24.57 39.78-58.51 39.78-96s-15.21-71.43-39.78-96c-24.57-24.57-58.51-39.75-96-39.75s-71.43 15.18-96 39.75zm192 0c24 24 72 24 72 24 48-48 24-72 72-168-96 48-120 24-168 72 0 0 0 48 24 72zm0 192c-24 24-24 72-24 72 48 48 72 24 168 72-48-96-24-120-72-168 0 0-48 0-72 24zm-192 0c-24-24-72-24-72-24-48 48-24 72-72 168 96-48 120-24 168-72 0 0 0-48-24-72zm62.063-197.813h67.875v67.875h67.875v67.875h-67.875v67.875h-67.875v-67.875h-67.875v-67.875h67.875v-67.875z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
