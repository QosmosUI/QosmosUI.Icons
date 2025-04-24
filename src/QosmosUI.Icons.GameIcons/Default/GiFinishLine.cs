// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFinishLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M23 24v464h18V386.9c152.3 29.4 277.6 29.4 430 0V488h18V24h-18v16h-23v32h23v32h-23v32h23v232.6c-153.3 29.9-276.7 29.9-430 0V104h23V72H41V24H23zm41 48h32V40H64v32zm32 0v32h32V72H96zm32 0h32V40h-32v32zm32 0v32h32V72h-32zm32 0h32V40h-32v32zm32 0v32h32V72h-32zm32 0h32V40h-32v32zm32 0v32h32V72h-32zm32 0h32V40h-32v32zm32 0v32h32V72h-32zm32 0h32V40h-32v32zm32 0v32h32V72h-32zm0 32h-32v32h32v-32zm-64 0h-32v32h32v-32zm-64 0h-32v32h32v-32zm-64 0h-32v32h32v-32zm-64 0h-32v32h32v-32zm-64 0H64v32h32v-32z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
