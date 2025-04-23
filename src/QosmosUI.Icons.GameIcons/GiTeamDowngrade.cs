// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiTeamDowngrade : ComponentBase
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
		builder.AddAttribute(14, "d", "M80.37 32v64h-32l48 64 48.03-64h-32V32H80.37zm160.03 0v64h-32l48 64 48-64h-32V32h-32zm160 0v64h-32l48 64 48-64h-32V32h-32zM96.37 192c-17.2 0-32.5 18.4-32.5 42.5 0 12.4 4.1 23.4 10.3 31l6.2 7.8-9.9 1.5c-9.4 1.5-15.8 6-21.1 13.1-5.3 7.1-9.2 16.9-11.6 28.4-4.7 20.9-4.8 46.6-4.8 69h25.9l6.3 98h59.73l7.2-98h27.3c-.1-22.1-1.2-47.5-6.3-68.3-2.8-11.3-6.7-21.2-12-28.4-5.1-7.1-11.4-11.6-19.9-13.2l-9.7-1.8 6.4-7.5c6.4-7.8 10.8-18.9 10.8-31.6 0-22.7-13.7-40.4-29.13-42.5h-3.2zm160.03 0c-17.2 0-32.5 18.4-32.5 42.5 0 12.4 4.1 23.4 10.3 31l6.2 7.8-9.9 1.5c-9.4 1.5-15.8 6-21.1 13.1-5.3 7.1-9.2 16.9-11.6 28.4-4.7 20.9-4.8 46.6-4.8 69h25.9l6.3 98h59.7l7.2-98h27.3c-.1-22.1-1.2-47.5-6.3-68.3-2.8-11.3-6.7-21.2-12-28.4-5.1-7.1-11.4-11.6-19.9-13.2l-9.7-1.8 6.4-7.5c6.4-7.8 10.8-18.9 10.8-31.6 0-22.7-13.7-40.4-29.1-42.5h-3.2zm160 0c-17.1 0-32.4 18.4-32.4 42.5 0 12.4 4.1 23.4 10.3 31l6.2 7.8-9.9 1.5c-9.4 1.5-15.9 6-21.2 13.1-5.3 7.1-9.2 16.9-11.6 28.4-4.7 20.9-4.8 46.6-4.8 69h25.9l6.4 98h59.6l7.3-98h27.2c-.1-22.1-1.2-47.5-6.2-68.3-2.8-11.3-6.8-21.2-12.1-28.4-5.1-7.1-11.4-11.6-19.8-13.2l-9.7-1.8 6.3-7.5c6.4-7.8 10.8-18.9 10.8-31.6 0-22.7-13.7-40.4-29.1-42.5h-3.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
