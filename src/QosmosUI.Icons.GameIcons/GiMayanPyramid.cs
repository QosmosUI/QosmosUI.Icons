// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiMayanPyramid : ComponentBase
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
		builder.AddAttribute(14, "d", "M217 25v14h78V25h-78zm0 32v46h14V71h50v32h14V57h-78zm32 32v14h14V89h-14zm-64 32v46h30v-46h-30zm48 0v14h46v-14h-46zm64 0v46h30v-46h-30zm-64 32v14h46v-14h-46zm-80 32v46h62v-46h-62zm80 0v14h46v-14h-46zm64 0v46h62v-46h-62zm-64 32v14h46v-14h-46zm-112 32v46h94v-46h-94zm112 0v14h46v-14h-46zm64 0v46h94v-46h-94zm-64 32v14h46v-14h-46zM89 313v46h126v-46H89zm144 0v14h46v-14h-46zm64 0v46h126v-46H297zm-64 32v14h46v-14h-46zM57 377v46h158v-46H57zm176 0v14h46v-14h-46zm64 0v46h158v-46H297zm-64 32v14h46v-14h-46zM25 441v46h190v-46H25zm208 0v14h46v-14h-46zm64 0v46h190v-46H297zm-64 32v14h46v-14h-46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
