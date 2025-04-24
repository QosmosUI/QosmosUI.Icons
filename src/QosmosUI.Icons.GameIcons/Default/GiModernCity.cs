// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiModernCity : ComponentBase
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
		builder.AddAttribute(14, "d", "M217 25v30h30V25h-30zm48 0v30h30V25h-30zm48 0v30h30V25h-30zm-96 48v46h30V73h-30zm48 0v46h30V73h-30zm48 0v46h30V73h-30zm-96 64v46h30v-46h-30zm48 0v46h30v-46h-30zm48 0v46h30v-46h-30zm174 6.508l-94 53.715V215h94v-71.492zM217 201v46h30v-46h-30zm48 0v46h30v-46h-30zm48 0v46h30v-46h-30zm80 32v110h94V233h-94zM39 256v23h18v-23H39zm178 9v46h30v-46h-30zm48 0v46h30v-46h-30zm48 0v46h30v-46h-30zM37.562 297l-7 14h146.875l-7-14H37.563zM25 329v158h23v-23h32v23h48v-23h32v23h23V329H25zm192 0v46h30v-46h-30zm48 0v46h30v-46h-30zm48 0v46h30v-46h-30zM48 352h32v16H48v-16zm80 0h32v16h-32v-16zm265 9v126h31v-23h32v23h31V361h-94zM48 384h32v16H48v-16zm80 0h32v16h-32v-16zm89 9v46h30v-46h-30zm48 0v46h30v-46h-30zm48 0v46h30v-46h-30zM48 416h32v16H48v-16zm80 0h32v16h-32v-16zm89 41v30h30v-30h-30zm48 0v30h30v-30h-30zm48 0v30h30v-30h-30z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
