// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiWindowBars : ComponentBase
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
		builder.AddAttribute(14, "d", "M247 25.148c-15.572.503-31.055 2.31-46 5.424V55h46V25.148zm18 0V55h46V30.572c-14.945-3.115-30.428-4.92-46-5.424zm-82 9.9c-16.506 4.784-32.067 11.272-46 19.473V55h46V35.049zm146 0V55h46v-.479c-13.933-8.201-29.494-14.689-46-19.472zM111.73 73C87.921 94.666 73 123.662 73 160v23h46V73h-7.27zM137 73v110h46V73h-46zm64 0v110h46V73h-46zm64 0v110h46V73h-46zm64 0v110h46V73h-46zm64 0v110h46v-23c0-36.338-14.921-65.334-38.73-87H393zM73 201v110h46V201H73zm64 0v110h46V201h-46zm64 0v110h46V201h-46zm64 0v110h46V201h-46zm64 0v110h46V201h-46zm64 0v110h46V201h-46zM73 329v110h46V329H73zm64 0v110h46V329h-46zm64 0v110h46V329h-46zm64 0v110h46V329h-46zm64 0v110h46V329h-46zm64 0v110h46V329h-46zM41 457v30h430v-30H41z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
